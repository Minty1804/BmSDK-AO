#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameInfo<br/>
/// (size = 1636)
/// (flags = 142606518)
/// </summary>
public partial class RGameInfo : BmSDK.BmGame.RGameInfoBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGameInfo.
    /// </summary>
    public static RGameInfo DefaultObject => (RGameInfo)StaticClass().DefaultObject;

    internal RGameInfo() { }

    /// <summary>
    /// Constructs a new RGameInfo
    /// </summary>
    public RGameInfo(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetHardwarePhysXLevelChanged
    /// </summary>
    public unsafe virtual void SetHardwarePhysXLevelChanged(bool Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetHardwarePhysXLevelChanged", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    /// <summary>
    /// Function: GetHardwarePhysXLevelChanged
    /// </summary>
    public unsafe virtual bool GetHardwarePhysXLevelChanged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetHardwarePhysXLevelChanged", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSecondaryKeyBinds
    /// </summary>
    public unsafe virtual int GetSecondaryKeyBinds(int AbilityId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetSecondaryKeyBinds", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetPrimaryKeyBinds
    /// </summary>
    public unsafe virtual int GetPrimaryKeyBinds(int AbilityId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPrimaryKeyBinds", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetSecondaryKeyBinds
    /// </summary>
    public unsafe virtual void SetSecondaryKeyBinds(int AbilityId, int KeyToBindTo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetSecondaryKeyBinds", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyToBindTo, paramsPtr + 4);
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

    /// <summary>
    /// Function: SetPrimaryKeyBinds
    /// </summary>
    public unsafe virtual void SetPrimaryKeyBinds(int AbilityId, int KeyToBindTo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetPrimaryKeyBinds", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyToBindTo, paramsPtr + 4);
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

    /// <summary>
    /// Function: DiscardCopyOfOptions
    /// </summary>
    public unsafe virtual void DiscardCopyOfOptions()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DiscardCopyOfOptions", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Function: RevertOptionsToCopy
    /// </summary>
    public unsafe virtual void RevertOptionsToCopy()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RevertOptionsToCopy", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Function: HaveOptionsChangedFromCopy
    /// </summary>
    public unsafe virtual bool HaveOptionsChangedFromCopy()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HaveOptionsChangedFromCopy", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MakeCopyOfOptions
    /// </summary>
    public unsafe virtual void MakeCopyOfOptions()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.MakeCopyOfOptions", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Function: SetAllDefaults
    /// </summary>
    public unsafe virtual void SetAllDefaults()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetAllDefaults", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Function: IsUsingD3D11
    /// </summary>
    public unsafe virtual bool IsUsingD3D11()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsUsingD3D11", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Is3DTVPresent
    /// </summary>
    public unsafe virtual bool Is3DTVPresent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Is3DTVPresent", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: InitGame
    /// </summary>
    public unsafe override void InitGame(BmSDK.FString Options, out BmSDK.FString ErrorMessage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InitGame", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime
    /// </summary>
    public unsafe virtual BmSDK.GameObject HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoesChallengeHaveARequiredCharacter
    /// </summary>
    public unsafe virtual bool DoesChallengeHaveARequiredCharacter(int Id)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DoesChallengeHaveARequiredCharacter", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetMainPlayableCharacter
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.EPlayableCharacters GetMainPlayableCharacter(int Id)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetMainPlayableCharacter", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EPlayableCharacters>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsPackInstalled
    /// </summary>
    public unsafe virtual bool IsPackInstalled(int ChallengePackId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsPackInstalled", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengePackId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetClosestLevelTransitionBatwing
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MLevelTransitionBatwingBase GetClosestLevelTransitionBatwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetClosestLevelTransitionBatwing", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MLevelTransitionBatwingBase>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RiddlerIcons_AnyLeftToReveal
    /// </summary>
    public unsafe virtual bool RiddlerIcons_AnyLeftToReveal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerIcons_AnyLeftToReveal", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RiddlesLeftSpecificMapCheck
    /// </summary>
    public unsafe virtual bool RiddlesLeftSpecificMapCheck(BmSDK.FString MapName, BmSDK.FString RiddleMapName, bool CWAllow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlesLeftSpecificMapCheck", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RiddleMapName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CWAllow, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: RiddlerIcons_GetIndexListOfClosest
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem> RiddlerIcons_GetIndexListOfClosest(BmSDK.FString MapName, int atX, int atY, int atZ, int MaxWanted)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerIcons_GetIndexListOfClosest", true);
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWanted, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem>>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: RiddlerIcons_GetIndexListForNearestToLoc
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem> RiddlerIcons_GetIndexListForNearestToLoc(BmSDK.FString MapName, int atX, int atY, int atZ, int MaxWanted, bool bHiddenOnly)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerIcons_GetIndexListForNearestToLoc", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWanted, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHiddenOnly, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem>>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: SortByIndexDist
    /// </summary>
    public unsafe virtual int SortByIndexDist(BmSDK.BmGame.RGameInfo.FIndexDistItem A, BmSDK.BmGame.RGameInfo.FIndexDistItem B)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SortByIndexDist", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ToggleDebugCamera
    /// </summary>
    public unsafe virtual void ToggleDebugCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ToggleDebugCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnregisterHelicopter
    /// </summary>
    public unsafe virtual void UnregisterHelicopter(BmSDK.BmGame.RHelicopterBase OldHeli)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UnregisterHelicopter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldHeli, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterHelicopter
    /// </summary>
    public unsafe virtual void RegisterHelicopter(BmSDK.BmGame.RHelicopterBase NewHeli)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RegisterHelicopter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHeli, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSmokeScreenCoverValue
    /// </summary>
    public unsafe virtual float GetSmokeScreenCoverValue(System.Numerics.Vector3 WorldPos, out byte bFireExtinguisher, out byte bSourcedByDualClaw)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetSmokeScreenCoverValue", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bFireExtinguisher = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 12);
        bSourcedByDualClaw = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 13);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: UpdateObjectiveMarkerVisibility
    /// </summary>
    public unsafe virtual void UpdateObjectiveMarkerVisibility()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateObjectiveMarkerVisibility", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateObjectiveMarker
    /// </summary>
    public unsafe virtual void ActivateObjectiveMarker(BmSDK.FName roomName, bool show)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ActivateObjectiveMarker", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(roomName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDialogueManager
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RDialogueManager GetDialogueManager()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetDialogueManager", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDialogueManager>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldSpawnAtStartSpot
    /// </summary>
    public unsafe override bool ShouldSpawnAtStartSpot(BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShouldSpawnAtStartSpot", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: EndGame
    /// </summary>
    public unsafe override void EndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.EndGame", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RoundEnded
    /// </summary>
    public unsafe virtual void RoundEnded()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RoundEnded", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RatePlayerStart
    /// </summary>
    public unsafe override float RatePlayerStart(BmSDK.Engine.PlayerStart P, byte Team, BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RatePlayerStart", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GameOver
    /// </summary>
    public unsafe virtual void GameOver(float TimeTillFade = default, bool PlayerDied = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GameOver", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeTillFade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerDied, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerDied
    /// </summary>
    public unsafe virtual void PlayerDied(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PlayerDied", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostLogin
    /// </summary>
    public unsafe override void PostLogin(BmSDK.Engine.PlayerController NewPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PostLogin", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleSeamlessTravelPlayer
    /// </summary>
    public unsafe override void HandleSeamlessTravelPlayer(out BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HandleSeamlessTravelPlayer", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: HandleLobby
    /// </summary>
    public unsafe virtual void HandleLobby(BmSDK.BmGame.RPlayerController LobbyPC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HandleLobby", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowLobby
    /// </summary>
    public unsafe virtual bool ShowLobby(BmSDK.BmGame.RPlayerController LobbyTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShowLobby", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: Game_ExitToFrontend
    /// </summary>
    public unsafe virtual void Game_ExitToFrontend()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_ExitToFrontend", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_PauseExitToFrontend
    /// </summary>
    public unsafe virtual void Game_PauseExitToFrontend()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_PauseExitToFrontend", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_Retry
    /// </summary>
    public unsafe virtual void Game_Retry()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_Retry", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_Restart
    /// </summary>
    public unsafe virtual void Game_Restart()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_Restart", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_ExitGame
    /// </summary>
    public unsafe virtual void Game_ExitGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_ExitGame", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_Continue
    /// </summary>
    public unsafe virtual void Game_Continue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_Continue", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_StartGameAt
    /// </summary>
    public unsafe virtual void Game_StartGameAt(BmSDK.FString AtName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_StartGameAt", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AtName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDefaultPlayerClass
    /// </summary>
    public unsafe override BmSDK.Class GetDefaultPlayerClass(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetDefaultPlayerClass", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetPlayerCharacterIndex
    /// </summary>
    public unsafe virtual int GetPlayerCharacterIndex(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlayerCharacterIndex", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SpawnDefaultPawnFor
    /// </summary>
    public unsafe override BmSDK.Engine.Pawn SpawnDefaultPawnFor(BmSDK.Engine.Controller NewPlayer, BmSDK.Engine.NavigationPoint StartSpot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SpawnDefaultPawnFor", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSpot, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetURLParam
    /// </summary>
    public unsafe virtual BmSDK.FString GetURLParam(BmSDK.FString Named)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetURLParam", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Named, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: HasURLParam
    /// </summary>
    public unsafe virtual bool HasURLParam(BmSDK.FString Named)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HasURLParam", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Named, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetGameTimePlayedString
    /// </summary>
    public unsafe virtual BmSDK.FString GetGameTimePlayedString()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetGameTimePlayedString", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGameTimePlayed
    /// </summary>
    public unsafe override float GetGameTimePlayed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetGameTimePlayed", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsFrontend
    /// </summary>
    public unsafe virtual bool IsFrontend()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsFrontend", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsChallengeMode
    /// </summary>
    public unsafe virtual bool IsChallengeMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsChallengeMode", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsStoryMode
    /// </summary>
    public unsafe virtual bool IsStoryMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsStoryMode", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindPredatorVolumeFor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPredatorVolume FindPredatorVolumeFor(BmSDK.Engine.Actor TestActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindPredatorVolumeFor", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPredatorVolume>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerHostageEndOfWaveEvents
    /// </summary>
    public unsafe virtual void TriggerHostageEndOfWaveEvents()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TriggerHostageEndOfWaveEvents", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetRoom
    /// </summary>
    public unsafe virtual void ResetRoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ResetRoom", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnhookRoomState
    /// </summary>
    public unsafe virtual void UnhookRoomState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UnhookRoomState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNewRoomAIState
    /// </summary>
    public unsafe virtual void SetNewRoomAIState(BmSDK.BmGame.RBMRoomAIState NewState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetNewRoomAIState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGameWindConfig
    /// </summary>
    public unsafe virtual void UpdateGameWindConfig(BmSDK.BmGame.RGameInfo.FRBasicWindConfig NewWind)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateGameWindConfig", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWind, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpPawnLevelVol
    /// </summary>
    public unsafe virtual void DumpPawnLevelVol()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpPawnLevelVol", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpRoomState
    /// </summary>
    public unsafe virtual void DumpRoomState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpRoomState", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpDialogueCoord
    /// </summary>
    public unsafe virtual void DumpDialogueCoord()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpDialogueCoord", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpAllNav
    /// </summary>
    public unsafe virtual void DumpAllNav()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpAllNav", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MakeTerrified
    /// </summary>
    public unsafe virtual void MakeTerrified()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.MakeTerrified", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BarkDewedge
    /// </summary>
    public unsafe virtual void BarkDewedge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.BarkDewedge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BarkWTF
    /// </summary>
    public unsafe virtual void BarkWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.BarkWTF", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TannoyFinished
    /// </summary>
    public unsafe virtual void TannoyFinished(BmSDK.BmGame.RGameInfo.ThugResponseType ResponseType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TannoyFinished", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResponseType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InformVillainsOfVentEntry
    /// </summary>
    public unsafe virtual bool InformVillainsOfVentEntry(BmSDK.Engine.Pawn VentPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InformVillainsOfVentEntry", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VentPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: InformVillainsPostGrapple
    /// </summary>
    public unsafe virtual bool InformVillainsPostGrapple(BmSDK.Engine.Pawn GrapplePlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InformVillainsPostGrapple", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: InformVillainsOfGrapple
    /// </summary>
    public unsafe virtual bool InformVillainsOfGrapple(BmSDK.Engine.Pawn GrapplePlayer, System.Numerics.Vector3 TargetHidePointLocation, bool bForcingBatmanHidden = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InformVillainsOfGrapple", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetHidePointLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForcingBatmanHidden, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: IsShootingSourceGarg
    /// </summary>
    public unsafe virtual bool IsShootingSourceGarg(BmSDK.Engine.Pawn GrapplePlayer, BmSDK.BmGame.RBMAIController AIC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsShootingSourceGarg", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AIC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: PlayerIsOnVantageBeingShotByThug
    /// </summary>
    public unsafe virtual bool PlayerIsOnVantageBeingShotByThug(BmSDK.BmGame.RPawnPlayer GrapplePlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PlayerIsOnVantageBeingShotByThug", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DoVisibilityHack
    /// </summary>
    public unsafe virtual void DoVisibilityHack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DoVisibilityHack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindStartleThugFromPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindStartleThugFromPoint(System.Numerics.Vector3 StartleCentre)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindStartleThugFromPoint", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartleCentre, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: DoPostRenderLogic
    /// </summary>
    public unsafe virtual void DoPostRenderLogic(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DoPostRenderLogic", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetWindAtPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWindAtPoint(System.Numerics.Vector3 ObjectPosition, System.Numerics.Vector3 ObjectVelocity)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetWindAtPoint", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectVelocity, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: UpdateGlobalWind
    /// </summary>
    public unsafe virtual void UpdateGlobalWind(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateGlobalWind", true);
        byte* paramsPtr = stackalloc byte[4];
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

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Tick", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanSpawnPawn
    /// </summary>
    public unsafe virtual bool CanSpawnPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CanSpawnPawn", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PawnSpawned
    /// </summary>
    public unsafe virtual void PawnSpawned()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PawnSpawned", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Function: Killed
    /// </summary>
    public unsafe override void Killed(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Killed", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LoadPC
    /// </summary>
    public unsafe virtual void LoadPC(BmSDK.FName PCName = default, int DamageLevel = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.LoadPC", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PCName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageLevel, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GoStartMatch
    /// </summary>
    public unsafe virtual void GoStartMatch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GoStartMatch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPlayerPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetPlayerPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlayerPawn", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetPlayerStartPoints
    /// </summary>
    public unsafe virtual void ResetPlayerStartPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ResetPlayerStartPoints", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckToStartMatch
    /// </summary>
    public unsafe virtual void CheckToStartMatch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CheckToStartMatch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TimedStartGame
    /// </summary>
    public unsafe virtual void TimedStartGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TimedStartGame", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe virtual void OnLevelChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.OnLevelChange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreCommitMapChange
    /// </summary>
    public unsafe override void PreCommitMapChange(BmSDK.FString aPreviousMapName, BmSDK.FString NextMapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PreCommitMapChange", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPreviousMapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsCombatChallenge
    /// </summary>
    public unsafe virtual bool IsCombatChallenge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsCombatChallenge", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CreateStatsLogging
    /// </summary>
    public unsafe virtual void CreateStatsLogging()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CreateStatsLogging", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetEnableStatsWriter
    /// </summary>
    public unsafe virtual bool GetEnableStatsWriter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetEnableStatsWriter", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PostCommitMapChange
    /// </summary>
    public unsafe override void PostCommitMapChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PostCommitMapChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PreBeginPlay", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowCheats
    /// </summary>
    public unsafe override bool AllowCheats(BmSDK.Engine.PlayerController P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AllowCheats", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe virtual int GetDifficulty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetDifficulty", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsGadgetAction
    /// </summary>
    public unsafe virtual bool IsGadgetAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsGadgetAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsStunAction
    /// </summary>
    public unsafe virtual bool IsStunAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsStunAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsSpecialAction
    /// </summary>
    public unsafe virtual bool IsSpecialAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsSpecialAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsRepeatedAction
    /// </summary>
    public unsafe virtual bool IsRepeatedAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsRepeatedAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsTakedownAction
    /// </summary>
    public unsafe virtual bool IsTakedownAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsTakedownAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsCombatKOAction
    /// </summary>
    public unsafe virtual bool IsCombatKOAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsCombatKOAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: WaitToBankXP
    /// </summary>
    public unsafe virtual bool WaitToBankXP()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.WaitToBankXP", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsCurrentPredZoneAlerted
    /// </summary>
    public unsafe virtual bool IsCurrentPredZoneAlerted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsCurrentPredZoneAlerted", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindProjectileArc
    /// </summary>
    public unsafe virtual bool FindProjectileArc(BmSDK.Engine.Actor TraceActor, out System.Numerics.Vector3 ThrowVelocity, out float FlightTime, System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindProjectileArc", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThrowVelocity = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
        FlightTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: SecuROMProtectionCheck4
    /// </summary>
    public unsafe virtual int SecuROMProtectionCheck4(int A, int B)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck4", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SecuROMProtectionCheck3
    /// </summary>
    public unsafe virtual int SecuROMProtectionCheck3()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck3", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SecuROMProtectionCheck2
    /// </summary>
    public unsafe virtual bool SecuROMProtectionCheck2()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck2", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SecuROMProtectionCheck1
    /// </summary>
    public unsafe virtual bool SecuROMProtectionCheck1()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck1", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLanguageForScriptCode
    /// </summary>
    public unsafe virtual BmSDK.FString GetLanguageForScriptCode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLanguageForScriptCode", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPlyrPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetPlyrPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlyrPawn", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerController GetPC()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPC", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CachePC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerController CachePC()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CachePC", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumLocalPlayers
    /// </summary>
    public unsafe virtual int GetNumLocalPlayers()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetNumLocalPlayers", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsPlayerBmCash
    /// </summary>
    public unsafe virtual bool IsPlayerBmCash()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsPlayerBmCash", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsPlayerNinjaBruce
    /// </summary>
    public unsafe virtual bool IsPlayerNinjaBruce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsPlayerNinjaBruce", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsPlayerDeathstroke
    /// </summary>
    public unsafe virtual bool IsPlayerDeathstroke()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsPlayerDeathstroke", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLevelVolumeFor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RLevelVolume GetLevelVolumeFor(BmSDK.GameObject Obj)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLevelVolumeFor", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetStoryIndex
    /// </summary>
    public unsafe virtual int GetStoryIndex(int Id)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetStoryIndex", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsStoryPresent
    /// </summary>
    public unsafe virtual bool IsStoryPresent(int Id)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsStoryPresent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsAStoryAvailable
    /// </summary>
    public unsafe virtual bool IsAStoryAvailable(out int Count)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsAStoryAvailable", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Count = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetStoryCount
    /// </summary>
    public unsafe virtual int GetStoryCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetStoryCount", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetIsSaveInProgress
    /// </summary>
    public unsafe virtual bool GetIsSaveInProgress()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetIsSaveInProgress", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSaveGameSize
    /// </summary>
    public unsafe virtual int GetSaveGameSize()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetSaveGameSize", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsDLCInstalled
    /// </summary>
    public unsafe virtual bool IsDLCInstalled(BmSDK.FString DLCBundleName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsDLCInstalled", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DLCBundleName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: EndLogging
    /// </summary>
    public unsafe override void EndLogging(BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.EndLogging", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FStoryDLCItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FStoryDLCItem
    {
        /// <summary>
        /// IntProperty: PackId
        /// </summary>
        public unsafe int PackId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: PersistentSaveSlotId
        /// </summary>
        public unsafe int PersistentSaveSlotId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: BaseCharacter
        /// </summary>
        public unsafe BmSDK.FString BaseCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: NewGameStart
        /// </summary>
        public unsafe BmSDK.FString NewGameStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FMapTowerInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FMapTowerInfo
    {
        /// <summary>
        /// FloatProperty: EffectRadius
        /// </summary>
        public unsafe float EffectRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FMapElementsItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FMapElementsItem
    {
        /// <summary>
        /// StrProperty: ItemType
        /// </summary>
        public unsafe BmSDK.FString ItemType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ItemSubType
        /// </summary>
        public unsafe BmSDK.FString ItemSubType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: ItemName
        /// </summary>
        public unsafe BmSDK.FString ItemName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StrProperty: MapName
        /// </summary>
        public unsafe BmSDK.FString MapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: X
        /// </summary>
        public unsafe int X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: Y
        /// </summary>
        public unsafe int Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// IntProperty: Z
        /// </summary>
        public unsafe int Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FMapElements
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMapElements
    {
        /// <summary>
        /// StrProperty: MapName
        /// </summary>
        public unsafe BmSDK.FString MapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Base
        /// </summary>
        public unsafe int Base
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Count
        /// </summary>
        public unsafe int Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FIndexDistItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FIndexDistItem
    {
        /// <summary>
        /// IntProperty: Index
        /// </summary>
        public unsafe int Index
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FMapHackOWLoc
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FMapHackOWLoc
    {
        /// <summary>
        /// StrProperty: SubName
        /// </summary>
        public unsafe BmSDK.FString SubName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: X
        /// </summary>
        public unsafe int X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Y
        /// </summary>
        public unsafe int Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Z
        /// </summary>
        public unsafe int Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: SubX
        /// </summary>
        public unsafe int SubX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: SubY
        /// </summary>
        public unsafe int SubY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: SubZ
        /// </summary>
        public unsafe int SubZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StrProperty: FlagCheck
        /// </summary>
        public unsafe BmSDK.FString FlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FChallengeUnlockCondition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FChallengeUnlockCondition
    {
        /// <summary>
        /// ArrayProperty: RequiredUnlockedIds
        /// </summary>
        public unsafe BmSDK.TArray<int> RequiredUnlockedIds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: RequiredCompletedIds
        /// </summary>
        public unsafe BmSDK.TArray<int> RequiredCompletedIds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: UnlockIds
        /// </summary>
        public unsafe BmSDK.TArray<int> UnlockIds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FRequiredChallengeCharacter
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FRequiredChallengeCharacter
    {
        /// <summary>
        /// ByteProperty: CharacterId
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EPlayableCharacters CharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EPlayableCharacters>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FMapItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 140)]
    public partial record struct FMapItem
    {
        /// <summary>
        /// StrProperty: Row
        /// </summary>
        public unsafe BmSDK.FString Row
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: PackId
        /// </summary>
        public unsafe int PackId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: ImageId
        /// </summary>
        public unsafe int ImageId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: SId
        /// </summary>
        public unsafe int SId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ByteProperty: CharacterId
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EPlayableCharacters CharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EPlayableCharacters>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: Mask1
        /// </summary>
        public unsafe int Mask1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: Mask2
        /// </summary>
        public unsafe int Mask2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: RFCMask
        /// </summary>
        public unsafe int RFCMask
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StrProperty: Start
        /// </summary>
        public unsafe BmSDK.FString Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bPredator
        /// </summary>
        public unsafe bool bPredator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bNotCustom
        /// </summary>
        public unsafe bool bNotCustom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bCombatTraining
        /// </summary>
        public unsafe bool bCombatTraining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// ArrayProperty: Modifiers
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers> Modifiers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers>>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: ForceOneModifier
        /// </summary>
        public unsafe bool ForceOneModifier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// IntProperty: Retries
        /// </summary>
        public unsafe int Retries
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// ArrayProperty: CampaignEntry
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapCampaignEntry> CampaignEntry
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapCampaignEntry>>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// ArrayProperty: DefaultChallengeScores
        /// </summary>
        public unsafe BmSDK.TArray<int> DefaultChallengeScores
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// ArrayProperty: DefaultChallengeActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge> DefaultChallengeActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }

        /// <summary>
        /// ArrayProperty: DefaultTrainingActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining> DefaultTrainingActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining>>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }
    }

    /// <summary>
    /// Enum: EPlayableCharacters
    /// </summary>
    public enum EPlayableCharacters : byte
    {
        PLR_Batman = 0,
        PLR_Deathstroke = 1,
        PLR_NinjaBruce = 2,
        PLR_Extra2 = 3,
        PLR_Extra3 = 4,
        PLR_Extra4 = 5,
        PLR_Cash1 = 6,
        PLR_Cash2 = 7,
        PLR_Cash3 = 8,
        PLR_MAX = 9,
    }

    /// <summary>
    /// Struct: FMapCampaignEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FMapCampaignEntry
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: EStasisLevel
    /// </summary>
    public enum EStasisLevel : byte
    {
        STASISLEVEL_Normal = 0,
        STASISLEVEL_Cheap = 1,
        STASISLEVEL_SuperCheap = 2,
        STASISLEVEL_MAX = 3,
    }

    /// <summary>
    /// Struct: FFloorCorrectionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FFloorCorrectionConfig
    {
        /// <summary>
        /// StructProperty: Standing
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig Standing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Moving
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig Moving
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: OnCeiling
        /// </summary>
        public unsafe bool OnCeiling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: CatwomanCrawlingHack
        /// </summary>
        public unsafe bool CatwomanCrawlingHack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FFloorMovementCorrectionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FFloorMovementCorrectionConfig
    {
        /// <summary>
        /// FloatProperty: Along
        /// </summary>
        public unsafe float Along
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Up
        /// </summary>
        public unsafe float Up
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Down
        /// </summary>
        public unsafe float Down
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Orientation
        /// </summary>
        public unsafe float Orientation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: OrientationPivotZ
        /// </summary>
        public unsafe float OrientationPivotZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FRWindState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FRWindState
    {
        /// <summary>
        /// StructProperty: WindVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 WindVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SourceVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 SourceVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: SourceAcceleration
        /// </summary>
        public unsafe System.Numerics.Vector3 SourceAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: TargetVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: TargetAcceleration
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: TotalInterpolationTime
        /// </summary>
        public unsafe float TotalInterpolationTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: RemainingInterpolationTime
        /// </summary>
        public unsafe float RemainingInterpolationTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FRWindConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FRWindConfig
    {
        /// <summary>
        /// BoolProperty: IsApplyWind
        /// </summary>
        public unsafe bool IsApplyWind
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WindVelocityCentre
        /// </summary>
        public unsafe System.Numerics.Vector3 WindVelocityCentre
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: WindVelocityRadius
        /// </summary>
        public unsafe float WindVelocityRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MaxWindAccelerationRadius
        /// </summary>
        public unsafe float MaxWindAccelerationRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MinTargetChangePeriod
        /// </summary>
        public unsafe float MinTargetChangePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxTargetChangePeriod
        /// </summary>
        public unsafe float MaxTargetChangePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: WindForceCoefficient
        /// </summary>
        public unsafe float WindForceCoefficient
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FRBasicWindConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FRBasicWindConfig
    {
        /// <summary>
        /// BoolProperty: IsApplyWind
        /// </summary>
        public unsafe bool IsApplyWind
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: IsApplyApexWind
        /// </summary>
        public unsafe bool IsApplyApexWind
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WindDirection
        /// </summary>
        public unsafe System.Numerics.Vector3 WindDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: WindDirectionNormalized
        /// </summary>
        public unsafe System.Numerics.Vector3 WindDirectionNormalized
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: WindBlusteryness
        /// </summary>
        public unsafe float WindBlusteryness
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: BaseLength
        /// </summary>
        public unsafe float BaseLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: ModulatedLength
        /// </summary>
        public unsafe float ModulatedLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Enum: ESpecialMoveAnimSetType
    /// </summary>
    public enum ESpecialMoveAnimSetType : byte
    {
        SMAT_LadderAnims = 0,
        SMAT_GrateRipAnims = 1,
        SMAT_GrateKickAnims = 2,
        SMAT_EnvironmentInteractionAnims = 3,
        SMAT_BossAnims = 4,
        SMAT_FloorGrateAnims = 5,
        SMAT_DoorAnims = 6,
        SMAT_FloorHatchAnims = 7,
        SMAT_None = 8,
        SMAT_MAX = 9,
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
        BGL_GlueGrenade = 9,
        BGL_SmokeBomb = 10,
        BGL_JammerGadget = 11,
        BGL_GlueClusterGrenade = 12,
        BGL_ShockGloves = 13,
        BGL_RemoteClaw = 14,
        BGL_WeaponDisruptor = 15,
        BGL_StunGrenade = 16,
        BGL_HeatGloves = 17,
        BGL_MAX = 18,
    }

    /// <summary>
    /// Enum: DifficultyLevels
    /// </summary>
    public enum DifficultyLevels : byte
    {
        Difficulty_Easy = 0,
        Difficulty_Normal = 1,
        Difficulty_Hard = 2,
        Difficulty_MAX = 3,
    }

    /// <summary>
    /// Enum: ECombatPawnType
    /// </summary>
    public enum ECombatPawnType : byte
    {
        ECPT_None = 0,
        ECPT_Player = 1,
        ECPT_Companion = 2,
        ECPT_Henchmen = 3,
        ECPT_Friendly = 4,
        ECPT_Thug = 5,
        ECPT_Flying = 6,
        ECPT_Lieutenant = 7,
        ECPT_Lunatic = 8,
        ECPT_Venom = 9,
        ECPT_Ninja = 10,
        ECPT_Outcast = 11,
        ECPT_ToughThug = 12,
        ECPT_ClayfaceDrone = 13,
        ECPT_ArmouredLieutenant = 14,
        ECPT_Sniper = 15,
        ECPT_Armoured = 16,
        ECPT_Juggernaut = 17,
        ECPT_ThugPredRiffle = 18,
        ECPT_ThugPredThermal = 19,
        ECPT_ThugPredMine = 20,
        ECPT_ThugPredJammer = 21,
        ECPT_BaneBoss = 22,
        ECPT_DeathstrokeBoss = 23,
        ECPT_FireFly = 24,
        ECPT_VenomThug = 25,
        ECPT_MartialArtist = 26,
        ECPT_KillerCrocBoss = 27,
        ECPT_BaneTitanBoss = 28,
        ECPT_ThugPredSniper = 29,
        ECPT_ThugPredArmoured = 30,
        ECPT_Anarky = 31,
        ECPT_DeadshotBoss = 32,
        ECPT_CopperheadBoss = 33,
        ECPT_ShivaBoss = 34,
        ECPT_BirdBoss = 35,
        ECPT_BlackMaskBoss = 36,
        ECPT_Gordon = 37,
        ECPT_FreezeThugCombat = 38,
        ECPT_FreezeThugPred = 39,
        ECPT_CASHDLC_MrFreeze = 40,
        ECPT_MAX = 41,
    }

    /// <summary>
    /// Enum: GangTypeEnum
    /// </summary>
    public enum GangTypeEnum : byte
    {
        GangType_None = 0,
        GangType_Joker = 1,
        GangType_Penguin = 2,
        GangType_Copperhead = 3,
        GangType_Tyger = 4,
        GangType_TwoFace = 5,
        GangType_Outcast = 6,
        GangType_BlackGate = 7,
        GangType_BlackMask = 8,
        GangType_Bane = 9,
        GangType_GCPD = 10,
        GangType_Prisoner = 11,
        GangType_Hobo = 12,
        GangType_Anarky = 13,
        GangType_Gotham = 14,
        GangType_Swat = 15,
        GangType_MadHatter = 16,
        GangType_Shiva = 17,
        GangType_Civilian = 18,
        GangType_Falcone = 19,
        GangType_MAX = 20,
    }

    /// <summary>
    /// Enum: ThugResponseType
    /// </summary>
    public enum ThugResponseType : byte
    {
        TRS_None = 0,
        TRS_Ambient = 1,
        TRS_MAX = 2,
    }

    /// <summary>
    /// Enum: GameCombatCameraType
    /// </summary>
    public enum GameCombatCameraType : byte
    {
        GCCT_BrawlComatCamera = 0,
        GCCT_CorridorCombatCamera = 1,
        GCCT_HighCombatCamera = 2,
        GCCT_MAX = 3,
    }

    /// <summary>
    /// Struct: FSoundSurface
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FSoundSurface
    {
        /// <summary>
        /// ObjectProperty: SurfaceType
        /// </summary>
        public unsafe BmSDK.Engine.AkSwitchName SurfaceType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: CameraLookAtSpeed
    /// </summary>
    public enum CameraLookAtSpeed : byte
    {
        CLASP_Slow = 0,
        CLASP_Medium = 1,
        CLASP_Fast = 2,
        CLASP_VeryFast = 3,
        CLASP_VerySlow = 4,
        CLASP_MAX = 5,
    }

    /// <summary>
    /// Enum: CameraLookAtStrength
    /// </summary>
    public enum CameraLookAtStrength : byte
    {
        CLAS_ForceCamera = 0,
        CLAS_ForceUntilLookAtNeutral = 1,
        CLAS_LookAtWeakNoDrag = 2,
        CLAS_LookAtWeak = 3,
        CLAS_MAX = 4,
    }

    /// <summary>
    /// Enum: CameraLookAtType
    /// </summary>
    public enum CameraLookAtType : byte
    {
        CLAT_NoLookAt = 0,
        CLAT_LookAtRotation = 1,
        CLAT_LookAtLocation = 2,
        CLAT_LookAtActor = 3,
        CLAT_MAX = 4,
    }

    /// <summary>
    /// Enum: ECombatLockType
    /// </summary>
    public enum ECombatLockType : byte
    {
        ECLT_None = 0,
        ECLT_Thugs = 1,
        ECLT_Lunatics = 2,
        ECLT_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeModifiers
    /// </summary>
    public enum EChallengeModifiers : byte
    {
        CMod_None = 0,
        CMod_Neg_ExtremeEnemies = 1,
        CMod_Neg_TimeLimit = 2,
        CMod_Neg_IncreasedAggression = 3,
        CMod_Neg_DecreasedHealth = 4,
        CMod_Neg_ProtectiveAura = 5,
        CMod_Neg_DangerZones = 6,
        CMod_Neg_OneHandTied = 7,
        CMod_Neg_ScatteredWeapons = 8,
        CMod_Pos_ReplenishingHealth = 9,
        CMod_Pos_TakedownProjectiles = 10,
        CMod_Pos_SuperPowered = 11,
        CMod_Pos_FreeMedal = 12,
        CMod_MAX = 13,
    }

    /// <summary>
    /// Enum: EChallengeModifierType
    /// </summary>
    public enum EChallengeModifierType : byte
    {
        EChallengeModifier_None = 0,
        EChallengeModifier_Example1 = 1,
        EChallengeModifier_Example2 = 2,
        EChallengeModifier_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeCharacter
    /// </summary>
    public enum EChallengeCharacter : byte
    {
        ECCID_Batman = 0,
        ECCID_BatmanArmoured = 1,
        ECCID_Joker = 2,
        ECCID_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeMode
    /// </summary>
    public enum EChallengeMode : byte
    {
        ECMID_Combat = 0,
        ECMID_CombatEndurance = 1,
        ECMID_Predator = 2,
        ECMID_CombatTraining = 3,
        ECMID_MAX = 4,
    }

    /// <summary>
    /// Enum: EWeaponCacheID
    /// </summary>
    public enum EWeaponCacheID : byte
    {
        WeaponCache_Satchel = 0,
        WeaponCache_Case = 1,
        WeaponCache_Crate = 2,
        WeaponCache_Container = 3,
        WeaponCache_Case2 = 4,
        WeaponCache_Crate2 = 5,
        WeaponCache_MAX = 6,
    }

    /// <summary>
    /// Enum: EAchievementID
    /// </summary>
    public enum EAchievementID : byte
    {
        EACID_None = 0,
        EACID_City_Of_Assasins = 1,
        EACID_One_Eye_Open = 2,
        EACID_Nobody_That_Matters = 3,
        EACID_Everyone_Wears_Masks = 4,
        EACID_One_Rule = 5,
        EACID_Perhaps_Sooner_Perhaps_Later = 6,
        EACID_Shut_Down = 7,
        EACID_Counterintelligence = 8,
        EACID_Enigma_Unravelled = 9,
        EACID_The_Collector = 10,
        EACID_One_Down_Serveral_To_Go = 11,
        EACID_Between_The_Innocent_And_The_Predatory = 12,
        EACID_Shadow_Vigilante = 13,
        EACID_Gotham_Protector = 14,
        EACID_Worst_Nightmare = 15,
        EACID_Worlds_Greatest_Detective = 16,
        EACID_Legend_Of_The_Dark_Knight = 17,
        EACID_Crime_Scene_investigator = 18,
        EACID_Crime_Fighter = 19,
        EACID_Thanks_Old_Friend = 20,
        EACID_Personal_Trainer = 21,
        EACID_Perfectionist = 22,
        EACID_Fully_Loaded = 23,
        EACID_Free_Flow_Fifty = 24,
        EACID_Anyone_See_That = 25,
        EACID_What_Hit_Me = 26,
        EACID_Silent_Knight = 27,
        EACID_Point_To_Point = 28,
        EACID_Frequent_Flyer = 29,
        EACID_Flawless_Display = 30,
        EACID_Point_CounterPoint = 31,
        EACID_Focus_Gadgeteer = 32,
        EACID_Air_Marathon = 33,
        EACID_Medalist = 34,
        EACID_Olympian = 35,
        EACID_Voice_Of_The_People = 36,
        EACID_Clean_Streets = 37,
        EACID_Earth_Prime = 38,
        EACID_God_Amongst_Us = 39,
        EACID_SKIPPED_1 = 40,
        EACID_MP_1 = 41,
        EACID_MP_2 = 42,
        EACID_MP_3 = 43,
        EACID_MP_4 = 44,
        EACID_MP_5 = 45,
        EACID_MP_6 = 46,
        EACID_MP_7 = 47,
        EACID_MP_8 = 48,
        EACID_MP_9 = 49,
        EACID_MP_10 = 50,
        EACID_SKIPPED_2 = 51,
        EACID_MP_11 = 52,
        EACID_Bruces_Revenge = 53,
        EACID_Campaign_Ninja = 54,
        EACID_MAX = 55,
    }

    /// <summary>
    /// Enum: SContexts
    /// </summary>
    public enum SContexts : byte
    {
        SContexts_OVERWORLD = 0,
        SContexts_COURT = 1,
        SContexts_CHURCH = 2,
        SContexts_STEEL = 3,
        SContexts_MUSEUM = 4,
        SContexts_UNDERWORLD = 5,
        SContexts_GCPD = 6,
        SContexts_RIDDLER = 7,
        SContexts_IVYLAIR = 8,
        SContexts_CW = 9,
        SContexts_ZSASZ = 10,
        SContexts_NORA = 11,
        SContexts_MADHATTER = 12,
        SContexts_BANE = 13,
        SContexts_HUSH = 14,
        SContexts_MAX = 15,
    }

    /// <summary>
    /// Enum: EContexts
    /// </summary>
    public enum EContexts : byte
    {
        EContexts_CHALLENGE = 0,
        EContexts_Nothing = 1,
        EContexts_CHALLENGETYPE = 2,
        EContexts_Nothing3 = 3,
        EContexts_Nothing4 = 4,
        EContexts_Nothing5 = 5,
        EContexts_Nothing6 = 6,
        EContexts_STORYTYPE = 7,
        EContexts_FrontEnd = 8,
        EContexts_MAX = 9,
    }

    /// <summary>
    /// Enum: EPresenceID
    /// </summary>
    public enum EPresenceID : byte
    {
        EPresence_Idle = 0,
        EPresence_Frontend = 1,
        EPresence_Story = 2,
        EPresence_Challenge = 3,
        EPresence_Multiplayer = 4,
        EPresence_MAX = 5,
    }

    /// <summary>
    /// Enum: EComboMoveType
    /// </summary>
    public enum EComboMoveType : byte
    {
        ECMT_Strike = 0,
        ECMT_PowerStrike = 1,
        ECMT_Counter = 2,
        ECMT_Stun = 3,
        ECMT_SuperStun = 4,
        ECMT_Evade = 5,
        ECMT_Redirect = 6,
        ECMT_ProjectileCounter = 7,
        ECMT_AerialAttack = 8,
        ECMT_DirectedAerialAttack = 9,
        ECMT_GroundTakedown = 10,
        ECMT_BeatdownStart = 11,
        ECMT_BeatdownStrike = 12,
        ECMT_BeatdownFinish = 13,
        ECMT_BladeComboCounter = 14,
        ECMT_SuperBladeComboCounter = 15,
        ECMT_ElectricFloor = 16,
        ECMT_TitanStrike = 17,
        ECMT_TitanRideStrike = 18,
        ECMT_TitanRideShockwave = 19,
        ECMT_TitanRideCharge = 20,
        ECMT_TitanFinish = 21,
        ECMT_TitanBerserk = 22,
        ECMT_LieutenantFinish = 23,
        ECMT_Takedown = 24,
        ECMT_Batarang = 25,
        ECMT_Batclaw = 26,
        ECMT_BatclawSlam = 27,
        ECMT_SmokePellet = 28,
        ECMT_REC = 29,
        ECMT_Freeze = 30,
        ECMT_Gel = 31,
        ECMT_BMDisarmAndDestroy = 32,
        ECMT_BMBatswarm = 33,
        ECMT_BMGroupGroundKO = 34,
        ECMT_CWProjectile = 35,
        ECMT_CWBullwhip = 36,
        ECMT_CWGroupTrip = 37,
        ECMT_CWGroupAttack = 38,
        ECMT_CWCaltrops = 39,
        ECMT_RBProjectile = 40,
        ECMT_RBStickyBomb = 41,
        ECMT_RBZipKick = 42,
        ECMT_RBShieldCharge = 43,
        ECMT_RBThrow = 44,
        ECMT_RBThrowRingOut = 45,
        ECMT_RBThrowKnockdown = 46,
        ECMT_RBGroupAttack = 47,
        ECMT_NWProjectile = 48,
        ECMT_NWGroupElectrify = 49,
        ECMT_NWGroupAttack = 50,
        ECMT_NWGroupStun = 51,
        ECMT_NWDart = 52,
        ECMT_NWDartHeadShot = 53,
        ECMT_NWStick = 54,
        ECMT_Slide = 55,
        ECMT_Glue = 56,
        ECMT_MartialArtistComboChainCounterKick = 57,
        ECMT_CounterCriticalStrike = 58,
        ECMT_ShockGloves = 59,
        ECMT_RemoteClaw = 60,
        ECMT_DKRemoteBomb = 61,
        ECMT_RemoveArmour = 62,
        ECMT_Concussion = 63,
        ECMT_NBCaltrops = 64,
        ECMT_NBShurikenVolley = 65,
        ECMT_MartialArtistChainAttackCounter = 66,
        ECMT_MartialArtistComboChainSingleCounter = 67,
        ECMT_ExplosivePullRopeTakedown = 68,
        ECMT_NBShadowStrike = 69,
        ECMT_GlueSmashTakedown = 70,
        ECMT_ShockGlovesTakedown = 71,
        ECMT_MAX = 72,
    }

    /// <summary>
    /// Enum: RagdollStunType
    /// </summary>
    public enum RagdollStunType : byte
    {
        RAGSTUN_Generic = 0,
        RAGSTUN_Batarang = 1,
        RAGSTUN_BatClaw = 2,
        RAGSTUN_GlideKick = 3,
        RAGSTUN_LineLaunchKick = 4,
        RAGSTUN_SwingKick = 5,
        RAGSTUN_Throw = 6,
        RAGSTUN_PounceAttack = 7,
        RAGSTUN_CaltropsTrap = 8,
        RAGSTUN_BoomerangBatarang = 9,
        RAGSTUN_DropAttack = 10,
        RAGSTUN_GelWeaponCrate = 11,
        RAGSTUN_SlideAttack = 12,
        RAGSTUN_GlideBoostTackle = 13,
        RAGSTUN_ControllableBatarang = 14,
        RAGSTUN_GelMine = 15,
        RAGSTUN_RECArmouredBlast = 16,
        RAGSTUN_RicochetStick = 17,
        RAGSTUN_ElectroBlast = 18,
        RAGSTUN_WristDart = 19,
        RAGSTUN_ShieldBash = 20,
        RAGSTUN_ShieldBlockAndBash = 21,
        RAGSTUN_ZipKick = 22,
        RAGSTUN_StickyBomb = 23,
        RAGSTUN_RasFade = 24,
        RAGSTUN_WhipTrip = 25,
        RAGSTUN_FreezeLadder = 26,
        RAGSTUN_IceThugPush = 27,
        RAGSTUN_DKProxMine = 28,
        RAGSTUN_MAX = 29,
    }

    /// <summary>
    /// Enum: EGameAction_PredatorChallenge
    /// </summary>
    public enum EGameAction_PredatorChallenge : byte
    {
        GA_PredatorChallenge_None = 0,
        GA_PredatorChallenge_WallKill = 1,
        GA_PredatorChallenge_BatarangThenTakedown = 2,
        GA_PredatorChallenge_GlideKickThenTakedown = 3,
        GA_PredatorChallenge_1Wall3Kills = 4,
        GA_PredatorChallenge_2Walls2Kills = 5,
        GA_PredatorChallenge_3Walls3Kills = 6,
        GA_PredatorChallenge_LineLaunchKickThroughWindow = 7,
        GA_PredatorChallenge_BatclawOverLedge = 8,
        GA_PredatorChallenge_Batclaw3OverLedge = 9,
        GA_PredatorChallenge_LineLaunch2People = 10,
        GA_PredatorChallenge_LineLaunch3People = 11,
        GA_PredatorChallenge_Hit3WithSteerableBatarang = 12,
        GA_PredatorChallenge_SonicBatarangKill = 13,
        GA_PredatorChallenge_3BatarangHit = 14,
        GA_PredatorChallenge_LineLauncherKill = 15,
        GA_PredatorChallenge_GrateThenGrab = 16,
        GA_PredatorChallenge_PullOutFloorFrom1 = 17,
        GA_PredatorChallenge_PullOutFloorFrom2 = 18,
        GA_PredatorChallenge_PullOutFloorFrom3 = 19,
        GA_PredatorChallenge_SilentTakedown = 20,
        GA_PredatorChallenge_LedgeTakedown = 21,
        GA_PredatorChallenge_CornerTakedown = 22,
        GA_PredatorChallenge_GlassTakedown = 23,
        GA_PredatorChallenge_HangingTakedown = 24,
        GA_PredatorChallenge_DropTakedown = 25,
        GA_PredatorChallenge_PunchArmedThug = 26,
        GA_PredatorChallenge_UltraBatclawWallKill = 27,
        GA_PredatorChallenge_ScareThug = 28,
        GA_PredatorChallenge_GooStun = 29,
        GA_PredatorChallenge_ZiplineTakedown = 30,
        GA_PredatorChallenge_TightRopeTakedown = 31,
        GA_PredatorChallenge_RemoteRopeTakedown = 32,
        GA_PredatorChallenge_ExplosivePullRopeTakedown = 33,
        GA_PredatorChallenge_TakedownVIPFirst = 34,
        GA_PredatorChallenge_Punch3DifferentThugs = 35,
        GA_PredatorChallenge_NoDamage = 36,
        GA_PredatorChallenge_TakedownVIPLast = 37,
        GA_PredatorChallenge_UpLadderOntoGel = 38,
        GA_PredatorChallenge_HangingTakeDownThroughGlass = 39,
        GA_PredatorChallenge_QuickSilentTakedown = 40,
        GA_PredatorChallenge_ReverseChokeTakedown = 41,
        GA_PredatorChallenge_FromAboveTakedown = 42,
        GA_PredatorChallenge_DoubleLedgeTakedown = 43,
        GA_PredatorChallenge_DoubleHeadTakedown = 44,
        GA_PredatorChallenge_DoubleVantagePointTakedown = 45,
        GA_PredatorChallenge_LineLauncherTakedown = 46,
        GA_PredatorChallenge_SwingKickThenTakedown = 47,
        GA_PredatorChallenge_FractureWallTakedown = 48,
        GA_PredatorChallenge_InvertedCeilingTakedown = 49,
        GA_PredatorChallenge_PounceKOThenTakedown = 50,
        GA_PredatorChallenge_CaltropKOThenTakedown = 51,
        GA_PredatorChallenge_PullFromCatwalkTakedown = 52,
        GA_PredatorChallenge_BoomerangBatarangTakedown = 53,
        GA_PredatorChallenge_GelCrateThenTakedown = 54,
        GA_PredatorChallenge_BatclawDisarmThenKO = 55,
        GA_PredatorChallenge_BatclawThroughWindow = 56,
        GA_PredatorChallenge_LineLaunchKick = 57,
        GA_PredatorChallenge_DropAttackFromTightRope = 58,
        GA_PredatorChallenge_DoubleLineLaunchKick = 59,
        GA_PredatorChallenge_RECScareThugs = 60,
        GA_PredatorChallenge_RECArmouredBowlingBall = 61,
        GA_PredatorChallenge_SmokeBombTakedown = 62,
        GA_PredatorChallenge_BeatDownTakedown = 63,
        GA_PredatorChallenge_SlideThenTakedown = 64,
        GA_PredatorChallenge_DiveBombThenTakedown = 65,
        GA_PredatorChallenge_Shockwave3Enemies = 66,
        GA_PredatorChallenge_VentTakedown = 67,
        GA_PredatorChallenge_FloorGrateTakedown = 68,
        GA_PredatorChallenge_Combo3 = 69,
        GA_PredatorChallenge_Combo8 = 70,
        GA_PredatorChallenge_BatarangBoostArmouredThug = 71,
        GA_PredatorChallenge_BatarangBoostKO = 72,
        GA_PredatorChallenge_HangTakedownOnJammer = 73,
        GA_PredatorChallenge_MineDetonateOnMineLayer = 74,
        GA_PredatorChallenge_CombatFloorKO = 75,
        GA_PredatorChallenge_FloorGrab = 76,
        GA_PredatorChallenge_PunchKO = 77,
        GA_PredatorChallenge_EscrimaStick1 = 78,
        GA_PredatorChallenge_EscrimaStick2 = 79,
        GA_PredatorChallenge_RemoteElectricalBlast1 = 80,
        GA_PredatorChallenge_RemoteElectricalBlast2 = 81,
        GA_PredatorChallenge_RemoteElectricalBlast3 = 82,
        GA_PredatorChallenge_WristDart1 = 83,
        GA_PredatorChallenge_WristDart2 = 84,
        GA_PredatorChallenge_WristDart3 = 85,
        GA_PredatorChallenge_BulletShield1 = 86,
        GA_PredatorChallenge_BulletShield2 = 87,
        GA_PredatorChallenge_BulletShield3 = 88,
        GA_PredatorChallenge_ZipKick1 = 89,
        GA_PredatorChallenge_ZipKick2 = 90,
        GA_PredatorChallenge_ZipKick3 = 91,
        GA_PredatorChallenge_StickyBomb1 = 92,
        GA_PredatorChallenge_StickyBomb2 = 93,
        GA_PredatorChallenge_StickyBomb3 = 94,
        GA_PredatorChallenge_WhipDisarm = 95,
        GA_PredatorChallenge_CwBeatDownTakedown = 96,
        GA_PredatorChallenge_PullSniperFromCatwalkTakedown = 97,
        GA_PredatorChallenge_WeaponJam = 98,
        GA_PredatorChallenge_SonicBatarangTakedown = 99,
        GA_PredatorChallenge_RECOverLedge = 100,
        GA_PredatorChallenge_GelCeiling = 101,
        GA_PredatorChallenge_BatarangDistract = 102,
        GA_PredatorChallenge_FireExtinguisherTakedown = 103,
        GA_PredatorChallenge_WindowTakedown = 104,
        GA_PredatorChallenge_BatarangThenTakedownCW = 105,
        GA_PredatorChallenge_BatarangThenTakedownRB = 106,
        GA_PredatorChallenge_BatarangThenTakedownNW = 107,
        GA_PredatorChallenge_BatarangDistractCW = 108,
        GA_PredatorChallenge_BatarangDistractRB = 109,
        GA_PredatorChallenge_BatarangDistractNW = 110,
        GA_PredatorChallenge_FireExtinguisherTakedownCW = 111,
        GA_PredatorChallenge_FireExtinguisherTakedownRB = 112,
        GA_PredatorChallenge_FireExtinguisherTakedownNW = 113,
        GA_PredatorChallenge_BatarangBoostKORB = 114,
        GA_PredatorChallenge_WhipTripThenTakedown = 115,
        GA_PredatorChallenge_FallingTakedown = 116,
        GA_PredatorChallenge_WristDartOverLedge = 117,
        GA_PredatorChallenge_StickyBombOverLedge = 118,
        GA_PredatorChallenge_CornerTakedownKO = 119,
        GA_PredatorChallenge_MineExplosionKO = 120,
        GA_PredatorChallenge_TakedownProjectileKO = 121,
        GA_PredatorChallenge_GlueTakedown = 122,
        GA_PredatorChallenge_GlueClusterDoubleTakedown = 123,
        GA_PredatorChallenge_GlueSmashTakedown = 124,
        GA_PredatorChallenge_EnterRoom = 125,
        GA_PredatorChallenge_FireExtinguisherFromDualClawTakedown = 126,
        GA_PredatorChallenge_DKProxMineThenTakedown = 127,
        GA_PredatorChallenge_FlashPowderThenTakedown = 128,
        GA_PredatorChallenge_FlashPowderThenSmashTakedown = 129,
        GA_PredatorChallenge_CaltropsTwoThugs = 130,
        GA_PredatorChallenge_CaltropsThreeThugs = 131,
        GA_PredatorChallenge_Max = 132,
    }

    /// <summary>
    /// Enum: EGameAction_CombatTraining
    /// </summary>
    public enum EGameAction_CombatTraining : byte
    {
        GameAction_CombatTraining_NONE = 0,
        GameAction_CombatTraining_FFC_STRIKE = 1,
        GameAction_CombatTraining_FFC_BATARANG = 2,
        GameAction_CombatTraining_FFC_BATCLAW = 3,
        GameAction_CombatTraining_FFC_TEST = 4,
        GameAction_CombatTraining_MAX = 5,
    }

    /// <summary>
    /// Enum: EGameAction
    /// </summary>
    public enum EGameAction : byte
    {
        GA_None = 0,
        GA_Takedown_CombatTakedown = 1,
        GA_Takedown_CombatRedirect = 2,
        GA_Takedown_CombatRailing = 3,
        GA_Takedown_CombatStrike = 4,
        GA_Takedown_CombatWall = 5,
        GA_Takedown_CombatShocked = 6,
        GA_Takedown_Fallen = 7,
        GA_Takedown_GrabStanding = 8,
        GA_Takedown_GrabFloor = 9,
        GA_Takedown_GrabGrate = 10,
        GA_Takedown_GrabCorner = 11,
        GA_Takedown_HangAttack = 12,
        GA_Takedown_GlideKick = 13,
        GA_Takedown_GlassAttack = 14,
        GA_Takedown_VentAttack = 15,
        GA_Takedown_SilentCombatTakedown = 16,
        GA_Takedown_FallingTakedown = 17,
        GA_Takedown_Terrified = 18,
        GA_Takedown_LedgeAttack = 19,
        GA_KO = 20,
        GA_KO_Knife = 21,
        GA_KO_Pipe = 22,
        GA_KO_StunStick = 23,
        GA_KO_Shield = 24,
        GA_KO_Armoured = 25,
        GA_KO_Ninja = 26,
        GA_KO_CombatGun = 27,
        GA_KO_PredatorGun = 28,
        GA_KO_Sniper = 29,
        GA_KO_Lieutenant = 30,
        GA_KO_ArmouredLieutenant = 31,
        GA_KO_VenomThug = 32,
        GA_KO_MartialArtist = 33,
        GA_KO_InSmoke = 34,
        GA_KO_Lunatic = 35,
        GA_Rescue = 36,
        GA_EvidenceTrailOver = 37,
        GA_Pickup = 38,
        GA_Pickup_Map = 39,
        GA_Pickup_Tape = 40,
        GA_Cipher_Found = 41,
        GA_Riddle_Solved = 42,
        GA_DestroyTeeth = 43,
        GA_VenomHenchmanDefeated = 44,
        GA_SP_InitialDiscovery = 45,
        GA_BossGrundyPhaseOver = 46,
        GA_BossGrundyPhaseOver_Hard = 47,
        GA_BossJokerPhaseOver = 48,
        GA_BossClayfacePhaseOver = 49,
        GA_DropOnThug = 50,
        GA_ScareThug = 51,
        GA_SP_FurtherDiscovery = 52,
        GA_Stun_Batarang = 53,
        GA_Combo_XP_Multiplier = 54,
        GA_SuperCombo_Enter = 55,
        GA_SuperCombo_Exit = 56,
        GA_Combo_Enter = 57,
        GA_Combo_Exit = 58,
        GA_Combat_Started = 59,
        GA_Combat_Finished = 60,
        GA_Combat_Finished_Success = 61,
        GA_Combat_Finished_Fail = 62,
        GA_Combat_QuickStrike = 63,
        GA_Combat_HeavyStrike = 64,
        GA_Combat_ComboStrike = 65,
        GA_Combat_Counter = 66,
        GA_Combat_Redirect = 67,
        GA_Combat_Evade = 68,
        GA_Combat_Stun = 69,
        GA_Combat_BeatdownStrike = 70,
        GA_Combat_EnemyStunned = 71,
        GA_Combat_RemoveArmor = 72,
        GA_Combat_RemoveArmor_Instant = 73,
        GA_Combat_RemoveVenomPack_Instant = 74,
        GA_Combat_Counter_MartialArtistChainedAttack = 75,
        GA_Combat_Counter_MartialArtistComboChainedAttack = 76,
        GA_Combat_Strike_FinalBlow = 77,
        GA_Combat_Counter_KnifeTakedown = 78,
        GA_Grab_Henchman = 79,
        GA_Gadget_Grapple = 80,
        GA_Gadget_Grapple_Rescue = 81,
        GA_Gadget_Grapple_AnyTime = 82,
        GA_Gadget_Grapple_Failed = 83,
        GA_Gadget_Batarang180Flip = 84,
        GA_Gadget_Batarang = 85,
        GA_Gadget_SonicBatarang = 86,
        GA_Gadget_ExplosiveGel = 87,
        GA_Gadget_BatClaw = 88,
        GA_Gadget_Resonator = 89,
        GA_Gadget_BroadcastAnalyser = 90,
        GA_Gadget_ControllableBatarang = 91,
        GA_Gadget_RoundTheBackarang = 92,
        GA_Gadget_MagneticBlast = 93,
        GA_Gadget_MagneticBlastRepel = 94,
        GA_Gadget_FreezeSpray = 95,
        GA_Gadget_SmokeBomb = 96,
        GA_Gadget_JammerGadget = 97,
        GA_Gadget_LineLauncherTightRope = 98,
        GA_Gadget_LineLauncher_IfNotFired = 99,
        GA_Gadget_BatarangBrake = 100,
        GA_Gadget_ShockGloves = 101,
        GA_Gadget_GlueGrenade = 102,
        GA_Gadget_StunGrenade = 103,
        GA_Gadget_WeaponDisruptor = 104,
        GA_Gadget_RemoteClaw = 105,
        GA_Gadget_LineLauncher = 106,
        GA_SmokeScreen_Start = 107,
        GA_SmokeScreen_Finish = 108,
        GA_Gadget_CombatBatClaw = 109,
        GA_Gadget_CombatBatarang = 110,
        GA_Gadget_Detonator = 111,
        GA_Gadget_Bullwhip = 112,
        GA_Gadget_CombatBullwhip = 113,
        GA_Gadget_BullwhipCombatDisarm = 114,
        GA_Gadget_Staff = 115,
        GA_Gadget_ShieldBash = 116,
        GA_Gadget_SticksAreaStun = 117,
        GA_Gadget_SticksRicochet = 118,
        GA_Gadget_WristDart = 119,
        GA_Gadget_StickyBomb = 120,
        GA_Gadget_ZipKick = 121,
        GA_Gadget_QuickBatarang = 122,
        GA_Gadget_QuickGel = 123,
        GA_Gadget_QuickDetonate = 124,
        GA_Gadget_QuickClaw = 125,
        GA_Gadget_QuickFreeze = 126,
        GA_Gadget_QuickMagBlast = 127,
        GA_Gadget_QuickGlueGrenade = 128,
        GA_Gadget_QuickStunGrenade = 129,
        GA_Gadget_QuickShockGloves = 130,
        GA_Gadget_DetonateGel = 131,
        GA_Gadget_QuickBullwhip = 132,
        GA_Gadget_DoubleLineLauncher_Tutorial = 133,
        GA_Gadget_JokerCards = 134,
        GA_Gadget_JokerGlasses = 135,
        GA_Gadget_JokerChatteringTeeth = 136,
        GA_Gadget_JokerGun = 137,
        GA_Gadget_JokerFlower = 138,
        GA_Gadget_JokerBuzzer = 139,
        GA_EnygmaScreen_Tutorial = 140,
        GA_SilentPredatorCamera = 141,
        GA_InvestigateMode = 142,
        GA_MapOpened = 143,
        GA_Zoom = 144,
        GA_UnZoom = 145,
        GA_Agility_Climb = 146,
        GA_Agility_ClimbDown = 147,
        GA_Agility_Shimmy = 148,
        GA_Agility_DiveThroughWindow = 149,
        GA_Agility_WalkOnRailing = 150,
        GA_Agility_Swing = 151,
        GA_Agility_Slide = 152,
        GA_Agility_Jump = 153,
        GA_Agility_CwSwingToCeiling = 154,
        GA_Agility_CwJumpToCeiling = 155,
        GA_Agility_CwUsedCeilingGrate = 156,
        GA_InvisiblePredator_Crouch = 157,
        GA_InvisiblePredator_CornerCover = 158,
        GA_InvisiblePredator_TunnelGrate = 159,
        GA_InvisiblePredator_HangMode = 160,
        GA_InvisiblePredator_JumpFromVantagePoint = 161,
        GA_InvisiblePredator_SwingToVantagePoint = 162,
        GA_InvisiblePredator_InstantSmokeBomb = 163,
        GA_TakedownBeginTakedown = 164,
        GA_Died = 165,
        GA_Combat_CounterStart = 166,
        GA_AzraelGlyphScanned = 167,
        GA_InterrogatedThug = 168,
        GA_ScannedInterrogateThug = 169,
        GA_TitanRideStarted = 170,
        GA_SuperStun = 171,
        GA_StruckStunStickThug = 172,
        GA_LieutenantHitWithREC = 173,
        GA_Batman_Hit = 174,
        GA_Batman_Grabbed = 175,
        GA_ChallengeMedalGained = 176,
        GA_CaseFileSolved = 177,
        GA_Anarky_Image_Scanned = 178,
        GA_Gadget_FlashPowder = 179,
        GA_Gadget_ShurikenVolley = 180,
        GA_Pinkney_Solved = 181,
        GA_Gadget_GlueRaftCreated = 182,
        GA_Combat_Critical = 183,
        GA_Gadget_ShadowStrike = 184,
        GA_TakedownBeginFatalTakedown = 185,
        GA_KOFloorTakedownBatarang = 186,
        GA_Max = 187,
    }

    /// <summary>
    /// Enum: ELive_LiveError
    /// </summary>
    public enum ELive_LiveError : byte
    {
        EL_None = 0,
        EL_LoginLost = 1,
        EL_LoginChanged = 2,
        EL_NotConnected = 3,
        EL_Connected = 4,
        EL_ConnectionDropped = 5,
        EL_NoNetworkConnection = 6,
        EL_ServiceUnavailable = 7,
        EL_UpdateRequired = 8,
        EL_ServersTooBusy = 9,
        EL_DuplicateLoginDetected = 10,
        EL_InvalidUser = 11,
        EL_PS3NotConnected = 12,
        EL_PS3NotLoggedIn = 13,
        EL_DLCInvalidated = 14,
        EL_DLCNewContent = 15,
        EL_MAX = 16,
    }

    /// <summary>
    /// Enum: EGS_Reason
    /// </summary>
    public enum EGS_Reason : byte
    {
        EGS_None = 0,
        EGS_StoryExit = 1,
        EGS_StoryComplete = 2,
        EGS_Challenge_Lost = 3,
        EGS_Challenge_Won = 4,
        EGS_MAX = 5,
    }

    /// <summary>
    /// Enum: EGameModes
    /// </summary>
    public enum EGameModes : byte
    {
        EGM_Frontend = 0,
        EGM_Story = 1,
        EGM_Challenge = 2,
        EGM_MAX = 3,
    }

    /// <summary>
    /// Enum: ERichPresenceContext
    /// </summary>
    public enum ERichPresenceContext : byte
    {
        ERPC_KILLERCROC = 0,
        ERPC_DEATHSTROKE = 1,
        ERPC_COPPERHEAD = 2,
        ERPC_BANE = 3,
        ERPC_FINALBANE = 4,
        ERPC_FIREFLY = 5,
        ERPC_JOKER = 6,
        ERPC_OPENWORLD = 7,
        ERPC_BATCAVE = 8,
        ERPC_MOSTWANTED = 9,
        ERPC_STORYMODE = 10,
        ERPC_NONE = 11,
        ERPC_MAX = 12,
    }

    /// <summary>
    /// Enum: ERichPresenceContext_FE
    /// </summary>
    public enum ERichPresenceContext_FE : byte
    {
        ERPCFE_FE = 0,
        ERPCFE_TROPHY = 1,
        ERPCFE_CREDITS = 2,
        ERPCFE_WAYNETECH = 3,
        ERPCFE_MAX = 4,
    }

    /// <summary>
    /// Enum: ELeaderboardColumns
    /// </summary>
    public enum ELeaderboardColumns : byte
    {
        ELBC_Medal = 0,
        ELBC_Score = 1,
        ELBC_RatingScore = 2,
        ELBC_MAX = 3,
    }

    /// <summary>
    /// Enum: EThugBarkType
    /// </summary>
    public enum EThugBarkType : byte
    {
        ETBT_Thug1 = 0,
        ETBT_Thug2 = 1,
        ETBT_Thug3 = 2,
        ETBT_Thug4 = 3,
        ETBT_Thug5 = 4,
        ETBT_Thug6 = 5,
        ETBT_ThugRandom = 6,
        ETBT_NoBark = 7,
        ETBT_MAX = 8,
    }

    /// <summary>
    /// Enum: EPredGadgetBonusType
    /// </summary>
    public enum EPredGadgetBonusType : byte
    {
        PGBT_SonicShockBatarang = 0,
        PGBT_ExplosiveGel = 1,
        PGBT_DualClaw = 2,
        PGBT_Environment = 3,
        PGBT_MAX = 4,
    }

    /// <summary>
    /// Enum: EPredTakedownType
    /// </summary>
    public enum EPredTakedownType : byte
    {
        PTT_SilentTakedown = 0,
        PTT_DoubleTakedown = 1,
        PTT_QuickTakedown = 2,
        PTT_InvertedTakedown = 3,
        PTT_LedgeTakedown = 4,
        PTT_DoubleLedgeTakedown = 5,
        PTT_ReverseLedgeTakedown = 6,
        PTT_FloorGrateTakedown = 7,
        PTT_VentTakedown = 8,
        PTT_GrappleBoostTakedown = 9,
        PTT_WallTakedown = 10,
        PTT_ZipKickTakedown = 11,
        PTT_FloorTakedown = 12,
        PTT_RemoteClawTakedown = 13,
        PTT_RemoteRopeTakedown = 14,
        PTT_ZipLineTakedown = 15,
        PTT_TightRopeTakedown = 16,
        PTT_SonicShockTakedown = 17,
        PTT_GlueSmashTakedown = 18,
        PTT_CornerTakedown = 19,
        PTT_ExplosiveGelTakedown = 20,
        PTT_MAX = 21,
    }

    /// <summary>
    /// Enum: FreeFlowCombatModifierType
    /// </summary>
    public enum FreeFlowCombatModifierType : byte
    {
        FFCMT_None = 0,
        FFCMT_Bat = 1,
        FFCMT_StuddedBat = 2,
        FFCMT_Pipe = 3,
        FFCMT_Shield = 4,
        FFCMT_StunStick = 5,
        FFCMT_Knife = 6,
        FFCMT_Machete = 7,
        FFCMT_Bottle = 8,
        FFCMT_NinjaSword = 9,
        FFCMT_Rifle = 10,
        FFCMT_RifleExtreme = 11,
        FFCMT_Baton = 12,
        FFCMT_MiniSledgeHammer = 13,
        FFCMT_SledgeHammer = 14,
        FFCMT_Sickle = 15,
        FFCMT_Crate = 16,
        FFCMT_Explosive = 17,
        FFCMT_Stool = 18,
        FFCMT_Vase = 19,
        FFCMT_VikingHead = 20,
        FFCMT_FireExtinguisher = 21,
        FFCMT_CryoCannister = 22,
        FFCMT_MAX = 23,
    }

    /// <summary>
    /// Enum: MasterMap_StrArch
    /// </summary>
    public enum MasterMap_StrArch : byte
    {
        STRARCH_NONE = 0,
        STRARCH_NEWGOTHAM = 1,
        STRARCH_OLDGOTHAM = 2,
        STRARCH_GOTHAMBRIDGE = 3,
        STRARCH_REGENT = 4,
        STRARCH_CARGO = 5,
        STRARCH_SLEAZY = 6,
        STRARCH_STEELMILL = 7,
        STRARCH_CHEMLAB = 8,
        STRARCH_POLICESTATION = 9,
        STRARCH_PRISON = 10,
        STRARCH_BANK = 11,
        STRARCH_JOKERDREAM = 12,
        STRARCH_BANEHQ = 13,
        STRARCH_CHURCH = 14,
        STRARCH_TOWER = 15,
        STRARCH_BANE = 16,
        STRARCH_BANE_A = 17,
        STRARCH_BANE_B = 18,
        STRARCH_BANE_C = 19,
        STRARCH_BLACKMASK = 20,
        STRARCH_BLACKMASK_A = 21,
        STRARCH_BLACKMASK_B = 22,
        STRARCH_BLACKMASK_C = 23,
        STRARCH_BLACKMASK_D = 24,
        STRARCH_GCPD = 25,
        STRARCH_GCPD_A = 26,
        STRARCH_GCPD_B = 27,
        STRARCH_GOTHAM = 28,
        STRARCH_GOTHAM_A = 29,
        STRARCH_GOTHAM_B = 30,
        STRARCH_GOTHAM_C = 31,
        STRARCH_GOTHAM_D = 32,
        STRARCH_GOTHAM_E = 33,
        STRARCH_HOBO = 34,
        STRARCH_JOKER = 35,
        STRARCH_JOKER_A = 36,
        STRARCH_JOKER_B = 37,
        STRARCH_JOKER_C = 38,
        STRARCH_PENGUIN = 39,
        STRARCH_PENGUIN_A = 40,
        STRARCH_PENGUIN_B = 41,
        STRARCH_PENGUIN_C = 42,
        STRARCH_PENGUIN_D = 43,
        STRARCH_PENGUIN_E = 44,
        STRARCH_PENGUIN_F = 45,
        STRARCH_PRISONNER = 46,
        STRARCH_PRISONNER_A = 47,
        STRARCH_PRISONNER_B = 48,
        STRARCH_PRISONNER_C = 49,
        STRARCH_PRISONNER_D = 50,
        STRARCH_PRISONNER_E = 51,
        STRARCH_BLACKGATECOP = 52,
        STRARCH_BLACKGATECOP_A = 53,
        STRARCH_ANARCHY = 54,
        STRARCH_ANARCHY_A = 55,
        STRARCH_FALCONE = 56,
        STRARCH_PRISONNER_JOKER = 57,
        STRARCH_NINJA = 58,
        STRARCH_MAX = 59,
    }

    /// <summary>
    /// Enum: OverrideRandom
    /// </summary>
    public enum OverrideRandom : byte
    {
        RANDOM_NONE = 0,
        RANDOM_ON = 1,
        RANDOM_OFF = 2,
        RANDOM_MAX = 3,
    }

    /// <summary>
    /// Enum: StreamedCombatWeaponTypes
    /// </summary>
    public enum StreamedCombatWeaponTypes : byte
    {
        COMBATWEAPON_None = 0,
        COMBATWEAPON_Rifle = 1,
        COMBATWEAPON_Knife = 2,
        COMBATWEAPON_Machette = 3,
        COMBATWEAPON_Bottle = 4,
        COMBATWEAPON_Pipe = 5,
        COMBATWEAPON_CrowdPipe = 6,
        COMBATWEAPON_Bat = 7,
        COMBATWEAPON_Shield = 8,
        COMBATWEAPON_ShieldRiot = 9,
        COMBATWEAPON_TygerShieldRiot = 10,
        COMBATWEAPON_RiotBaton = 11,
        COMBATWEAPON_Baton = 12,
        COMBATWEAPON_StunStick = 13,
        COMBATWEAPON_AnarkyStunStick = 14,
        COMBATWEAPON_BlowTorch = 15,
        COMBATWEAPON_Hammer = 16,
        COMBATWEAPON_MiniHammer = 17,
        COMBATWEAPON_Sniper = 18,
        COMBATWEAPON_NinjaSword = 19,
        COMBATWEAPON_HeavyCrate = 20,
        COMBATWEAPON_ShieldBamboo = 21,
        COMBATWEAPON_Sai = 22,
        COMBATWEAPON_MAX = 23,
    }

    /// <summary>
    /// Enum: StreamedPredWeaponTypes
    /// </summary>
    public enum StreamedPredWeaponTypes : byte
    {
        PREDWEAPON_None = 0,
        PREDWEAPON_Rifle = 1,
        PREDWEAPON_RifleLite = 2,
        PREDWEAPON_Shotgun = 3,
        PREDWEAPON_Sniper = 4,
        PREDWEAPON_MAX = 5,
    }

    /// <summary>
    /// Enum: VocalPriority
    /// </summary>
    public enum VocalPriority : byte
    {
        EVP_Default = 0,
        EVP_Low = 1,
        EVP_Medium = 2,
        EVP_High = 3,
        EVP_Highest = 4,
        EVP_DuckAllOther = 5,
        EVP_MAX = 6,
    }

    /// <summary>
    /// Enum: VocalType
    /// </summary>
    public enum VocalType : byte
    {
        EVT_Emote = 0,
        EVT_Bark = 1,
        EVT_Speech = 2,
        EVT_MAX = 3,
    }

    /// <summary>
    /// Struct: FInterrogationData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FInterrogationData
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: InterrogationIndex
        /// </summary>
        public unsafe byte InterrogationIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: NumInterrogations
        /// </summary>
        public unsafe byte NumInterrogations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 13); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13); }; }
        }

        /// <summary>
        /// BoolProperty: bRepeatForever
        /// </summary>
        public unsafe bool bRepeatForever
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FBatwingLevelTransitionInfoDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FBatwingLevelTransitionInfoDefinition
    {
        /// <summary>
        /// StrProperty: TransitionName
        /// </summary>
        public unsafe BmSDK.FString TransitionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: PersistentLevelNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> PersistentLevelNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: LevelTransitionId
        /// </summary>
        public unsafe int LevelTransitionId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StrProperty: BeaconName
        /// </summary>
        public unsafe BmSDK.FString BeaconName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ArrayProperty: BeaconPosition
        /// </summary>
        public unsafe BmSDK.TArray<int> BeaconPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FLevelStartDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FLevelStartDefinition
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: LevelNames
        /// </summary>
        public unsafe BmSDK.FString LevelNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: ItemOwnerID
        /// </summary>
        public unsafe int ItemOwnerID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: ItemTargetID
        /// </summary>
        public unsafe int ItemTargetID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bExecutiveMenu
        /// </summary>
        public unsafe bool bExecutiveMenu
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: CopyOfOptions
    /// </summary>
    public unsafe BmSDK.TArray<byte> CopyOfOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// BoolProperty: ExecutiveMenuOnly
    /// </summary>
    public unsafe bool ExecutiveMenuOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bHead2Head
    /// </summary>
    public unsafe bool bHead2Head
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bStoryDLC
    /// </summary>
    public unsafe bool bStoryDLC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bSavingStartPoints
    /// </summary>
    public unsafe bool bSavingStartPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bDemoBuild
    /// </summary>
    public unsafe bool bDemoBuild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bShowChaseStartPos
    /// </summary>
    public unsafe bool bShowChaseStartPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bM8VantageVisibilityHack
    /// </summary>
    public unsafe bool bM8VantageVisibilityHack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bOneHitKill
    /// </summary>
    public unsafe bool bOneHitKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bNoGadgets
    /// </summary>
    public unsafe bool bNoGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bSilentTakeDownOnly
    /// </summary>
    public unsafe bool bSilentTakeDownOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bNoGrapple
    /// </summary>
    public unsafe bool bNoGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bNoInvestigateMode
    /// </summary>
    public unsafe bool bNoInvestigateMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bUseLowLineLauncherHeight
    /// </summary>
    public unsafe bool bUseLowLineLauncherHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: LevelLoadedAndReady
    /// </summary>
    public unsafe bool LevelLoadedAndReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bSuspendAllDeadGameOver
    /// </summary>
    public unsafe bool bSuspendAllDeadGameOver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bDoCombatGrapnelToVpointArriveCheck
    /// </summary>
    public unsafe bool bDoCombatGrapnelToVpointArriveCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: EnableBigHeadMode
    /// </summary>
    public unsafe bool EnableBigHeadMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bSplitscreenCaptureMode
    /// </summary>
    public unsafe bool bSplitscreenCaptureMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bPreventPauseOnControllerRemoval
    /// </summary>
    public unsafe bool bPreventPauseOnControllerRemoval
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: SavedOWDTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedOWDTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: SavedMuseumTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedMuseumTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: SavedUnderTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedUnderTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// ArrayProperty: DebugLevelStarts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelStartDefinition> DebugLevelStarts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelStartDefinition>>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: BatwingLevelTransitionInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FBatwingLevelTransitionInfoDefinition> BatwingLevelTransitionInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FBatwingLevelTransitionInfoDefinition>>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ObjectProperty: BatwingTransitionHandler
    /// </summary>
    public unsafe BmSDK.BmGame.MBatwingTransitionHandler BatwingTransitionHandler
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MBatwingTransitionHandler>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// StrProperty: PreviousMapName
    /// </summary>
    public unsafe BmSDK.FString PreviousMapName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: InterrogationInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FInterrogationData> InterrogationInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FInterrogationData>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ArrayProperty: AllThugScarableCrows
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCrowsBase> AllThugScarableCrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCrowsBase>>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// IntProperty: CrowTimeSliceIndex
    /// </summary>
    public unsafe int CrowTimeSliceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ByteProperty: ERPC_FE
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.ERichPresenceContext_FE ERPC_FE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ERichPresenceContext_FE>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ByteProperty: ERPC_GamePlay
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.ERichPresenceContext ERPC_GamePlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ERichPresenceContext>(Ptr + 1001); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1001); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: FloorTakedownChallengeAction
    /// </summary>
    public InlineArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge> FloorTakedownChallengeAction => new(29, Ptr + 1002, 1, this);

    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1002); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1002); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1003); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1003); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1005); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1005); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1006); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1006); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1007); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1007); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1009); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1009); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1010); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1010); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1011); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1011); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1013); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1013); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1014); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1014); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1015); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1015); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1017); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1017); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1018); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1018); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1019); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1019); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1021); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1021); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1022); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1022); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1023); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1023); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1025); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1025); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1026); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1026); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1027); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1027); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1029); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1029); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge FloorTakedownChallengeAction_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1030); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1030); }
    }

    /// <summary>
    /// ByteProperty: GameMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameModes GameMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameModes>(Ptr + 1031); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1031); }
    }

    /// <summary>
    /// ByteProperty: ChallengeMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeMode ChallengeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeMode>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ByteProperty: ChallengeCharacter
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeCharacter ChallengeCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeCharacter>(Ptr + 1033); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1033); }
    }

    /// <summary>
    /// ByteProperty: StasisLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStasisLevel StasisLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStasisLevel>(Ptr + 1034); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1034); }
    }

    /// <summary>
    /// ByteProperty: ReplayId
    /// </summary>
    public unsafe byte ReplayId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1035); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1035); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Main
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Main
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Dup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Dup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ArrayProperty: GAPred_DuplicateList_Main
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge> GAPred_DuplicateList_Main
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// ArrayProperty: GAPred_DuplicateList_Dup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge> GAPred_DuplicateList_Dup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: CrowdManager
    /// </summary>
    public unsafe BmSDK.BmGame.RCrowdManager CrowdManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCrowdManager>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: DialogueManager
    /// </summary>
    public unsafe BmSDK.BmGame.RDialogueManager DialogueManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDialogueManager>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: MExperienceSystem
    /// </summary>
    public unsafe BmSDK.BmGame.MExperienceSystem MExperienceSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MExperienceSystem>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: mMostWantedManager
    /// </summary>
    public unsafe BmSDK.BmGame.MMostWantedSystem mMostWantedManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MMostWantedSystem>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: DynamicEventsManager
    /// </summary>
    public unsafe BmSDK.BmGame.MDynamicEventsManager DynamicEventsManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDynamicEventsManager>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: mWayneTechUpgrade
    /// </summary>
    public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem mWayneTechUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ObjectProperty: mCrimeSceneInvestigation
    /// </summary>
    public unsafe BmSDK.BmGame.MCrimeSceneInvestigationSystem mCrimeSceneInvestigation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MCrimeSceneInvestigationSystem>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ObjectProperty: mCriminalActivityAnalysis
    /// </summary>
    public unsafe BmSDK.BmGame.MCriminalActivityAnalysisSystem mCriminalActivityAnalysis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MCriminalActivityAnalysisSystem>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ObjectProperty: MDatabaseProgressionManager
    /// </summary>
    public unsafe BmSDK.BmGame.MDatabaseProgressionManager MDatabaseProgressionManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDatabaseProgressionManager>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ComponentProperty: CurrentRoomAIState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState CurrentRoomAIState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ObjectProperty: CombatDialogueCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RBMDialogueCoordinator CombatDialogueCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMDialogueCoordinator>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ObjectProperty: CachedPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController CachedPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: SessionTimePlayed
    /// </summary>
    public unsafe float SessionTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: InteractableItemTestDist
    /// </summary>
    public unsafe float InteractableItemTestDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// FloatProperty: FootstepNoiseDist
    /// </summary>
    public unsafe float FootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: WalkFootstepNoiseDist
    /// </summary>
    public unsafe float WalkFootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// FloatProperty: TakedownNoiseDist
    /// </summary>
    public unsafe float TakedownNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: ChaseCheatTime
    /// </summary>
    public unsafe float ChaseCheatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: RBSmashSpeedAlertThreshold
    /// </summary>
    public unsafe float RBSmashSpeedAlertThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: BingBongTimer
    /// </summary>
    public unsafe float BingBongTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// FloatProperty: GunStartleTimer
    /// </summary>
    public unsafe float GunStartleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// StructProperty: CurrentWindState
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FRWindState CurrentWindState
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FRWindState>(Ptr + 1180);

    /// <summary>
    /// StructProperty: CurrentWindConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FRWindConfig CurrentWindConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FRWindConfig>(Ptr + 1248);

    /// <summary>
    /// FloatProperty: CurrentRainIntensity
    /// </summary>
    public unsafe float CurrentRainIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// ArrayProperty: ObjectiveMarkers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker> ObjectiveMarkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker>>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// IntProperty: VisibleObjectiveMarker
    /// </summary>
    public unsafe int VisibleObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// IntProperty: HighestPriorityNonCustomObjectiveMarker
    /// </summary>
    public unsafe int HighestPriorityNonCustomObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// ArrayProperty: ActiveSmokeScreens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSmokeScreen> ActiveSmokeScreens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSmokeScreen>>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// ArrayProperty: PredVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPredatorVolume> PredVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPredatorVolume>>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: LoadedAllTheTimeOnPCToSaveDVDSpace
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> LoadedAllTheTimeOnPCToSaveDVDSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: PredChaseTime
    /// </summary>
    public unsafe float PredChaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelTransition> LevelTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelTransition>>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// ArrayProperty: BatwingLevelTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MLevelTransitionBatwingBase> BatwingLevelTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MLevelTransitionBatwingBase>>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBatwing
    /// </summary>
    public unsafe BmSDK.BmGame.RSkeletalMeshActor CurrentBatwing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkeletalMeshActor>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunDefaultAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunDefaultAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunUpAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunUpAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ObjectProperty: ManDownPeekAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ManDownPeekAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// ObjectProperty: GuardPointAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager GuardPointAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// ObjectProperty: ReloadAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ReloadAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// ObjectProperty: TutThugAimingAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager TutThugAimingAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ObjectProperty: PerimOutAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PerimOutAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// FloatProperty: LastExclaimTime
    /// </summary>
    public unsafe float LastExclaimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// IntProperty: LastExclaimPriority
    /// </summary>
    public unsafe int LastExclaimPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// FloatProperty: CombatGrapnelToVPointStartTime
    /// </summary>
    public unsafe float CombatGrapnelToVPointStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: FramesUntilNextPawnSpawn
    /// </summary>
    public unsafe int FramesUntilNextPawnSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// ArrayProperty: ActiveHelicopters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase> ActiveHelicopters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase>>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// FloatProperty: ICStasisRange
    /// </summary>
    public unsafe float ICStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// FloatProperty: FullStasisRange
    /// </summary>
    public unsafe float FullStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// IntProperty: SkinMode
    /// </summary>
    public unsafe int SkinMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// StrProperty: SkinWhoBase
    /// </summary>
    public unsafe BmSDK.FString SkinWhoBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// StrProperty: SkinStartString
    /// </summary>
    public unsafe BmSDK.FString SkinStartString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// IntProperty: PlayFromChosenSlot
    /// </summary>
    public unsafe int PlayFromChosenSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeMapList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapItem> ChallengeMapList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapItem>>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// IntProperty: MedalBonusExperience
    /// </summary>
    public unsafe int MedalBonusExperience
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// ArrayProperty: RequiredChallengeCharacters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRequiredChallengeCharacter> RequiredChallengeCharacters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRequiredChallengeCharacter>>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// ArrayProperty: InstalledChallengePacks
    /// </summary>
    public unsafe BmSDK.TArray<int> InstalledChallengePacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeUnlockConditions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeUnlockCondition> ChallengeUnlockConditions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeUnlockCondition>>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// ArrayProperty: SubMapLocList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc> SubMapLocList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc>>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// ArrayProperty: MapElementList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements> MapElementList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements>>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// ArrayProperty: MapElementItemList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem> MapElementItemList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem>>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// IntProperty: NumAnarkyScansInWorld
    /// </summary>
    public unsafe int NumAnarkyScansInWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// IntProperty: NumPinkneySolutionsInWorld
    /// </summary>
    public unsafe int NumPinkneySolutionsInWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// ArrayProperty: StoryDLCList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem> StoryDLCList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem>>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: DebugForceGarbageTimer
    /// </summary>
    public unsafe float DebugForceGarbageTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// ArrayProperty: DLCBundlesInstalled
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DLCBundlesInstalled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// FloatProperty: CameraMovementSpeed
    /// </summary>
    public unsafe float CameraMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// IntProperty: helicopterSequenceNumber
    /// </summary>
    public unsafe int helicopterSequenceNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// StrProperty: deathMovieOverride
    /// </summary>
    public unsafe BmSDK.FString deathMovieOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// IntProperty: SavedMapIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedMapIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// IntProperty: SavedSecretIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedSecretIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// DelegateProperty: __SortByIndexDist__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByIndexDist__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// Struct: FResolutionOption
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FResolutionOption
    {
        /// <summary>
        /// IntProperty: ResX
        /// </summary>
        public unsafe int ResX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ResY
        /// </summary>
        public unsafe int ResY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
