#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionMultiplayerIdentifiers<br/>
/// (size = 520)
/// (flags = 134250642)
/// </summary>
public partial class RHudExtensionMultiplayerIdentifiers : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudExtensionMultiplayerIdentifiers", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudExtensionMultiplayerIdentifiers.
    /// </summary>
    public static RHudExtensionMultiplayerIdentifiers DefaultObject => (RHudExtensionMultiplayerIdentifiers)StaticClass().DefaultObject;

    internal RHudExtensionMultiplayerIdentifiers() { }

    /// <summary>
    /// Constructs a new RHudExtensionMultiplayerIdentifiers
    /// </summary>
    public RHudExtensionMultiplayerIdentifiers(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudExtensionMultiplayerIdentifiers Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudExtensionMultiplayerIdentifiers(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionMultiplayerIdentifiers>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionMultiplayerIdentifiers>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionMultiplayerIdentifiers>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionMultiplayerIdentifiers>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionMultiplayerIdentifiers>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionMultiplayerIdentifiers>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionMultiplayerIdentifiers>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionMultiplayerIdentifiers>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ToggleLockOn;
    /// <summary>
    /// Function: ToggleLockOn
    /// </summary>
    public unsafe virtual void ToggleLockOn(bool bLockOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleLockOn, "BmGame.RHudExtensionMultiplayerIdentifiers.ToggleLockOn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLockOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAllCPIndicators;
    /// <summary>
    /// Function: RemoveAllCPIndicators
    /// </summary>
    public unsafe virtual void RemoveAllCPIndicators()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllCPIndicators, "BmGame.RHudExtensionMultiplayerIdentifiers.RemoveAllCPIndicators");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveCPIndicator;
    /// <summary>
    /// Function: RemoveCPIndicator
    /// </summary>
    public unsafe virtual void RemoveCPIndicator(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCPIndicator, "BmGame.RHudExtensionMultiplayerIdentifiers.RemoveCPIndicator");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCPCapturedAnim;
    /// <summary>
    /// Function: PlayCPCapturedAnim
    /// </summary>
    public unsafe virtual void PlayCPCapturedAnim(int Id, int CapturedTeamColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCPCapturedAnim, "BmGame.RHudExtensionMultiplayerIdentifiers.PlayCPCapturedAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapturedTeamColour, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetHeroLockdownCPIndicator;
    /// <summary>
    /// Function: SetHeroLockdownCPIndicator
    /// </summary>
    public unsafe virtual void SetHeroLockdownCPIndicator(int Id, bool bInLockdown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeroLockdownCPIndicator, "BmGame.RHudExtensionMultiplayerIdentifiers.SetHeroLockdownCPIndicator");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInLockdown, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetFillScaleCPIndicator;
    /// <summary>
    /// Function: SetFillScaleCPIndicator
    /// </summary>
    public unsafe virtual void SetFillScaleCPIndicator(int Id, float FillScale, bool bOpaque)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFillScaleCPIndicator, "BmGame.RHudExtensionMultiplayerIdentifiers.SetFillScaleCPIndicator");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FillScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOpaque, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetFillColourCPIndicator;
    /// <summary>
    /// Function: SetFillColourCPIndicator
    /// </summary>
    public unsafe virtual void SetFillColourCPIndicator(int Id, int FillColour, bool bNeutral)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFillColourCPIndicator, "BmGame.RHudExtensionMultiplayerIdentifiers.SetFillColourCPIndicator");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FillColour, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNeutral, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetInteractionCPIndicator;
    /// <summary>
    /// Function: SetInteractionCPIndicator
    /// </summary>
    public unsafe virtual void SetInteractionCPIndicator(int Id, int BorderColour, bool bNeutral)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInteractionCPIndicator, "BmGame.RHudExtensionMultiplayerIdentifiers.SetInteractionCPIndicator");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BorderColour, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNeutral, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateOwnerCPIndicator;
    /// <summary>
    /// Function: UpdateOwnerCPIndicator
    /// </summary>
    public unsafe virtual void UpdateOwnerCPIndicator(int Id, in BmSDK.FString CPOwnerName, int CPOwnerColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateOwnerCPIndicator, "BmGame.RHudExtensionMultiplayerIdentifiers.UpdateOwnerCPIndicator");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPOwnerName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPOwnerColour, paramsPtr + 16);
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

    private static BmSDK.Function __fn_UpdateCPIndicator;
    /// <summary>
    /// Function: UpdateCPIndicator
    /// </summary>
    public unsafe virtual void UpdateCPIndicator(int Id, float cp_x, float cp_y, float cp_scale, float cp_alpha, BmSDK.FString CPDistFromPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCPIndicator, "BmGame.RHudExtensionMultiplayerIdentifiers.UpdateCPIndicator");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cp_x, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cp_y, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cp_scale, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cp_alpha, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPDistFromPlayer, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCPIndicator;
    /// <summary>
    /// Function: AddCPIndicator
    /// </summary>
    public unsafe virtual int AddCPIndicator(float cp_x, float cp_y, float cp_scale, float cp_alpha, BmSDK.FString CPDistFromPlayer, BmSDK.FString CPIDNumber, BmSDK.FString CPOwnerName, int CPOwnerColour, BmSDK.FString CpIconName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCPIndicator, "BmGame.RHudExtensionMultiplayerIdentifiers.AddCPIndicator");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cp_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cp_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cp_scale, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cp_alpha, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPDistFromPlayer, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPIDNumber, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPOwnerName, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPOwnerColour, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CpIconName, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_GetIFFIndicatorFromID;
    /// <summary>
    /// Function: GetIFFIndicatorFromID
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject GetIFFIndicatorFromID(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIFFIndicatorFromID, "BmGame.RHudExtensionMultiplayerIdentifiers.GetIFFIndicatorFromID");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCPIndicatorFromID;
    /// <summary>
    /// Function: GetCPIndicatorFromID
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject GetCPIndicatorFromID(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCPIndicatorFromID, "BmGame.RHudExtensionMultiplayerIdentifiers.GetCPIndicatorFromID");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemoveAllPlayerIFFs;
    /// <summary>
    /// Function: RemoveAllPlayerIFFs
    /// </summary>
    public unsafe virtual void RemoveAllPlayerIFFs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllPlayerIFFs, "BmGame.RHudExtensionMultiplayerIdentifiers.RemoveAllPlayerIFFs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemovePlayerIFF;
    /// <summary>
    /// Function: RemovePlayerIFF
    /// </summary>
    public unsafe virtual void RemovePlayerIFF(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePlayerIFF, "BmGame.RHudExtensionMultiplayerIdentifiers.RemovePlayerIFF");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShowPlayerIFF;
    /// <summary>
    /// Function: ShowPlayerIFF
    /// </summary>
    public unsafe virtual void ShowPlayerIFF(int Id, bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPlayerIFF, "BmGame.RHudExtensionMultiplayerIdentifiers.ShowPlayerIFF");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePlayerIFF;
    /// <summary>
    /// Function: UpdatePlayerIFF
    /// </summary>
    public unsafe virtual void UpdatePlayerIFF(int Id, float iff_x, float iff_y, float iff_scale, int teamColour, float TextAlpha)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePlayerIFF, "BmGame.RHudExtensionMultiplayerIdentifiers.UpdatePlayerIFF");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iff_x, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iff_y, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iff_scale, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(teamColour, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextAlpha, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPlayerIFF;
    /// <summary>
    /// Function: AddPlayerIFF
    /// </summary>
    public unsafe virtual int AddPlayerIFF(float iff_x, float iff_y, float iff_scale, int teamColour, float TextAlpha, BmSDK.FString PlayerName, BmSDK.FString PlayerAvatar, bool isCaptain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPlayerIFF, "BmGame.RHudExtensionMultiplayerIdentifiers.AddPlayerIFF");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iff_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iff_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iff_scale, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(teamColour, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextAlpha, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerAvatar, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isCaptain, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_FinishedShowAnimation;
    /// <summary>
    /// Function: FinishedShowAnimation
    /// </summary>
    public unsafe virtual void FinishedShowAnimation(BmSDK.FString IconMoviePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedShowAnimation, "BmGame.RHudExtensionMultiplayerIdentifiers.FinishedShowAnimation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconMoviePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedHideAnimation;
    /// <summary>
    /// Function: FinishedHideAnimation
    /// </summary>
    public unsafe virtual void FinishedHideAnimation(BmSDK.FString IconMoviePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedHideAnimation, "BmGame.RHudExtensionMultiplayerIdentifiers.FinishedHideAnimation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconMoviePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAllIcons;
    /// <summary>
    /// Function: RemoveAllIcons
    /// </summary>
    public unsafe virtual void RemoveAllIcons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllIcons, "BmGame.RHudExtensionMultiplayerIdentifiers.RemoveAllIcons");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveIcon;
    /// <summary>
    /// Function: RemoveIcon
    /// </summary>
    public unsafe virtual void RemoveIcon(BmSDK.GFxUI.GFxObject IconMC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveIcon, "BmGame.RHudExtensionMultiplayerIdentifiers.RemoveIcon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconMC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNotificationIcon;
    /// <summary>
    /// Function: AddNotificationIcon
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject AddNotificationIcon(bool bUseSupervillainIcon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNotificationIcon, "BmGame.RHudExtensionMultiplayerIdentifiers.AddNotificationIcon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseSupervillainIcon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InternalIFFStartFireEffect;
    /// <summary>
    /// Function: InternalIFFStartFireEffect
    /// </summary>
    public unsafe void InternalIFFStartFireEffect(bool bFiring)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalIFFStartFireEffect, "BmGame.RHudExtensionMultiplayerIdentifiers.InternalIFFStartFireEffect");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFiring, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IFFStartFireEffect;
    /// <summary>
    /// Function: IFFStartFireEffect
    /// </summary>
    public unsafe virtual void IFFStartFireEffect(BmSDK.GFxUI.GFxObject IFF, bool bFiring)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IFFStartFireEffect, "BmGame.RHudExtensionMultiplayerIdentifiers.IFFStartFireEffect");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IFF, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFiring, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalIFFTriggerHeroNoise;
    /// <summary>
    /// Function: InternalIFFTriggerHeroNoise
    /// </summary>
    public unsafe void InternalIFFTriggerHeroNoise(bool bBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalIFFTriggerHeroNoise, "BmGame.RHudExtensionMultiplayerIdentifiers.InternalIFFTriggerHeroNoise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatman, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IFFTriggerHeroNoise;
    /// <summary>
    /// Function: IFFTriggerHeroNoise
    /// </summary>
    public unsafe virtual void IFFTriggerHeroNoise(BmSDK.GFxUI.GFxObject IFF, bool bBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IFFTriggerHeroNoise, "BmGame.RHudExtensionMultiplayerIdentifiers.IFFTriggerHeroNoise");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IFF, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatman, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalIFFKilledByHero;
    /// <summary>
    /// Function: InternalIFFKilledByHero
    /// </summary>
    public unsafe void InternalIFFKilledByHero(bool bBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalIFFKilledByHero, "BmGame.RHudExtensionMultiplayerIdentifiers.InternalIFFKilledByHero");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatman, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IFFKilledByHero;
    /// <summary>
    /// Function: IFFKilledByHero
    /// </summary>
    public unsafe virtual void IFFKilledByHero(BmSDK.GFxUI.GFxObject IFF, bool bBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IFFKilledByHero, "BmGame.RHudExtensionMultiplayerIdentifiers.IFFKilledByHero");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IFF, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatman, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalIFFKilledByThug;
    /// <summary>
    /// Function: InternalIFFKilledByThug
    /// </summary>
    public unsafe void InternalIFFKilledByThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalIFFKilledByThug, "BmGame.RHudExtensionMultiplayerIdentifiers.InternalIFFKilledByThug");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IFFKilledByThug;
    /// <summary>
    /// Function: IFFKilledByThug
    /// </summary>
    public unsafe virtual void IFFKilledByThug(BmSDK.GFxUI.GFxObject IFF)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IFFKilledByThug, "BmGame.RHudExtensionMultiplayerIdentifiers.IFFKilledByThug");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IFF, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalIFFShow;
    /// <summary>
    /// Function: InternalIFFShow
    /// </summary>
    public unsafe void InternalIFFShow(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalIFFShow, "BmGame.RHudExtensionMultiplayerIdentifiers.InternalIFFShow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IFFShow;
    /// <summary>
    /// Function: IFFShow
    /// </summary>
    public unsafe virtual void IFFShow(BmSDK.GFxUI.GFxObject IFF, bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IFFShow, "BmGame.RHudExtensionMultiplayerIdentifiers.IFFShow");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IFF, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalBarUpdatePosition;
    /// <summary>
    /// Function: InternalBarUpdatePosition
    /// </summary>
    public unsafe void InternalBarUpdatePosition(float X, float Y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalBarUpdatePosition, "BmGame.RHudExtensionMultiplayerIdentifiers.InternalBarUpdatePosition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarUpdatePosition;
    /// <summary>
    /// Function: BarUpdatePosition
    /// </summary>
    public unsafe virtual void BarUpdatePosition(BmSDK.GFxUI.GFxObject Bar, float X, float Y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarUpdatePosition, "BmGame.RHudExtensionMultiplayerIdentifiers.BarUpdatePosition");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalBarUpdateTitle;
    /// <summary>
    /// Function: InternalBarUpdateTitle
    /// </summary>
    public unsafe void InternalBarUpdateTitle(BmSDK.FString Title)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalBarUpdateTitle, "BmGame.RHudExtensionMultiplayerIdentifiers.InternalBarUpdateTitle");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarUpdateTitle;
    /// <summary>
    /// Function: BarUpdateTitle
    /// </summary>
    public unsafe virtual void BarUpdateTitle(BmSDK.GFxUI.GFxObject Bar, BmSDK.FString Title)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarUpdateTitle, "BmGame.RHudExtensionMultiplayerIdentifiers.BarUpdateTitle");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalBarUpdatePercentage;
    /// <summary>
    /// Function: InternalBarUpdatePercentage
    /// </summary>
    public unsafe void InternalBarUpdatePercentage(float Percentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalBarUpdatePercentage, "BmGame.RHudExtensionMultiplayerIdentifiers.InternalBarUpdatePercentage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarUpdatePercentage;
    /// <summary>
    /// Function: BarUpdatePercentage
    /// </summary>
    public unsafe virtual void BarUpdatePercentage(BmSDK.GFxUI.GFxObject Bar, float Percentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarUpdatePercentage, "BmGame.RHudExtensionMultiplayerIdentifiers.BarUpdatePercentage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percentage, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAllDynamicBars;
    /// <summary>
    /// Function: RemoveAllDynamicBars
    /// </summary>
    public unsafe virtual void RemoveAllDynamicBars()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllDynamicBars, "BmGame.RHudExtensionMultiplayerIdentifiers.RemoveAllDynamicBars");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveDynamicBar;
    /// <summary>
    /// Function: RemoveDynamicBar
    /// </summary>
    public unsafe virtual void RemoveDynamicBar(BmSDK.GFxUI.GFxObject DynamicBar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDynamicBar, "BmGame.RHudExtensionMultiplayerIdentifiers.RemoveDynamicBar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DynamicBar, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDynamicBar;
    /// <summary>
    /// Function: AddDynamicBar
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject AddDynamicBar(float bar_x, float bar_y, float BarPercentage, BmSDK.FString BarTitle, float MaxValue, bool ShowCurrentAndMaxValue, int NumSplits, bool ShowTitle, bool ShowBar, bool CentreTitle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDynamicBar, "BmGame.RHudExtensionMultiplayerIdentifiers.AddDynamicBar");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bar_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bar_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarPercentage, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarTitle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowCurrentAndMaxValue, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSplits, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowTitle, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowBar, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CentreTitle, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_UpdateMultiplayerCPIndicators;
    /// <summary>
    /// Function: UpdateMultiplayerCPIndicators
    /// </summary>
    public unsafe virtual void UpdateMultiplayerCPIndicators(BmSDK.BmGame.GDGameReplicationInfo inGRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMultiplayerCPIndicators, "BmGame.RHudExtensionMultiplayerIdentifiers.UpdateMultiplayerCPIndicators");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inGRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMultiplayerIFFs;
    /// <summary>
    /// Function: UpdateMultiplayerIFFs
    /// </summary>
    public unsafe virtual void UpdateMultiplayerIFFs(BmSDK.BmGame.GDGameReplicationInfo inGRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMultiplayerIFFs, "BmGame.RHudExtensionMultiplayerIdentifiers.UpdateMultiplayerIFFs");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inGRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialTickUpdate;
    /// <summary>
    /// Function: InitialTickUpdate
    /// </summary>
    public unsafe virtual void InitialTickUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialTickUpdate, "BmGame.RHudExtensionMultiplayerIdentifiers.InitialTickUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudExtensionMultiplayerIdentifiers.Close");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudExtensionMultiplayerIdentifiers.Init");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddPlayerIFF
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddPlayerIFF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpdatePlayerIFF
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpdatePlayerIFF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ShowPlayerIFF
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ShowPlayerIFF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemovePlayerIFF
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemovePlayerIFF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveAllPlayerIFFs
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveAllPlayerIFFs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_GetIFFIndicatorFromID
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_GetIFFIndicatorFromID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddCPIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddCPIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpdateCPIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpdateCPIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpdateOwnerCPIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpdateOwnerCPIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetInteractionCPIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetInteractionCPIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetFillColourCPIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetFillColourCPIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetFillScaleCPIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetFillScaleCPIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetHeroLockdownCPIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetHeroLockdownCPIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_PlayCPCapturedAnim
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_PlayCPCapturedAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveCPIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveCPIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveAllCPIndicators
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveAllCPIndicators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_GetCPIndicatorFromID
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_GetCPIndicatorFromID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddNotificationIcon
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddNotificationIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveIcon
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveAllIcons
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveAllIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddDynamicBar
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddDynamicBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveDynamicBar
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveDynamicBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveAllDynamicBars
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveAllDynamicBars
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_BarUpdatePercentage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_BarUpdatePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_BarUpdateTitle
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_BarUpdateTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_BarUpdatePosition
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_BarUpdatePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_IFFStartFireEffect
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_IFFStartFireEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ToggleLockOn
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ToggleLockOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// StructProperty: Team1Colour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor Team1Colour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 472);

    /// <summary>
    /// StructProperty: Team2Colour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor Team2Colour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 476);

    /// <summary>
    /// BoolProperty: bInitialUpdateTickDone
    /// </summary>
    public unsafe bool bInitialUpdateTickDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bCurrentlyVisible
    /// </summary>
    public unsafe bool bCurrentlyVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: TempObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject TempObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.BmGame.GDGameReplicationInfo GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGameReplicationInfo>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ObjectProperty: DashCooldown
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject DashCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// IntProperty: CachedDashCooldownFrac
    /// </summary>
    public unsafe int CachedDashCooldownFrac
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// FloatProperty: CachedMaxDashCooldownTime
    /// </summary>
    public unsafe float CachedMaxDashCooldownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ObjectProperty: DeathCameraText
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject DeathCameraText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ObjectProperty: CachedArenaCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RArenaCamera CachedArenaCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RArenaCamera>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// ObjectProperty: ThugVisionBattery
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ThugVisionBattery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: CachedThugVisionBattery
    /// </summary>
    public unsafe int CachedThugVisionBattery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }
}
