namespace BmSDK.Framework;

/// <summary>
/// Marks a static function as a global detour to a target method on a specified type.
/// The detour applies globally and unconditionally to every instance of the target type.
/// BmSDK performs registration automatically when this attribute is present.
/// </summary>
/// <remarks>The method being marked must be static. If the target UFunction is not static
/// the detour must take an artificial self parameter  of the <see cref="TargetType"/> as the first argument.
/// The return type and the parameter types that follow (the function signature) must match the actual method exactly
/// (both types and order). Names and the method's access modifier are irrelevant.
/// Multiple RedirectAttributes are allowed on the same function as long as the target type and/or (less commonly)
/// target UFunction is altered. In that case, multiple, independent redirects will be registered.</remarks>
/// <example>
/// [Redirect(typeof(RPawnPlayer), nameof(RPawnPlayer.ExperienceAwarded))]
/// private static void ExperienceAwardedRedirect(RPawnPlayer self, int xp, int teethXp)
/// {
///     Debug.Log("Experiencing less...");
///     self.ExperienceAwarded(xp / 10, teethXp / 10);
/// }
/// </example>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
public sealed class RedirectAttribute : Attribute
{
    /// <param name="targetType">The type that contains the method of which calls are redirected.
    /// Use <see langword="typeof"/> to get it safely.</param>
    /// <param name="targetMethod">The name of the method on the target type to which calls are redirected.
    /// Use <see langword="nameof"/> to get it safely.</param>
    public RedirectAttribute(Type targetType, string targetMethod)
    {
        TargetType = targetType;
        TargetMethod = targetMethod;
    }

    /// <summary>
    /// Redirects a UFunction by its path, for classes BmSDK has no managed type for (a DLC's own classes, say).
    /// The detour's self parameter is the nearest managed type the object is wrapped as, and
    /// <see cref="Redirects.RunOriginal()"/> runs the game's version from inside the detour.
    /// </summary>
    /// <param name="functionPath">The function's path as the game names it, "BmScript.MDualHandgunsRh:AttachToHand".</param>
    /// <param name="selfType">The managed type the detour takes as self: the closest wrapped base class of the function's class.</param>
    public RedirectAttribute(string functionPath, Type selfType)
    {
        FunctionPath = functionPath;
        TargetType = selfType;
        TargetMethod = functionPath[(functionPath.LastIndexOf(':') + 1)..];
    }

    public Type TargetType { get; }
    public string TargetMethod { get; }

    /// <summary>The exact function path to redirect, when given instead of a managed type and method.</summary>
    public string? FunctionPath { get; }

    /// <summary>
    /// Whether the redirect should apply to <see cref="TargetType"/> only or its children too.
    /// It's important to note that a redirect overrides a specific definition of a UFunction.
    /// If the child class overrides the target function, this option has no effect on that
    /// particular child type.
    /// </summary>
    public bool AllowSubtypes { get; init; } = true;

    /// <summary>
    /// BmSDK-AO addition: also redirect the subclass overrides of the target function (and the copies UnrealScript
    /// makes of it inside states). Inside the redirect, calling the function runs the override that was called.
    /// Off by default, so a redirect keeps covering only its own definition, as in upstream BmSDK.
    /// </summary>
    public bool IncludeOverrides { get; init; }
}
