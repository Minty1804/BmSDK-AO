#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MStealthTakedownStage_DeadshotGrabFromCrouchSuccess<br/>
/// (size = 1228)
/// (flags = 8388626)
/// </summary>
public partial class MStealthTakedownStage_DeadshotGrabFromCrouchSuccess : BmSDK.BmGame.RStealthTakeDownStage_GrabFromCrouchSuccess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MStealthTakedownStage_DeadshotGrabFromCrouchSuccess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MStealthTakedownStage_DeadshotGrabFromCrouchSuccess.
    /// </summary>
    public static MStealthTakedownStage_DeadshotGrabFromCrouchSuccess DefaultObject => (MStealthTakedownStage_DeadshotGrabFromCrouchSuccess)StaticClass().DefaultObject;

    internal MStealthTakedownStage_DeadshotGrabFromCrouchSuccess() { }

    /// <summary>
    /// Constructs a new MStealthTakedownStage_DeadshotGrabFromCrouchSuccess
    /// </summary>
    public MStealthTakedownStage_DeadshotGrabFromCrouchSuccess(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MStealthTakedownStage_DeadshotGrabFromCrouchSuccess(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStealthTakedownStage_DeadshotGrabFromCrouchSuccess>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakedownStage_DeadshotGrabFromCrouchSuccess>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStealthTakedownStage_DeadshotGrabFromCrouchSuccess>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakedownStage_DeadshotGrabFromCrouchSuccess>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakedownStage_DeadshotGrabFromCrouchSuccess>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakedownStage_DeadshotGrabFromCrouchSuccess>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStealthTakedownStage_DeadshotGrabFromCrouchSuccess>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakedownStage_DeadshotGrabFromCrouchSuccess>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
