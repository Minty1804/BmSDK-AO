#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDisruptableObjectBase<br/>
/// (size = 612)
/// (flags = 142606482)
/// </summary>
public partial class RDisruptableObjectBase : BmSDK.Engine.Actor, BmSDK.BmGame.RSecretInterface, BmSDK.BmGame.RDisruptableInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDisruptableObjectBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RDisruptableObjectBase.
    /// </summary>
    public static RDisruptableObjectBase DefaultObject => (RDisruptableObjectBase)StaticClass().DefaultObject;

    internal RDisruptableObjectBase() { }

    /// <summary>
    /// Constructs a new RDisruptableObjectBase
    /// </summary>
    public RDisruptableObjectBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDisruptableObjectBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Unlock;
    /// <summary>
    /// Function: Unlock
    /// </summary>
    public unsafe virtual void Unlock(BmSDK.BmGame.MAEC_Search_Sub_RestoreDevice Unlocker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Unlock, "BmGame.RDisruptableObjectBase.Unlock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Unlocker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanResonate;
    /// <summary>
    /// Function: CanResonate
    /// </summary>
    public unsafe virtual bool CanResonate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanResonate, "BmGame.RDisruptableObjectBase.CanResonate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Steal;
    /// <summary>
    /// Function: Steal
    /// </summary>
    public unsafe virtual void Steal(BmSDK.BmGame.MAEC_Search_Sub_RestoreDevice NewLockedBy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Steal, "BmGame.RDisruptableObjectBase.Steal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLockedBy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Lock;
    /// <summary>
    /// Function: Lock
    /// </summary>
    public unsafe virtual bool Lock(BmSDK.BmGame.MAEC_Search_Sub_RestoreDevice NewLockedBy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Lock, "BmGame.RDisruptableObjectBase.Lock");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLockedBy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsLocked;
    /// <summary>
    /// Function: IsLocked
    /// </summary>
    public unsafe virtual bool IsLocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocked, "BmGame.RDisruptableObjectBase.IsLocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReadyToRestore;
    /// <summary>
    /// Function: ReadyToRestore
    /// </summary>
    public unsafe virtual bool ReadyToRestore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyToRestore, "BmGame.RDisruptableObjectBase.ReadyToRestore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMoveToLocation;
    /// <summary>
    /// Function: GetMoveToLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMoveToLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveToLocation, "BmGame.RDisruptableObjectBase.GetMoveToLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisallowLongRangeResonator;
    /// <summary>
    /// Function: DisallowLongRangeResonator
    /// </summary>
    public unsafe virtual bool DisallowLongRangeResonator()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisallowLongRangeResonator, "BmGame.RDisruptableObjectBase.DisallowLongRangeResonator");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumFakePasswordsToUse;
    /// <summary>
    /// Function: GetNumFakePasswordsToUse
    /// </summary>
    public unsafe virtual int GetNumFakePasswordsToUse(int CurrentStage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumFakePasswordsToUse, "BmGame.RDisruptableObjectBase.GetNumFakePasswordsToUse");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFakePassword;
    /// <summary>
    /// Function: GetFakePassword
    /// </summary>
    public unsafe virtual BmSDK.FString GetFakePassword(int CurrentStage, int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFakePassword, "BmGame.RDisruptableObjectBase.GetFakePassword");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentStage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPassword;
    /// <summary>
    /// Function: GetPassword
    /// </summary>
    public unsafe virtual BmSDK.FString GetPassword(int CurrentStage, int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPassword, "BmGame.RDisruptableObjectBase.GetPassword");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentStage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFakePasswordArrayLength;
    /// <summary>
    /// Function: GetFakePasswordArrayLength
    /// </summary>
    public unsafe virtual int GetFakePasswordArrayLength(int CurrentStage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFakePasswordArrayLength, "BmGame.RDisruptableObjectBase.GetFakePasswordArrayLength");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPasswordArrayLength;
    /// <summary>
    /// Function: GetPasswordArrayLength
    /// </summary>
    public unsafe virtual int GetPasswordArrayLength(int CurrentStage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPasswordArrayLength, "BmGame.RDisruptableObjectBase.GetPasswordArrayLength");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetResonatorMinigameStringReference;
    /// <summary>
    /// Function: GetResonatorMinigameStringReference
    /// </summary>
    public unsafe virtual BmSDK.FString GetResonatorMinigameStringReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResonatorMinigameStringReference, "BmGame.RDisruptableObjectBase.GetResonatorMinigameStringReference");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetResonatorWinScreenStringReference;
    /// <summary>
    /// Function: GetResonatorWinScreenStringReference
    /// </summary>
    public unsafe virtual BmSDK.FString GetResonatorWinScreenStringReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResonatorWinScreenStringReference, "BmGame.RDisruptableObjectBase.GetResonatorWinScreenStringReference");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHackingTargetType;
    /// <summary>
    /// Function: GetHackingTargetType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RDisruptableInterface.DisruptableObjectTargetType GetHackingTargetType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHackingTargetType, "BmGame.RDisruptableObjectBase.GetHackingTargetType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RDisruptableInterface.DisruptableObjectTargetType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHackingNetworkType;
    /// <summary>
    /// Function: GetHackingNetworkType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RDisruptableInterface.DisruptableObjectNetworkType GetHackingNetworkType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHackingNetworkType, "BmGame.RDisruptableObjectBase.GetHackingNetworkType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RDisruptableInterface.DisruptableObjectNetworkType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActiveFlag;
    /// <summary>
    /// Function: GetActiveFlag
    /// </summary>
    public unsafe virtual BmSDK.FName GetActiveFlag()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActiveFlag, "BmGame.RDisruptableObjectBase.GetActiveFlag");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNoCodesFailedDialogueLine;
    /// <summary>
    /// Function: GetNoCodesFailedDialogueLine
    /// </summary>
    public unsafe virtual BmSDK.Engine.RDialogueLine GetNoCodesFailedDialogueLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNoCodesFailedDialogueLine, "BmGame.RDisruptableObjectBase.GetNoCodesFailedDialogueLine");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RDialogueLine>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTimeLimit;
    /// <summary>
    /// Function: GetTimeLimit
    /// </summary>
    public unsafe virtual int GetTimeLimit(int Stage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeLimit, "BmGame.RDisruptableObjectBase.GetTimeLimit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRawDifficulty;
    /// <summary>
    /// Function: GetRawDifficulty
    /// </summary>
    public unsafe virtual int GetRawDifficulty(int Stage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRawDifficulty, "BmGame.RDisruptableObjectBase.GetRawDifficulty");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDifficultyLevel;
    /// <summary>
    /// Function: GetDifficultyLevel
    /// </summary>
    public unsafe virtual int GetDifficultyLevel(int Stage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficultyLevel, "BmGame.RDisruptableObjectBase.GetDifficultyLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FailedToDisrupt;
    /// <summary>
    /// Function: FailedToDisrupt
    /// </summary>
    public unsafe virtual void FailedToDisrupt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FailedToDisrupt, "BmGame.RDisruptableObjectBase.FailedToDisrupt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WillExplode;
    /// <summary>
    /// Function: WillExplode
    /// </summary>
    public unsafe virtual bool WillExplode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillExplode, "BmGame.RDisruptableObjectBase.WillExplode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetIconLocation;
    /// <summary>
    /// Function: GetIconLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetIconLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIconLocation, "BmGame.RDisruptableObjectBase.GetIconLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StillDisruptable;
    /// <summary>
    /// Function: StillDisruptable
    /// </summary>
    public unsafe virtual bool StillDisruptable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StillDisruptable, "BmGame.RDisruptableObjectBase.StillDisruptable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PasswordFound;
    /// <summary>
    /// Function: PasswordFound
    /// </summary>
    public unsafe virtual void PasswordFound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PasswordFound, "BmGame.RDisruptableObjectBase.PasswordFound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfullyDisrupted;
    /// <summary>
    /// Function: SuccessfullyDisrupted
    /// </summary>
    public unsafe virtual void SuccessfullyDisrupted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfullyDisrupted, "BmGame.RDisruptableObjectBase.SuccessfullyDisrupted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDifficulty;
    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe virtual void GetDifficulty(out float Threshold, out float BuildUpTime, out float LeftMaxAngVelocity, out float RightMaxAngVelocity, int DifficultyMod = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficulty, "BmGame.RDisruptableObjectBase.GetDifficulty");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Threshold);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Threshold, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BuildUpTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BuildUpTime, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LeftMaxAngVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftMaxAngVelocity, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RightMaxAngVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightMaxAngVelocity, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DifficultyMod, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Threshold = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        BuildUpTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        LeftMaxAngVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        RightMaxAngVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetInvestigateHighlighted;
    /// <summary>
    /// Function: SetInvestigateHighlighted
    /// </summary>
    public unsafe override void SetInvestigateHighlighted(BmSDK.Engine.MaterialInstanceConstant highMat, bool On)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigateHighlighted, "BmGame.RDisruptableObjectBase.SetInvestigateHighlighted");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(highMat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RDisruptableObjectBase.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RDisruptableObjectBase.PreStreamOut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RDisruptableObjectBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequiresHighSecurityResonator;
    /// <summary>
    /// Function: RequiresHighSecurityResonator
    /// </summary>
    public unsafe virtual bool RequiresHighSecurityResonator()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequiresHighSecurityResonator, "BmGame.RDisruptableObjectBase.RequiresHighSecurityResonator");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayExplodeSound;
    /// <summary>
    /// Function: PlayExplodeSound
    /// </summary>
    public unsafe virtual void PlayExplodeSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayExplodeSound, "BmGame.RDisruptableObjectBase.PlayExplodeSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAlarmSound;
    /// <summary>
    /// Function: StopAlarmSound
    /// </summary>
    public unsafe virtual void StopAlarmSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAlarmSound, "BmGame.RDisruptableObjectBase.StopAlarmSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAlarmSound;
    /// <summary>
    /// Function: PlayAlarmSound
    /// </summary>
    public unsafe virtual void PlayAlarmSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAlarmSound, "BmGame.RDisruptableObjectBase.PlayAlarmSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAlarmed;
    /// <summary>
    /// Function: IsAlarmed
    /// </summary>
    public unsafe virtual bool IsAlarmed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAlarmed, "BmGame.RDisruptableObjectBase.IsAlarmed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UseSecretLocation;
    /// <summary>
    /// Function: UseSecretLocation
    /// </summary>
    public unsafe virtual bool UseSecretLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseSecretLocation, "BmGame.RDisruptableObjectBase.UseSecretLocation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretLocationY;
    /// <summary>
    /// Function: GetSecretLocationY
    /// </summary>
    public unsafe virtual int GetSecretLocationY()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretLocationY, "BmGame.RDisruptableObjectBase.GetSecretLocationY");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretLocationX;
    /// <summary>
    /// Function: GetSecretLocationX
    /// </summary>
    public unsafe virtual int GetSecretLocationX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretLocationX, "BmGame.RDisruptableObjectBase.GetSecretLocationX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretGroup;
    /// <summary>
    /// Function: GetSecretGroup
    /// </summary>
    public unsafe virtual BmSDK.FString GetSecretGroup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretGroup, "BmGame.RDisruptableObjectBase.GetSecretGroup");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretIndex;
    /// <summary>
    /// Function: GetSecretIndex
    /// </summary>
    public unsafe virtual int GetSecretIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretIndex, "BmGame.RDisruptableObjectBase.GetSecretIndex");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretSubType;
    /// <summary>
    /// Function: GetSecretSubType
    /// </summary>
    public unsafe virtual BmSDK.FString GetSecretSubType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretSubType, "BmGame.RDisruptableObjectBase.GetSecretSubType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretName;
    /// <summary>
    /// Function: GetSecretName
    /// </summary>
    public unsafe virtual BmSDK.FString GetSecretName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretName, "BmGame.RDisruptableObjectBase.GetSecretName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidSecret;
    /// <summary>
    /// Function: IsValidSecret
    /// </summary>
    public unsafe virtual bool IsValidSecret()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidSecret, "BmGame.RDisruptableObjectBase.IsValidSecret");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetXRayMaterial;
    /// <summary>
    /// Function: SetXRayMaterial
    /// </summary>
    public unsafe virtual void SetXRayMaterial(BmSDK.Engine.StaticMeshComponent MeshComponent, BmSDK.Engine.MaterialInterface XRayMaterial)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXRayMaterial, "BmGame.RDisruptableObjectBase.SetXRayMaterial");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XRayMaterial, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetLocationToInvestigate;
    /// <summary>
    /// Function: GetLocationToInvestigate
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLocationToInvestigate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocationToInvestigate, "BmGame.RDisruptableObjectBase.GetLocationToInvestigate");
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

    /// <summary>
    /// Struct: FResonatorStages
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FResonatorStages
    {
        /// <summary>
        /// ByteProperty: Difficulty
        /// </summary>
        public unsafe BmSDK.BmGame.RDisruptableObjectBase.DisruptableObjectDifficulty Difficulty
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDisruptableObjectBase.DisruptableObjectDifficulty>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: TimeLimit
        /// </summary>
        public unsafe float TimeLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: LeftResonantFrequency
        /// </summary>
        public unsafe float LeftResonantFrequency
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: RightResonantFrequency
        /// </summary>
        public unsafe float RightResonantFrequency
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: PasswordArray
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> PasswordArray
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: FakePasswordArray
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> FakePasswordArray
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: NumFakePasswordsToUse
        /// </summary>
        public unsafe int NumFakePasswordsToUse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Enum: DisruptableObjectDifficulty
    /// </summary>
    public enum DisruptableObjectDifficulty : byte
    {
        DOD_VeryEasy = 0,
        DOD_Easy = 1,
        DOD_Medium = 2,
        DOD_Hard = 3,
        DOD_VeryHard = 4,
        DOD_Stupid = 5,
        DOD_MAX = 6,
    }

    /// <summary>
    /// StructProperty: VfTable_IRSecretInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSecretInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ComponentProperty: StaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent StaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ByteProperty: Difficulty
    /// </summary>
    public unsafe BmSDK.BmGame.RDisruptableObjectBase.DisruptableObjectDifficulty Difficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDisruptableObjectBase.DisruptableObjectDifficulty>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ByteProperty: HackingNetworkType
    /// </summary>
    public unsafe BmSDK.BmGame.RDisruptableInterface.DisruptableObjectNetworkType HackingNetworkType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDisruptableInterface.DisruptableObjectNetworkType>(Ptr + 461); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 461); }
    }

    /// <summary>
    /// ByteProperty: HackingTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RDisruptableInterface.DisruptableObjectTargetType HackingTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDisruptableInterface.DisruptableObjectTargetType>(Ptr + 462); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 462); }
    }

    /// <summary>
    /// StructProperty: DisruptableIconOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DisruptableIconOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 464);

    /// <summary>
    /// BoolProperty: bDisrupted
    /// </summary>
    public unsafe bool bDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bExplodes
    /// </summary>
    public unsafe bool bExplodes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bRequiresHighSecurityResonator
    /// </summary>
    public unsafe bool bRequiresHighSecurityResonator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDisabledForStory
    /// </summary>
    public unsafe bool bDisabledForStory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: RumbleEnabledInMinigame
    /// </summary>
    public unsafe bool RumbleEnabledInMinigame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDisabledWithAreaSecureMessage
    /// </summary>
    public unsafe bool bDisabledWithAreaSecureMessage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDisallowLongRangeResonator
    /// </summary>
    public unsafe bool bDisallowLongRangeResonator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bIsFirstHack
    /// </summary>
    public unsafe bool bIsFirstHack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bEnigmaTriesToCounterHack
    /// </summary>
    public unsafe bool bEnigmaTriesToCounterHack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// ObjectProperty: HighSecurityFailedDialogueLine
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine HighSecurityFailedDialogueLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: NoCodesFailedDialogueLine
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine NoCodesFailedDialogueLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ArrayProperty: OldMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> OldMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// NameProperty: ActiveFlag
    /// </summary>
    public unsafe BmSDK.FName ActiveFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: RightResonantFrequency
    /// </summary>
    public unsafe float RightResonantFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: LeftResonantFrequency
    /// </summary>
    public unsafe float LeftResonantFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ObjectProperty: ResonatorMinigamePackageReference
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ResonatorMinigamePackageReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StrProperty: ResonatorMinigameStringReference
    /// </summary>
    public unsafe BmSDK.FString ResonatorMinigameStringReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ArrayProperty: PasswordArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PasswordArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: FakePasswordArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FakePasswordArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: NumFakePasswordsToUse
    /// </summary>
    public unsafe int NumFakePasswordsToUse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: ResonatorWinScreenPackageReference
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ResonatorWinScreenPackageReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// StrProperty: ResonatorWinScreenStringReference
    /// </summary>
    public unsafe BmSDK.FString ResonatorWinScreenStringReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: ResonatorEnigmaCounterHackPackageReference
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ResonatorEnigmaCounterHackPackageReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// StrProperty: ResonatorUnlockFlag
    /// </summary>
    public unsafe BmSDK.FString ResonatorUnlockFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ArrayProperty: Stages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDisruptableObjectBase.FResonatorStages> Stages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDisruptableObjectBase.FResonatorStages>>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ObjectProperty: LockedBy
    /// </summary>
    public unsafe BmSDK.BmGame.MAEC_Search_Sub_RestoreDevice LockedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MAEC_Search_Sub_RestoreDevice>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ClassProperty: actionToRestoreDevice
    /// </summary>
    public unsafe BmSDK.Class actionToRestoreDevice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
}
