#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionTargets<br/>
/// (size = 244)
/// (flags = 134217874)
/// </summary>
public partial class RHudExtensionTargets : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudExtensionTargets", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudExtensionTargets.
    /// </summary>
    public static RHudExtensionTargets DefaultObject => (RHudExtensionTargets)StaticClass().DefaultObject;

    internal RHudExtensionTargets() { }

    /// <summary>
    /// Constructs a new RHudExtensionTargets
    /// </summary>
    public RHudExtensionTargets(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudExtensionTargets Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudExtensionTargets(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionTargets>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionTargets>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionTargets>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionTargets>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionTargets>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionTargets>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionTargets>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionTargets>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetTargetJammerLockonProportion;
    /// <summary>
    /// Function: SetTargetJammerLockonProportion
    /// </summary>
    public unsafe virtual void SetTargetJammerLockonProportion(int CursorID, float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetJammerLockonProportion, "BmGame.RHudExtensionTargets.SetTargetJammerLockonProportion");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TargetCursorPrivate;
    /// <summary>
    /// Function: TargetCursorPrivate
    /// </summary>
    public unsafe virtual void TargetCursorPrivate(int CursorID, BmSDK.FString AnimName, bool bVisible, bool bSnapToPosition, float X, float Y, float Depth, bool Pulsing, int Charges, int MaxCharges)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetCursorPrivate, "BmGame.RHudExtensionTargets.TargetCursorPrivate");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSnapToPosition, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pulsing, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Charges, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCharges, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TargetCursor;
    /// <summary>
    /// Function: TargetCursor
    /// </summary>
    public unsafe virtual void TargetCursor(int CursorID, BmSDK.FString AnimName, bool bVisible, bool bSnapToPosition, float X, float Y, float Depth, bool Pulsing = default, int Charges = default, int MaxCharges = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetCursor, "BmGame.RHudExtensionTargets.TargetCursor");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSnapToPosition, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pulsing, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Charges, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCharges, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAllCursors;
    /// <summary>
    /// Function: ClearAllCursors
    /// </summary>
    public unsafe virtual void ClearAllCursors()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllCursors, "BmGame.RHudExtensionTargets.ClearAllCursors");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayMissileLaunchText;
    /// <summary>
    /// Function: DisplayMissileLaunchText
    /// </summary>
    public unsafe virtual void DisplayMissileLaunchText(BmSDK.FString TextToDisplay, float DisplayDuration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayMissileLaunchText, "BmGame.RHudExtensionTargets.DisplayMissileLaunchText");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextToDisplay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayDuration, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideGrenadeWarning;
    /// <summary>
    /// Function: HideGrenadeWarning
    /// </summary>
    public unsafe virtual void HideGrenadeWarning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideGrenadeWarning, "BmGame.RHudExtensionTargets.HideGrenadeWarning");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Private_CachedFunction_SetGrenadeWarning;
    /// <summary>
    /// Function: Private_CachedFunction_SetGrenadeWarning
    /// </summary>
    public unsafe virtual void Private_CachedFunction_SetGrenadeWarning(float grenade_x, float grenade_y, bool is_grenade)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Private_CachedFunction_SetGrenadeWarning, "BmGame.RHudExtensionTargets.Private_CachedFunction_SetGrenadeWarning");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(grenade_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(grenade_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_grenade, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGrenadeWarning;
    /// <summary>
    /// Function: SetGrenadeWarning
    /// </summary>
    public unsafe virtual void SetGrenadeWarning(System.Numerics.Vector3 GrenadePosition, bool IsGrenadeType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrenadeWarning, "BmGame.RHudExtensionTargets.SetGrenadeWarning");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadePosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsGrenadeType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMissileWarning;
    /// <summary>
    /// Function: UpdateMissileWarning
    /// </summary>
    public unsafe virtual void UpdateMissileWarning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMissileWarning, "BmGame.RHudExtensionTargets.UpdateMissileWarning");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMissileWarning;
    /// <summary>
    /// Function: SetMissileWarning
    /// </summary>
    public unsafe virtual void SetMissileWarning(System.Numerics.Vector3 _MissilePosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMissileWarning, "BmGame.RHudExtensionTargets.SetMissileWarning");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MissilePosition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMarkerAttributes;
    /// <summary>
    /// Function: SetMarkerAttributes
    /// </summary>
    public unsafe virtual void SetMarkerAttributes(int MarkerIndex, bool MarkerVisible, float MarkerAngle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMarkerAttributes, "BmGame.RHudExtensionTargets.SetMarkerAttributes");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerVisible, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerAngle, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsMarkerVisible;
    /// <summary>
    /// Function: IsMarkerVisible
    /// </summary>
    public unsafe virtual bool IsMarkerVisible(int MarkerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMarkerVisible, "BmGame.RHudExtensionTargets.IsMarkerVisible");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_NotifyMarkerLocationChanged;
    /// <summary>
    /// Function: NotifyMarkerLocationChanged
    /// </summary>
    public unsafe virtual void NotifyMarkerLocationChanged(int MarkerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyMarkerLocationChanged, "BmGame.RHudExtensionTargets.NotifyMarkerLocationChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCustomMarkerFrameString;
    /// <summary>
    /// Function: SetCustomMarkerFrameString
    /// </summary>
    public unsafe virtual void SetCustomMarkerFrameString(BmSDK.FString FrameString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomMarkerFrameString, "BmGame.RHudExtensionTargets.SetCustomMarkerFrameString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrameString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckCustomMarkerFrame;
    /// <summary>
    /// Function: CheckCustomMarkerFrame
    /// </summary>
    public unsafe virtual bool CheckCustomMarkerFrame(BmSDK.FString TestSubstring, BmSDK.FString FrameToSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCustomMarkerFrame, "BmGame.RHudExtensionTargets.CheckCustomMarkerFrame");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestSubstring, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrameToSet, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SetCustomMarkerIconTypeName;
    /// <summary>
    /// Function: SetCustomMarkerIconTypeName
    /// </summary>
    public unsafe virtual void SetCustomMarkerIconTypeName(BmSDK.FString _CustomMarkerIconName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomMarkerIconTypeName, "BmGame.RHudExtensionTargets.SetCustomMarkerIconTypeName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CustomMarkerIconName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideCompass;
    /// <summary>
    /// Function: HideCompass
    /// </summary>
    public unsafe virtual void HideCompass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideCompass, "BmGame.RHudExtensionTargets.HideCompass");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCompassAnglePrivate;
    /// <summary>
    /// Function: SetCompassAnglePrivate
    /// </summary>
    public unsafe virtual void SetCompassAnglePrivate(float CompassAngle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCompassAnglePrivate, "BmGame.RHudExtensionTargets.SetCompassAnglePrivate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompassAngle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCompassAngle;
    /// <summary>
    /// Function: SetCompassAngle
    /// </summary>
    public unsafe virtual void SetCompassAngle(float CompassAngle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCompassAngle, "BmGame.RHudExtensionTargets.SetCompassAngle");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompassAngle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAnytimeAngle;
    /// <summary>
    /// Function: SetAnytimeAngle
    /// </summary>
    public unsafe virtual void SetAnytimeAngle(bool bVisible, float anytimeAngle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnytimeAngle, "BmGame.RHudExtensionTargets.SetAnytimeAngle");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(anytimeAngle, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawGrappleIconAtEndOfHudUpdate;
    /// <summary>
    /// Function: DrawGrappleIconAtEndOfHudUpdate
    /// </summary>
    public unsafe virtual void DrawGrappleIconAtEndOfHudUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawGrappleIconAtEndOfHudUpdate, "BmGame.RHudExtensionTargets.DrawGrappleIconAtEndOfHudUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Private_SendAnytime;
    /// <summary>
    /// Function: Private_SendAnytime
    /// </summary>
    public unsafe virtual void Private_SendAnytime(bool bVisible, float X, float Y, BmSDK.FString AnimName, bool bRestart, float Depth)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Private_SendAnytime, "BmGame.RHudExtensionTargets.Private_SendAnytime");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRestart, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowGrappleIcon;
    /// <summary>
    /// Function: ShowGrappleIcon
    /// </summary>
    public unsafe virtual void ShowGrappleIcon(bool bVisible, float X, float Y, BmSDK.FString AnimName, bool bRestart, float Depth)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowGrappleIcon, "BmGame.RHudExtensionTargets.ShowGrappleIcon");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRestart, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 28);
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

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudExtensionTargets.Close");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetContents;
    /// <summary>
    /// Function: GetContents
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject GetContents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetContents, "BmGame.RHudExtensionTargets.GetContents");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudExtensionTargets.Init");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Enum: EObjectiveMarkerTypes
    /// </summary>
    public enum EObjectiveMarkerTypes : byte
    {
        OMT_Objective = 0,
        OMT_Custom = 1,
        OMT_MAX = 2,
    }

    /// <summary>
    /// BoolProperty: Anytime_bVisible
    /// </summary>
    public unsafe bool Anytime_bVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: Anytime_bRestart
    /// </summary>
    public unsafe bool Anytime_bRestart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: AnytimeAngleVisible
    /// </summary>
    public unsafe bool AnytimeAngleVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bInSplitscreen
    /// </summary>
    public unsafe bool bInSplitscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bCompassVisible
    /// </summary>
    public unsafe bool bCompassVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bGrenadeWarningActive
    /// </summary>
    public unsafe bool bGrenadeWarningActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: CustomMarkerSuppressesExtraHud
    /// </summary>
    public unsafe bool CustomMarkerSuppressesExtraHud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: MissileIsActive
    /// </summary>
    public unsafe bool MissileIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: Anytime_X
    /// </summary>
    public unsafe float Anytime_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: Anytime_Y
    /// </summary>
    public unsafe float Anytime_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: Anytime_Depth
    /// </summary>
    public unsafe float Anytime_Depth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StrProperty: Anytime_AnimName
    /// </summary>
    public unsafe BmSDK.FString Anytime_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: AnytimeAngleValue
    /// </summary>
    public unsafe float AnytimeAngleValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: abMarkersVisible
    /// </summary>
    public unsafe BmSDK.TArray<bool> abMarkersVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: abMarkerAngles
    /// </summary>
    public unsafe BmSDK.TArray<float> abMarkerAngles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ArrayProperty: avMarkerWorldPositions
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> avMarkerWorldPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: abReticlesVisible
    /// </summary>
    public unsafe BmSDK.TArray<bool> abReticlesVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// ArrayProperty: avReticlesPositions
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> avReticlesPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: IgnoreCompassCountdown
    /// </summary>
    public unsafe int IgnoreCompassCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: LastCompassAngle
    /// </summary>
    public unsafe float LastCompassAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StrProperty: CustomMarkerFrameString
    /// </summary>
    public unsafe BmSDK.FString CustomMarkerFrameString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// StrProperty: CustomMarkerIconName
    /// </summary>
    public unsafe BmSDK.FString CustomMarkerIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: MissilePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissilePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 224);

    /// <summary>
    /// IntProperty: MaxTargetCursorIndex
    /// </summary>
    public unsafe int MaxTargetCursorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ObjectProperty: ContentsCached
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ContentsCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
}
