#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDialogueCamera<br/>
/// (size = 1152)
/// (flags = 144703634)
/// </summary>
public partial class RDialogueCamera : BmSDK.BmGame.RCameraActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDialogueCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RDialogueCamera.
    /// </summary>
    public static RDialogueCamera DefaultObject => (RDialogueCamera)StaticClass().DefaultObject;

    internal RDialogueCamera() { }

    /// <summary>
    /// Constructs a new RDialogueCamera
    /// </summary>
    public RDialogueCamera(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDialogueCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDialogueCamera>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueCamera>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDialogueCamera>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueCamera>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueCamera>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueCamera>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDialogueCamera>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueCamera>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetNewCloseCamValues;
    /// <summary>
    /// Function: SetNewCloseCamValues
    /// </summary>
    public unsafe virtual void SetNewCloseCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNewCloseCamValues, "BmGame.RDialogueCamera.SetNewCloseCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNewCloseBMCamValues;
    /// <summary>
    /// Function: GetNewCloseBMCamValues
    /// </summary>
    public unsafe virtual void GetNewCloseBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNewCloseBMCamValues, "BmGame.RDialogueCamera.GetNewCloseBMCamValues");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetNewCloseCamValues;
    /// <summary>
    /// Function: GetNewCloseCamValues
    /// </summary>
    public unsafe virtual void GetNewCloseCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNewCloseCamValues, "BmGame.RDialogueCamera.GetNewCloseCamValues");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanUseNewCloseCam;
    /// <summary>
    /// Function: CanUseNewCloseCam
    /// </summary>
    public unsafe virtual bool CanUseNewCloseCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseNewCloseCam, "BmGame.RDialogueCamera.CanUseNewCloseCam");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMaxGuardCamValues;
    /// <summary>
    /// Function: SetMaxGuardCamValues
    /// </summary>
    public unsafe virtual void SetMaxGuardCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaxGuardCamValues, "BmGame.RDialogueCamera.SetMaxGuardCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMaxGuardCamValues;
    /// <summary>
    /// Function: GetMaxGuardCamValues
    /// </summary>
    public unsafe virtual void GetMaxGuardCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxGuardCamValues, "BmGame.RDialogueCamera.GetMaxGuardCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetMaxGuardBMCamValues;
    /// <summary>
    /// Function: GetMaxGuardBMCamValues
    /// </summary>
    public unsafe virtual void GetMaxGuardBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxGuardBMCamValues, "BmGame.RDialogueCamera.GetMaxGuardBMCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetChairViewNoFovLeftDualCamValues;
    /// <summary>
    /// Function: SetChairViewNoFovLeftDualCamValues
    /// </summary>
    public unsafe virtual void SetChairViewNoFovLeftDualCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChairViewNoFovLeftDualCamValues, "BmGame.RDialogueCamera.SetChairViewNoFovLeftDualCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChairViewNoFovLeftDualCamValues;
    /// <summary>
    /// Function: GetChairViewNoFovLeftDualCamValues
    /// </summary>
    public unsafe virtual void GetChairViewNoFovLeftDualCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChairViewNoFovLeftDualCamValues, "BmGame.RDialogueCamera.GetChairViewNoFovLeftDualCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetChairViewNoFovLeftDualBMCamValues;
    /// <summary>
    /// Function: GetChairViewNoFovLeftDualBMCamValues
    /// </summary>
    public unsafe virtual void GetChairViewNoFovLeftDualBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChairViewNoFovLeftDualBMCamValues, "BmGame.RDialogueCamera.GetChairViewNoFovLeftDualBMCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanUseChairViewNoFovLeftDualCam;
    /// <summary>
    /// Function: CanUseChairViewNoFovLeftDualCam
    /// </summary>
    public unsafe virtual bool CanUseChairViewNoFovLeftDualCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseChairViewNoFovLeftDualCam, "BmGame.RDialogueCamera.CanUseChairViewNoFovLeftDualCam");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetChairViewNoFovRightDualCamValues;
    /// <summary>
    /// Function: SetChairViewNoFovRightDualCamValues
    /// </summary>
    public unsafe virtual void SetChairViewNoFovRightDualCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChairViewNoFovRightDualCamValues, "BmGame.RDialogueCamera.SetChairViewNoFovRightDualCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChairViewNoFovRightDualCamValues;
    /// <summary>
    /// Function: GetChairViewNoFovRightDualCamValues
    /// </summary>
    public unsafe virtual void GetChairViewNoFovRightDualCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChairViewNoFovRightDualCamValues, "BmGame.RDialogueCamera.GetChairViewNoFovRightDualCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetChairViewNoFovRightDualBMCamValues;
    /// <summary>
    /// Function: GetChairViewNoFovRightDualBMCamValues
    /// </summary>
    public unsafe virtual void GetChairViewNoFovRightDualBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChairViewNoFovRightDualBMCamValues, "BmGame.RDialogueCamera.GetChairViewNoFovRightDualBMCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanUseChairViewNoFovRightDualCam;
    /// <summary>
    /// Function: CanUseChairViewNoFovRightDualCam
    /// </summary>
    public unsafe virtual bool CanUseChairViewNoFovRightDualCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseChairViewNoFovRightDualCam, "BmGame.RDialogueCamera.CanUseChairViewNoFovRightDualCam");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetChairViewLeftDualCamValues;
    /// <summary>
    /// Function: SetChairViewLeftDualCamValues
    /// </summary>
    public unsafe virtual void SetChairViewLeftDualCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChairViewLeftDualCamValues, "BmGame.RDialogueCamera.SetChairViewLeftDualCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChairViewLeftDualCamValues;
    /// <summary>
    /// Function: GetChairViewLeftDualCamValues
    /// </summary>
    public unsafe virtual void GetChairViewLeftDualCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChairViewLeftDualCamValues, "BmGame.RDialogueCamera.GetChairViewLeftDualCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetChairViewLeftDualBMCamValues;
    /// <summary>
    /// Function: GetChairViewLeftDualBMCamValues
    /// </summary>
    public unsafe virtual void GetChairViewLeftDualBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChairViewLeftDualBMCamValues, "BmGame.RDialogueCamera.GetChairViewLeftDualBMCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanUseChairViewLeftDualCam;
    /// <summary>
    /// Function: CanUseChairViewLeftDualCam
    /// </summary>
    public unsafe virtual bool CanUseChairViewLeftDualCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseChairViewLeftDualCam, "BmGame.RDialogueCamera.CanUseChairViewLeftDualCam");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetChairViewRightDualCamValues;
    /// <summary>
    /// Function: SetChairViewRightDualCamValues
    /// </summary>
    public unsafe virtual void SetChairViewRightDualCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChairViewRightDualCamValues, "BmGame.RDialogueCamera.SetChairViewRightDualCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChairViewRightDualCamValues;
    /// <summary>
    /// Function: GetChairViewRightDualCamValues
    /// </summary>
    public unsafe virtual void GetChairViewRightDualCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChairViewRightDualCamValues, "BmGame.RDialogueCamera.GetChairViewRightDualCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetChairViewRightDualBMCamValues;
    /// <summary>
    /// Function: GetChairViewRightDualBMCamValues
    /// </summary>
    public unsafe virtual void GetChairViewRightDualBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChairViewRightDualBMCamValues, "BmGame.RDialogueCamera.GetChairViewRightDualBMCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanUseChairViewRightDualCam;
    /// <summary>
    /// Function: CanUseChairViewRightDualCam
    /// </summary>
    public unsafe virtual bool CanUseChairViewRightDualCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseChairViewRightDualCam, "BmGame.RDialogueCamera.CanUseChairViewRightDualCam");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCloseLeftDualCamValues;
    /// <summary>
    /// Function: SetCloseLeftDualCamValues
    /// </summary>
    public unsafe virtual void SetCloseLeftDualCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCloseLeftDualCamValues, "BmGame.RDialogueCamera.SetCloseLeftDualCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCloseLeftDualCamValues;
    /// <summary>
    /// Function: GetCloseLeftDualCamValues
    /// </summary>
    public unsafe virtual void GetCloseLeftDualCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseLeftDualCamValues, "BmGame.RDialogueCamera.GetCloseLeftDualCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetCloseLeftDualBMCamValues;
    /// <summary>
    /// Function: GetCloseLeftDualBMCamValues
    /// </summary>
    public unsafe virtual void GetCloseLeftDualBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseLeftDualBMCamValues, "BmGame.RDialogueCamera.GetCloseLeftDualBMCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanUseCloseLeftDualCam;
    /// <summary>
    /// Function: CanUseCloseLeftDualCam
    /// </summary>
    public unsafe virtual bool CanUseCloseLeftDualCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseCloseLeftDualCam, "BmGame.RDialogueCamera.CanUseCloseLeftDualCam");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCloseRightDualCamValues;
    /// <summary>
    /// Function: SetCloseRightDualCamValues
    /// </summary>
    public unsafe virtual void SetCloseRightDualCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCloseRightDualCamValues, "BmGame.RDialogueCamera.SetCloseRightDualCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCloseRightDualBMCamValues;
    /// <summary>
    /// Function: GetCloseRightDualBMCamValues
    /// </summary>
    public unsafe virtual void GetCloseRightDualBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseRightDualBMCamValues, "BmGame.RDialogueCamera.GetCloseRightDualBMCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetCloseRightDualCamValues;
    /// <summary>
    /// Function: GetCloseRightDualCamValues
    /// </summary>
    public unsafe virtual void GetCloseRightDualCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseRightDualCamValues, "BmGame.RDialogueCamera.GetCloseRightDualCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanUseCloseRightDualCam;
    /// <summary>
    /// Function: CanUseCloseRightDualCam
    /// </summary>
    public unsafe virtual bool CanUseCloseRightDualCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseCloseRightDualCam, "BmGame.RDialogueCamera.CanUseCloseRightDualCam");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetRightSideDualCamValues;
    /// <summary>
    /// Function: SetRightSideDualCamValues
    /// </summary>
    public unsafe virtual void SetRightSideDualCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRightSideDualCamValues, "BmGame.RDialogueCamera.SetRightSideDualCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRightSideDualCamValues;
    /// <summary>
    /// Function: GetRightSideDualCamValues
    /// </summary>
    public unsafe virtual void GetRightSideDualCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRightSideDualCamValues, "BmGame.RDialogueCamera.GetRightSideDualCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetRightSideDualBMCamValues;
    /// <summary>
    /// Function: GetRightSideDualBMCamValues
    /// </summary>
    public unsafe virtual void GetRightSideDualBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRightSideDualBMCamValues, "BmGame.RDialogueCamera.GetRightSideDualBMCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanUseRightSideDualCam;
    /// <summary>
    /// Function: CanUseRightSideDualCam
    /// </summary>
    public unsafe virtual bool CanUseRightSideDualCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseRightSideDualCam, "BmGame.RDialogueCamera.CanUseRightSideDualCam");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetLeftSideDualCamValues;
    /// <summary>
    /// Function: SetLeftSideDualCamValues
    /// </summary>
    public unsafe virtual void SetLeftSideDualCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLeftSideDualCamValues, "BmGame.RDialogueCamera.SetLeftSideDualCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLeftSideDualBMCamValues;
    /// <summary>
    /// Function: GetLeftSideDualBMCamValues
    /// </summary>
    public unsafe virtual void GetLeftSideDualBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeftSideDualBMCamValues, "BmGame.RDialogueCamera.GetLeftSideDualBMCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetLeftSideDualCamValues;
    /// <summary>
    /// Function: GetLeftSideDualCamValues
    /// </summary>
    public unsafe virtual void GetLeftSideDualCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeftSideDualCamValues, "BmGame.RDialogueCamera.GetLeftSideDualCamValues");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanUseLeftSideDualCam;
    /// <summary>
    /// Function: CanUseLeftSideDualCam
    /// </summary>
    public unsafe virtual bool CanUseLeftSideDualCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseLeftSideDualCam, "BmGame.RDialogueCamera.CanUseLeftSideDualCam");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSideRightCamValues;
    /// <summary>
    /// Function: SetSideRightCamValues
    /// </summary>
    public unsafe virtual void SetSideRightCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSideRightCamValues, "BmGame.RDialogueCamera.SetSideRightCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSideRightCamValues;
    /// <summary>
    /// Function: GetSideRightCamValues
    /// </summary>
    public unsafe virtual void GetSideRightCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideRightCamValues, "BmGame.RDialogueCamera.GetSideRightCamValues");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetSideRightBMCamValues;
    /// <summary>
    /// Function: GetSideRightBMCamValues
    /// </summary>
    public unsafe virtual void GetSideRightBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideRightBMCamValues, "BmGame.RDialogueCamera.GetSideRightBMCamValues");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetSideLeftCamValues;
    /// <summary>
    /// Function: SetSideLeftCamValues
    /// </summary>
    public unsafe virtual void SetSideLeftCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSideLeftCamValues, "BmGame.RDialogueCamera.SetSideLeftCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSideLeftBMCamValues;
    /// <summary>
    /// Function: GetSideLeftBMCamValues
    /// </summary>
    public unsafe virtual void GetSideLeftBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideLeftBMCamValues, "BmGame.RDialogueCamera.GetSideLeftBMCamValues");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetSideLeftCamValues;
    /// <summary>
    /// Function: GetSideLeftCamValues
    /// </summary>
    public unsafe virtual void GetSideLeftCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideLeftCamValues, "BmGame.RDialogueCamera.GetSideLeftCamValues");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetCloseLeftCamValues;
    /// <summary>
    /// Function: SetCloseLeftCamValues
    /// </summary>
    public unsafe virtual void SetCloseLeftCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCloseLeftCamValues, "BmGame.RDialogueCamera.SetCloseLeftCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCloseLeftCamValues;
    /// <summary>
    /// Function: GetCloseLeftCamValues
    /// </summary>
    public unsafe virtual void GetCloseLeftCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseLeftCamValues, "BmGame.RDialogueCamera.GetCloseLeftCamValues");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetCloseLeftBMCamValues;
    /// <summary>
    /// Function: GetCloseLeftBMCamValues
    /// </summary>
    public unsafe virtual void GetCloseLeftBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseLeftBMCamValues, "BmGame.RDialogueCamera.GetCloseLeftBMCamValues");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetCloseRightCamValues;
    /// <summary>
    /// Function: SetCloseRightCamValues
    /// </summary>
    public unsafe virtual void SetCloseRightCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCloseRightCamValues, "BmGame.RDialogueCamera.SetCloseRightCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCloseRightBMCamValues;
    /// <summary>
    /// Function: GetCloseRightBMCamValues
    /// </summary>
    public unsafe virtual void GetCloseRightBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseRightBMCamValues, "BmGame.RDialogueCamera.GetCloseRightBMCamValues");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetCloseRightCamValues;
    /// <summary>
    /// Function: GetCloseRightCamValues
    /// </summary>
    public unsafe virtual void GetCloseRightCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseRightCamValues, "BmGame.RDialogueCamera.GetCloseRightCamValues");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetRightSideCamValues;
    /// <summary>
    /// Function: SetRightSideCamValues
    /// </summary>
    public unsafe virtual void SetRightSideCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRightSideCamValues, "BmGame.RDialogueCamera.SetRightSideCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRightSideCamValues;
    /// <summary>
    /// Function: GetRightSideCamValues
    /// </summary>
    public unsafe virtual void GetRightSideCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRightSideCamValues, "BmGame.RDialogueCamera.GetRightSideCamValues");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetRightSideBMCamValues;
    /// <summary>
    /// Function: GetRightSideBMCamValues
    /// </summary>
    public unsafe virtual void GetRightSideBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRightSideBMCamValues, "BmGame.RDialogueCamera.GetRightSideBMCamValues");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetLeftSideCamValues;
    /// <summary>
    /// Function: SetLeftSideCamValues
    /// </summary>
    public unsafe virtual void SetLeftSideCamValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLeftSideCamValues, "BmGame.RDialogueCamera.SetLeftSideCamValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLeftSideBMCamValues;
    /// <summary>
    /// Function: GetLeftSideBMCamValues
    /// </summary>
    public unsafe virtual void GetLeftSideBMCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeftSideBMCamValues, "BmGame.RDialogueCamera.GetLeftSideBMCamValues");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetLeftSideCamValues;
    /// <summary>
    /// Function: GetLeftSideCamValues
    /// </summary>
    public unsafe virtual void GetLeftSideCamValues(out System.Numerics.Vector3 Loc, out System.Numerics.Vector3 Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeftSideCamValues, "BmGame.RDialogueCamera.GetLeftSideCamValues");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_LookAround;
    /// <summary>
    /// Function: LookAround
    /// </summary>
    public unsafe virtual void LookAround(float DeltaTime, BmSDK.Rotator LookInput)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAround, "BmGame.RDialogueCamera.LookAround");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookInput, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RDialogueCamera.Tick");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCamera;
    /// <summary>
    /// Function: SetCamera
    /// </summary>
    public unsafe virtual void SetCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCamera, "BmGame.RDialogueCamera.SetCamera");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCameraValues;
    /// <summary>
    /// Function: SetCameraValues
    /// </summary>
    public unsafe virtual void SetCameraValues(int AllowedCams, bool bNotAllowedToTouchUp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraValues, "BmGame.RDialogueCamera.SetCameraValues");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowedCams, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNotAllowedToTouchUp, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickDialogueCamera;
    /// <summary>
    /// Function: PickDialogueCamera
    /// </summary>
    public unsafe virtual void PickDialogueCamera(bool IsBatmanTalking, bool OnlyShowtalker, bool bNotAllowedToTouchUp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickDialogueCamera, "BmGame.RDialogueCamera.PickDialogueCamera");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsBatmanTalking, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyShowtalker, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNotAllowedToTouchUp, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsNotShowcase;
    /// <summary>
    /// Function: IsNotShowcase
    /// </summary>
    public unsafe virtual bool IsNotShowcase()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNotShowcase, "BmGame.RDialogueCamera.IsNotShowcase");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TestMovement;
    /// <summary>
    /// Function: TestMovement
    /// </summary>
    public unsafe virtual bool TestMovement(System.Numerics.Vector3 NewLoc, System.Numerics.Vector3 lookDest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestMovement, "BmGame.RDialogueCamera.TestMovement");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lookDest, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CameraAnimationTriggerCallback;
    /// <summary>
    /// Function: CameraAnimationTriggerCallback
    /// </summary>
    public unsafe virtual void CameraAnimationTriggerCallback(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CameraAnimationTriggerCallback, "BmGame.RDialogueCamera.CameraAnimationTriggerCallback");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Stop;
    /// <summary>
    /// Function: Stop
    /// </summary>
    public unsafe virtual void Stop(float timeToBlend)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stop, "BmGame.RDialogueCamera.Stop");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeToBlend, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise(BmSDK.BmGame.RPawn Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RDialogueCamera.Initialise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayDebug, "BmGame.RDialogueCamera.DisplayDebug");
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

    private static BmSDK.Function __fn_ForensicsDof;
    /// <summary>
    /// Function: ForensicsDof
    /// </summary>
    public unsafe virtual void ForensicsDof(bool On)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForensicsDof, "BmGame.RDialogueCamera.ForensicsDof");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: CurrentTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCharacter CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// FloatProperty: MinDistanceToTarget
    /// </summary>
    public unsafe float MinDistanceToTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// StructProperty: CameraLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 920);

    /// <summary>
    /// ComponentProperty: BoneToFollow
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BoneToFollow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// NameProperty: BoneName
    /// </summary>
    public unsafe BmSDK.FName BoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StructProperty: CameraTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 944);

    /// <summary>
    /// StructProperty: CameraRotationOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraRotationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 956);

    /// <summary>
    /// FloatProperty: CameraFov
    /// </summary>
    public unsafe float CameraFov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// StructProperty: ExtraCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ExtraCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 972);

    /// <summary>
    /// StructProperty: DefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator DefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 984);

    /// <summary>
    /// FloatProperty: LookModeScale
    /// </summary>
    public unsafe float LookModeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: LookSpringBack
    /// </summary>
    public unsafe float LookSpringBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: DofStruct
    /// </summary>
    public unsafe ref BmSDK.BmGame.RDOFManager.FDofStruct DofStruct
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RDOFManager.FDofStruct>(Ptr + 1004);

    /// <summary>
    /// StructProperty: ForensicsDofStruct
    /// </summary>
    public unsafe ref BmSDK.BmGame.RDOFManager.FDofStruct ForensicsDofStruct
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RDOFManager.FDofStruct>(Ptr + 1068);

    /// <summary>
    /// IntProperty: PickedCamera
    /// </summary>
    public unsafe int PickedCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bIsBatmanTalking
    /// </summary>
    public unsafe bool bIsBatmanTalking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: bOnlyShowTalker
    /// </summary>
    public unsafe bool bOnlyShowTalker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: bPickedLeftSide
    /// </summary>
    public unsafe bool bPickedLeftSide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: bPickedClose
    /// </summary>
    public unsafe bool bPickedClose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: bHasPickedDistance
    /// </summary>
    public unsafe bool bHasPickedDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: OldBatmanZ
    /// </summary>
    public unsafe float OldBatmanZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: LightTimer
    /// </summary>
    public unsafe float LightTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: LightMultiplier
    /// </summary>
    public unsafe float LightMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }
}
