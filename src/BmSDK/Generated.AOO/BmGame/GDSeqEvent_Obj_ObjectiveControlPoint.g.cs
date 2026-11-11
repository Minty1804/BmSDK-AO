#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDSeqEvent_Obj_ObjectiveControlPoint<br/>
/// (size = 232)
/// (flags = 32786)
/// </summary>
public partial class GDSeqEvent_Obj_ObjectiveControlPoint : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDSeqEvent_Obj_ObjectiveControlPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDSeqEvent_Obj_ObjectiveControlPoint.
    /// </summary>
    public static GDSeqEvent_Obj_ObjectiveControlPoint DefaultObject => (GDSeqEvent_Obj_ObjectiveControlPoint)StaticClass().DefaultObject;

    internal GDSeqEvent_Obj_ObjectiveControlPoint() { }

    /// <summary>
    /// Constructs a new GDSeqEvent_Obj_ObjectiveControlPoint
    /// </summary>
    public GDSeqEvent_Obj_ObjectiveControlPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDSeqEvent_Obj_ObjectiveControlPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDSeqEvent_Obj_ObjectiveControlPoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDSeqEvent_Obj_ObjectiveControlPoint>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSeqEvent_Obj_ObjectiveControlPoint>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDSeqEvent_Obj_ObjectiveControlPoint>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSeqEvent_Obj_ObjectiveControlPoint>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSeqEvent_Obj_ObjectiveControlPoint>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSeqEvent_Obj_ObjectiveControlPoint>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDSeqEvent_Obj_ObjectiveControlPoint>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSeqEvent_Obj_ObjectiveControlPoint>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmGame.GDSeqEvent_Obj_ObjectiveControlPoint.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: ObjectiveControlPointKismetOutputs
    /// </summary>
    public enum ObjectiveControlPointKismetOutputs : byte
    {
        CPT_ActivateObjective = 0,
        CPT_NextObjective = 1,
        CPT_EnableHackBox = 2,
        CPT_DisableHackBox = 3,
        CPT_StoppedCapture = 4,
        CPT_JokerStartCapture = 5,
        CPT_BaneStartCapture = 6,
        CPT_FullyCaptured = 7,
        CPT_Scrambled = 8,
        CPT_JokerStartReverseCapture = 9,
        CPT_BaneStartReverseCapture = 10,
        CPT_ControlPointLost = 11,
        CPT_ControlPointAtZero = 12,
        CPT_CaptureHeartbeat = 13,
        CPT_MAX = 14,
    }
}
