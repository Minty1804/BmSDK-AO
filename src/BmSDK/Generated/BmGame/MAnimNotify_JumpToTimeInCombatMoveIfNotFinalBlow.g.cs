#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow<br/>
/// (size = 44)
/// (flags = 167784594)
/// </summary>
public partial class MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow.
    /// </summary>
    public static MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow DefaultObject => (MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow)StaticClass().DefaultObject;

    internal MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow() { }

    /// <summary>
    /// Constructs a new MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow
    /// </summary>
    public MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_JumpToTimeInCombatMoveIfNotFinalBlow>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
