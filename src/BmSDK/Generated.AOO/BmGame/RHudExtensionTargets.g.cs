#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionTargets<br/>
/// (size = 1224)
/// (flags = 134250642)
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

    private static BmSDK.Function __fn_asShowGadgetTimer;
    /// <summary>
    /// Function: asShowGadgetTimer
    /// </summary>
    public unsafe virtual void asShowGadgetTimer(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asShowGadgetTimer, "BmGame.RHudExtensionTargets.asShowGadgetTimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asUpdateGadgetTimerPosition;
    /// <summary>
    /// Function: asUpdateGadgetTimerPosition
    /// </summary>
    public unsafe virtual void asUpdateGadgetTimerPosition(float XPos, float YPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asUpdateGadgetTimerPosition, "BmGame.RHudExtensionTargets.asUpdateGadgetTimerPosition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YPos, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asGetEndGadgetTimerFrame;
    /// <summary>
    /// Function: asGetEndGadgetTimerFrame
    /// </summary>
    public unsafe virtual int asGetEndGadgetTimerFrame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetEndGadgetTimerFrame, "BmGame.RHudExtensionTargets.asGetEndGadgetTimerFrame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetStartGadgetTimerFrame;
    /// <summary>
    /// Function: asGetStartGadgetTimerFrame
    /// </summary>
    public unsafe virtual int asGetStartGadgetTimerFrame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetStartGadgetTimerFrame, "BmGame.RHudExtensionTargets.asGetStartGadgetTimerFrame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetTimerClip;
    /// <summary>
    /// Function: asGetTimerClip
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetTimerClip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetTimerClip, "BmGame.RHudExtensionTargets.asGetTimerClip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveGadgetIconTimerPrivate;
    /// <summary>
    /// Function: RemoveGadgetIconTimerPrivate
    /// </summary>
    public unsafe void RemoveGadgetIconTimerPrivate(BmSDK.GFxUI.GFxObject Movie)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveGadgetIconTimerPrivate, "BmGame.RHudExtensionTargets.RemoveGadgetIconTimerPrivate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Movie, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGadgetIconTimerPrivate;
    /// <summary>
    /// Function: AddGadgetIconTimerPrivate
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject AddGadgetIconTimerPrivate(float XPos, float YPos, BmSDK.FString GadgetIconName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGadgetIconTimerPrivate, "BmGame.RHudExtensionTargets.AddGadgetIconTimerPrivate");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetIconName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ShowGadgetTimer;
    /// <summary>
    /// Function: ShowGadgetTimer
    /// </summary>
    public unsafe virtual void ShowGadgetTimer(bool bShow, float atX, float atY, float Scale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowGadgetTimer, "BmGame.RHudExtensionTargets.ShowGadgetTimer");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGadgetTimerFrame;
    /// <summary>
    /// Function: SetGadgetTimerFrame
    /// </summary>
    public unsafe virtual void SetGadgetTimerFrame(int FrameNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGadgetTimerFrame, "BmGame.RHudExtensionTargets.SetGadgetTimerFrame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrameNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveGadgetIconTimer;
    /// <summary>
    /// Function: RemoveGadgetIconTimer
    /// </summary>
    public unsafe virtual void RemoveGadgetIconTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveGadgetIconTimer, "BmGame.RHudExtensionTargets.RemoveGadgetIconTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGadgetIconTimer;
    /// <summary>
    /// Function: AddGadgetIconTimer
    /// </summary>
    public unsafe virtual void AddGadgetIconTimer(float XPos, float YPos, BmSDK.FString GadgetIconName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGadgetIconTimer, "BmGame.RHudExtensionTargets.AddGadgetIconTimer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetIconName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowFriendlyCursor;
    /// <summary>
    /// Function: ShowFriendlyCursor
    /// </summary>
    public unsafe virtual void ShowFriendlyCursor(int CursorID, bool bFriendly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFriendlyCursor, "BmGame.RHudExtensionTargets.ShowFriendlyCursor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFriendly, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowInvulnerableCursor;
    /// <summary>
    /// Function: ShowInvulnerableCursor
    /// </summary>
    public unsafe virtual void ShowInvulnerableCursor(int CursorID, bool bInvul)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowInvulnerableCursor, "BmGame.RHudExtensionTargets.ShowInvulnerableCursor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInvul, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowLowAlphaCursor;
    /// <summary>
    /// Function: ShowLowAlphaCursor
    /// </summary>
    public unsafe virtual void ShowLowAlphaCursor(bool bLowAlpha)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLowAlphaCursor, "BmGame.RHudExtensionTargets.ShowLowAlphaCursor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLowAlpha, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowDotCursor;
    /// <summary>
    /// Function: ShowDotCursor
    /// </summary>
    public unsafe virtual void ShowDotCursor(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowDotCursor, "BmGame.RHudExtensionTargets.ShowDotCursor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCursorHitDetect;
    /// <summary>
    /// Function: ShowCursorHitDetect
    /// </summary>
    public unsafe virtual void ShowCursorHitDetect(int CursorID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCursorHitDetect, "BmGame.RHudExtensionTargets.ShowCursorHitDetect");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTargetTimerCountdownProportionPrivate;
    /// <summary>
    /// Function: SetTargetTimerCountdownProportionPrivate
    /// </summary>
    public unsafe virtual void SetTargetTimerCountdownProportionPrivate(int CursorID, float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetTimerCountdownProportionPrivate, "BmGame.RHudExtensionTargets.SetTargetTimerCountdownProportionPrivate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMaxMinSpreadDist;
    /// <summary>
    /// Function: SetMaxMinSpreadDist
    /// </summary>
    public unsafe virtual void SetMaxMinSpreadDist(float NewMaxDist, float NewMinDist)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaxMinSpreadDist, "BmGame.RHudExtensionTargets.SetMaxMinSpreadDist");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMaxDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMinDist, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTargetFireSpreadProportionPrivate;
    /// <summary>
    /// Function: SetTargetFireSpreadProportionPrivate
    /// </summary>
    public unsafe virtual void SetTargetFireSpreadProportionPrivate(int CursorID, float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetFireSpreadProportionPrivate, "BmGame.RHudExtensionTargets.SetTargetFireSpreadProportionPrivate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTargetJammerLockonProportionPrivate;
    /// <summary>
    /// Function: SetTargetJammerLockonProportionPrivate
    /// </summary>
    public unsafe virtual void SetTargetJammerLockonProportionPrivate(int CursorID, float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetJammerLockonProportionPrivate, "BmGame.RHudExtensionTargets.SetTargetJammerLockonProportionPrivate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTargetFireSpreadProportion;
    /// <summary>
    /// Function: SetTargetFireSpreadProportion
    /// </summary>
    public unsafe virtual void SetTargetFireSpreadProportion(int CursorID, float Proportion, bool ForceUpdate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetFireSpreadProportion, "BmGame.RHudExtensionTargets.SetTargetFireSpreadProportion");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceUpdate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTargetTimerCountdownProportion;
    /// <summary>
    /// Function: SetTargetTimerCountdownProportion
    /// </summary>
    public unsafe virtual void SetTargetTimerCountdownProportion(int CursorID, float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetTimerCountdownProportion, "BmGame.RHudExtensionTargets.SetTargetTimerCountdownProportion");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

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

    private static BmSDK.Function __fn_RemoveAllGrenadeIndicators;
    /// <summary>
    /// Function: RemoveAllGrenadeIndicators
    /// </summary>
    public unsafe virtual void RemoveAllGrenadeIndicators()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllGrenadeIndicators, "BmGame.RHudExtensionTargets.RemoveAllGrenadeIndicators");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGrenadeIndicator;
    /// <summary>
    /// Function: UpdateGrenadeIndicator
    /// </summary>
    public unsafe virtual void UpdateGrenadeIndicator(int Index, float grenade_x, float grenade_y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGrenadeIndicator, "BmGame.RHudExtensionTargets.UpdateGrenadeIndicator");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(grenade_x, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(grenade_y, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideGrenadeWarning;
    /// <summary>
    /// Function: HideGrenadeWarning
    /// </summary>
    public unsafe virtual void HideGrenadeWarning(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideGrenadeWarning, "BmGame.RHudExtensionTargets.HideGrenadeWarning");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Private_CachedFunction_SetGrenadeWarning;
    /// <summary>
    /// Function: Private_CachedFunction_SetGrenadeWarning
    /// </summary>
    public unsafe virtual int Private_CachedFunction_SetGrenadeWarning(float grenade_x, float grenade_y, bool is_grenade)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Private_CachedFunction_SetGrenadeWarning, "BmGame.RHudExtensionTargets.Private_CachedFunction_SetGrenadeWarning");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(grenade_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(grenade_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_grenade, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PositionToScreenCoords;
    /// <summary>
    /// Function: PositionToScreenCoords
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 PositionToScreenCoords(System.Numerics.Vector3 GrenadePosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PositionToScreenCoords, "BmGame.RHudExtensionTargets.PositionToScreenCoords");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadePosition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UpdateGrenadeWarning;
    /// <summary>
    /// Function: UpdateGrenadeWarning
    /// </summary>
    public unsafe virtual void UpdateGrenadeWarning(System.Numerics.Vector3 GrenadePosition, int Handle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGrenadeWarning, "BmGame.RHudExtensionTargets.UpdateGrenadeWarning");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadePosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Handle, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateGrenadeWarning;
    /// <summary>
    /// Function: CreateGrenadeWarning
    /// </summary>
    public unsafe virtual int CreateGrenadeWarning(System.Numerics.Vector3 GrenadePosition, bool IsGrenadeType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateGrenadeWarning, "BmGame.RHudExtensionTargets.CreateGrenadeWarning");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadePosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsGrenadeType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DamageIndicatorExpired;
    /// <summary>
    /// Function: DamageIndicatorExpired
    /// </summary>
    public unsafe virtual void DamageIndicatorExpired(int ActionScriptId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageIndicatorExpired, "BmGame.RHudExtensionTargets.DamageIndicatorExpired");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActionScriptId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Private_CachedFunction_UpdateDirectionalDamageIndicator;
    /// <summary>
    /// Function: Private_CachedFunction_UpdateDirectionalDamageIndicator
    /// </summary>
    public unsafe virtual void Private_CachedFunction_UpdateDirectionalDamageIndicator(int ActionScriptId, float DamageIndicatorAngle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Private_CachedFunction_UpdateDirectionalDamageIndicator, "BmGame.RHudExtensionTargets.Private_CachedFunction_UpdateDirectionalDamageIndicator");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActionScriptId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageIndicatorAngle, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateDirectionalDamageIndicators;
    /// <summary>
    /// Function: UpdateDirectionalDamageIndicators
    /// </summary>
    public unsafe virtual void UpdateDirectionalDamageIndicators()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDirectionalDamageIndicators, "BmGame.RHudExtensionTargets.UpdateDirectionalDamageIndicators");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Private_CachedFunction_GetDamageIndicatorForId;
    /// <summary>
    /// Function: Private_CachedFunction_GetDamageIndicatorForId
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject Private_CachedFunction_GetDamageIndicatorForId(int ActionScriptId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Private_CachedFunction_GetDamageIndicatorForId, "BmGame.RHudExtensionTargets.Private_CachedFunction_GetDamageIndicatorForId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActionScriptId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Private_CachedFunction_AddDirectionalDamageIndicator;
    /// <summary>
    /// Function: Private_CachedFunction_AddDirectionalDamageIndicator
    /// </summary>
    public unsafe virtual int Private_CachedFunction_AddDirectionalDamageIndicator(float DamageIndicatorAngle, int TypeOfDamage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Private_CachedFunction_AddDirectionalDamageIndicator, "BmGame.RHudExtensionTargets.Private_CachedFunction_AddDirectionalDamageIndicator");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageIndicatorAngle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeOfDamage, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetHitRotation;
    /// <summary>
    /// Function: GetHitRotation
    /// </summary>
    public unsafe virtual float GetHitRotation(System.Numerics.Vector3 HitSourceLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitRotation, "BmGame.RHudExtensionTargets.GetHitRotation");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitSourceLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_NotifyDirectionalDamage;
    /// <summary>
    /// Function: NotifyDirectionalDamage
    /// </summary>
    public unsafe virtual void NotifyDirectionalDamage(System.Numerics.Vector3 HitSourceLocation, BmSDK.Class dmgType, bool bPawnDead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyDirectionalDamage, "BmGame.RHudExtensionTargets.NotifyDirectionalDamage");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitSourceLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPawnDead, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamageTypeIndex;
    /// <summary>
    /// Function: GetDamageTypeIndex
    /// </summary>
    public unsafe virtual int GetDamageTypeIndex(BmSDK.Class dmgType, bool bPawnDead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageTypeIndex, "BmGame.RHudExtensionTargets.GetDamageTypeIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPawnDead, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateMissileWarning;
    /// <summary>
    /// Function: UpdateMissileWarning
    /// </summary>
    public unsafe virtual void UpdateMissileWarning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMissileWarning, "BmGame.RHudExtensionTargets.UpdateMissileWarning");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMissileWarning;
    /// <summary>
    /// Function: SetMissileWarning
    /// </summary>
    public unsafe virtual void SetMissileWarning(BmSDK.Engine.Actor Missile, System.Numerics.Vector3 _MissilePosition, bool IsGrenadeType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMissileWarning, "BmGame.RHudExtensionTargets.SetMissileWarning");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Missile, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MissilePosition, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsGrenadeType, paramsPtr + 16);
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

    private static BmSDK.Function __fn_GetAnytimeGrappleIcon;
    /// <summary>
    /// Function: GetAnytimeGrappleIcon
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject GetAnytimeGrappleIcon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnytimeGrappleIcon, "BmGame.RHudExtensionTargets.GetAnytimeGrappleIcon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Private_SendAnytime;
    /// <summary>
    /// Function: Private_SendAnytime
    /// </summary>
    public unsafe virtual void Private_SendAnytime(bool bVisible, int X, int Y, BmSDK.FString AnimName, bool bRestart, float Depth)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Private_SendAnytime, "BmGame.RHudExtensionTargets.Private_SendAnytime");
        byte* paramsPtr = stackalloc byte[52];
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
    public unsafe virtual void ShowGrappleIcon(bool bVisible, int X, int Y, BmSDK.FString AnimName, bool bRestart, float Depth)
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
    /// Struct: FCursorData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FCursorData
    {
        /// <summary>
        /// FloatProperty: JammerLockonProportion
        /// </summary>
        public unsafe float JammerLockonProportion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: SpreadProportion
        /// </summary>
        public unsafe float SpreadProportion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TargetTimerProportion
        /// </summary>
        public unsafe int TargetTimerProportion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: AnimName
        /// </summary>
        public unsafe BmSDK.FString AnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bVisible
        /// </summary>
        public unsafe bool bVisible
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bSnapToPosition
        /// </summary>
        public unsafe bool bSnapToPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: X
        /// </summary>
        public unsafe float X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: Y
        /// </summary>
        public unsafe float Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Depth
        /// </summary>
        public unsafe float Depth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: Pulsing
        /// </summary>
        public unsafe bool Pulsing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: Charges
        /// </summary>
        public unsafe int Charges
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: MaxCharges
        /// </summary>
        public unsafe int MaxCharges
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FDamageIndicatorData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FDamageIndicatorData
    {
        /// <summary>
        /// StructProperty: HitSourceLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 HitSourceLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Active
        /// </summary>
        public unsafe bool Active
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: ActionScriptObject
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ActionScriptObject
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FMissileData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FMissileData
    {
        /// <summary>
        /// ObjectProperty: Missile
        /// </summary>
        public unsafe BmSDK.Engine.Actor Missile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: MissileLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 MissileLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bIsGrenade
        /// </summary>
        public unsafe bool bIsGrenade
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Handle
        /// </summary>
        public unsafe int Handle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// BoolProperty: Anytime_bVisible
    /// </summary>
    public unsafe bool Anytime_bVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: Anytime_bRestart
    /// </summary>
    public unsafe bool Anytime_bRestart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: AnytimeAngleVisible
    /// </summary>
    public unsafe bool AnytimeAngleVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bInSplitscreen
    /// </summary>
    public unsafe bool bInSplitscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bCompassVisible
    /// </summary>
    public unsafe bool bCompassVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CustomMarkerSuppressesExtraHud
    /// </summary>
    public unsafe bool CustomMarkerSuppressesExtraHud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bCachedShowDotCursor
    /// </summary>
    public unsafe bool bCachedShowDotCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// IntProperty: Anytime_X
    /// </summary>
    public unsafe int Anytime_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// IntProperty: Anytime_Y
    /// </summary>
    public unsafe int Anytime_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: Anytime_Depth
    /// </summary>
    public unsafe int Anytime_Depth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StrProperty: Anytime_AnimName
    /// </summary>
    public unsafe BmSDK.FString Anytime_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: AnytimeAngleValue
    /// </summary>
    public unsafe float AnytimeAngleValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: Missiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudExtensionTargets.FMissileData> Missiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudExtensionTargets.FMissileData>>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// ArrayProperty: abMarkersVisible
    /// </summary>
    public unsafe BmSDK.TArray<bool> abMarkersVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: abMarkerAngles
    /// </summary>
    public unsafe BmSDK.TArray<float> abMarkerAngles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: avMarkerWorldPositions
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> avMarkerWorldPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ArrayProperty: abReticlesVisible
    /// </summary>
    public unsafe BmSDK.TArray<bool> abReticlesVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ArrayProperty: avReticlesPositions
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> avReticlesPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: DamageIndicators
    /// </summary>
    public InlineArray<BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData> DamageIndicators => new(8, Ptr + 240, 20, this);

    /// <summary>
    /// StructProperty: DamageIndicators
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData DamageIndicators_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData>(Ptr + 240);
    /// <summary>
    /// StructProperty: DamageIndicators
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData DamageIndicators_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData>(Ptr + 260);
    /// <summary>
    /// StructProperty: DamageIndicators
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData DamageIndicators_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData>(Ptr + 280);
    /// <summary>
    /// StructProperty: DamageIndicators
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData DamageIndicators_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData>(Ptr + 300);
    /// <summary>
    /// StructProperty: DamageIndicators
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData DamageIndicators_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData>(Ptr + 320);
    /// <summary>
    /// StructProperty: DamageIndicators
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData DamageIndicators_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData>(Ptr + 340);
    /// <summary>
    /// StructProperty: DamageIndicators
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData DamageIndicators_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData>(Ptr + 360);
    /// <summary>
    /// StructProperty: DamageIndicators
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData DamageIndicators_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FDamageIndicatorData>(Ptr + 380);

    /// <summary>
    /// IntProperty: IgnoreCompassCountdown
    /// </summary>
    public unsafe int IgnoreCompassCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: LastCompassAngle
    /// </summary>
    public unsafe float LastCompassAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StrProperty: CustomMarkerFrameString
    /// </summary>
    public unsafe BmSDK.FString CustomMarkerFrameString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// StrProperty: CustomMarkerIconName
    /// </summary>
    public unsafe BmSDK.FString CustomMarkerIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_GetAnytimeGrappleIcon
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_GetAnytimeGrappleIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ShowAnyTimePrompt
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ShowAnyTimePrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_DrawTargetNow
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_DrawTargetNow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetAnyTimeAngle
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetAnyTimeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCompassAngle
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCompassAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_TargetCursorShow
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_TargetCursorShow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetLockonProportion
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetLockonProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetFireSpreadProportion
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetFireSpreadProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetMaxMinSpreadDist
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetMaxMinSpreadDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetTargetTimerProportion
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetTargetTimerProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ShowHitDetection
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ShowHitDetection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetGrenadeWarning
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetGrenadeWarning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpdateGrenadeWarning
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpdateGrenadeWarning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideGrenadeWarning
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideGrenadeWarning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveAllGrenadeWarnings
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveAllGrenadeWarnings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddDirectionalDamageIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddDirectionalDamageIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_GetDamageIndicatorForId
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_GetDamageIndicatorForId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpdateDirectionalDamageIndicator
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpdateDirectionalDamageIndicator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddGadgetTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddGadgetTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveGadgetTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveGadgetTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RemoveAllGadgetTimerIcon
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RemoveAllGadgetTimerIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ShowLowAlphaCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ShowLowAlphaCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ShowInvulnerableCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ShowInvulnerableCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ShowFriendlyCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ShowFriendlyCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ShowDotCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ShowDotCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// IntProperty: MaxTargetCursorIndex
    /// </summary>
    public unsafe int MaxTargetCursorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: ControllableGadgetTimerIcon
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ControllableGadgetTimerIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: ControllableGadgetTimerIconAnimation
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ControllableGadgetTimerIconAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: AnyTimePromptObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject AnyTimePromptObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// StructProperty: AnyTimePromptDI
    /// </summary>
    public unsafe ref BmSDK.GFxUI.GFxObject.FASDisplayInfo AnyTimePromptDI
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GFxUI.GFxObject.FASDisplayInfo>(Ptr + 748);

    /// <summary>
    /// StrProperty: AnytimeGrappleIconAnimName
    /// </summary>
    public unsafe BmSDK.FString AnytimeGrappleIconAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// IntProperty: DontPlayAnytimeIntroCountdown
    /// </summary>
    public unsafe int DontPlayAnytimeIntroCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: CachedCursorData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RHudExtensionTargets.FCursorData> CachedCursorData => new(8, Ptr + 808, 52, this);

    /// <summary>
    /// StructProperty: CachedCursorData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FCursorData CachedCursorData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FCursorData>(Ptr + 808);
    /// <summary>
    /// StructProperty: CachedCursorData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FCursorData CachedCursorData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FCursorData>(Ptr + 860);
    /// <summary>
    /// StructProperty: CachedCursorData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FCursorData CachedCursorData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FCursorData>(Ptr + 912);
    /// <summary>
    /// StructProperty: CachedCursorData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FCursorData CachedCursorData_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FCursorData>(Ptr + 964);
    /// <summary>
    /// StructProperty: CachedCursorData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FCursorData CachedCursorData_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FCursorData>(Ptr + 1016);
    /// <summary>
    /// StructProperty: CachedCursorData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FCursorData CachedCursorData_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FCursorData>(Ptr + 1068);
    /// <summary>
    /// StructProperty: CachedCursorData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FCursorData CachedCursorData_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FCursorData>(Ptr + 1120);
    /// <summary>
    /// StructProperty: CachedCursorData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHudExtensionTargets.FCursorData CachedCursorData_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHudExtensionTargets.FCursorData>(Ptr + 1172);
}
