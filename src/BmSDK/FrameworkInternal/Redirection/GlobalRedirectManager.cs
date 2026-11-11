using System.Reflection;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// A class managing the creation, retrieval, execution and deletion of detours to in-game functions.
/// The redirectors apply globally and unconditionally to all instances.
/// DO NOT INSTANTIATE! USE <see cref="RedirectManager.Global"/> INSTEAD.
/// </summary>
internal sealed class GlobalRedirectManager(BindingFlags genericRedirSearchFlags)
{
    private readonly BindingFlags _globalRedirSearchFlags =
        BindingFlags.Static | genericRedirSearchFlags;

    /// <summary>
    /// Maps declaring function paths to GlobalRedirectorInfo objects which contain
    /// the target class and the delegate of the detour.
    /// </summary>
    private readonly Dictionary<string, List<GlobalRedirectorInfo>> _globalRedirsDict = new(UENames.Comparer);

    /// <summary>
    /// Registers all functions marked with a <see cref="RedirectAttribute"/> in a given assembly.
    /// </summary>
    public void RegisterRedirectors(Assembly asm)
    {
        foreach (var type in asm.GetTypes())
        {
            foreach (var func in type.GetMethods(_globalRedirSearchFlags))
            {
                foreach (var redirAttr in func.GetCustomAttributes<RedirectAttribute>())
                {
                    RegisterRedirector(redirAttr, func);
                }
            }
        }
    }

    /// <summary>
    /// Registers a delegate as a redirector for the given in-game function.
    /// </summary>
    /// <param name="redirAttr">Attribute containing metadata for registration</param>
    /// <param name="redirectMi">The MethodInfo of the custom detour</param>
    /// <exception cref="ArgumentException">Thrown if the target class does not inherit GameObject.
    /// Only methods of in-game classes may be overriden.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the exact redirect method,
    /// has been attached to the same function path again.</exception>
    private void RegisterRedirector(RedirectAttribute redirAttr, MethodInfo redirectMi)
    {
        var targetType = redirAttr.TargetType;

        // Prevent creation of invalid redirects
        if (!targetType.IsAssignableTo(typeof(GameObject)))
        {
            throw new ArgumentException(
                $"{targetType.FullName} is not a managed type of"
                    + $"an in-game unmanaged type and cannot be redirected."
            );
        }

        // BmSDK-AO: the redirector must take the function's parameters. The compiler can't tell when the call inside it
        // leaves out parameters that have a default value (Ultimate UI on AO Online: SetToolTip(Text) where Online has
        // SetToolTip(Text, Colour)), and it then threw on every call. Such a redirector is not registered: one clear
        // warning instead of an error per call.
        if (redirAttr.FunctionPath == null && !ParametersMatch(targetType, redirAttr.TargetMethod, redirectMi, out var expected))
        {
            Debug.LogWarning(
                $"{redirectMi.DeclaringType?.FullName}.{redirectMi.Name}: redirect of {targetType.Name}.{redirAttr.TargetMethod} "
                    + $"takes {redirectMi.GetParameters().Length} parameter(s), the function needs {expected}: not registered"
            );
            return;
        }

        // Get the full path of the function (as originally declared), unless the attribute names it outright.
        var declaringFuncPath = redirAttr.FunctionPath ?? StaticInit.GetDeclaringFuncPath(targetType, redirAttr.TargetMethod);

        // Store the redirect for later use.
        var redirInfo = new GlobalRedirectorInfo(
            targetType,
            redirAttr.AllowSubtypes,
            redirectMi,
            redirectMi.DeclaringType!.Assembly
        )
        {
            IncludeOverrides = redirAttr.IncludeOverrides,
        };

        // Add new redirect to the target function's redirect list
        if (_globalRedirsDict.TryGetValue(declaringFuncPath, out var redirects))
        {
            // Prevent the same managed function from being used on the same target type
            // as that would likely be a bug
            if (
                redirects.Any(r =>
                    r.RedirectMethod == redirInfo.RedirectMethod
                    && r.TargetType == redirInfo.TargetType
                )
            )
            {
                throw new InvalidOperationException(
                    $"{redirInfo} has already been registered once on {declaringFuncPath}!"
                );
            }
        }
        else
        {
            redirects = [];
            _globalRedirsDict[declaringFuncPath] = redirects;
        }

        RedirectManager.QueueConfigureFunction(declaringFuncPath);
        redirects.Add(redirInfo);
        RedirectManager.BumpGeneration();
    }

    // The generated wrappers of that name take one parameter per parameter of the in-game function; an instance
    // redirector also takes the object first. Any wrapper (or hand-written overload) of the right size counts; with no
    // method of that name there is nothing to check against.
    private static bool ParametersMatch(Type targetType, string funcName, MethodInfo redirectMi, out string expected)
    {
        var candidates = targetType
            .GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(m => m.Name == funcName)
            .ToArray();
        var given = redirectMi.GetParameters().Length;
        expected = string.Join(" or ", candidates.Select(m => (m.GetParameters().Length + (m.IsStatic ? 0 : 1)).ToString()).Distinct());
        return candidates.Length == 0 || candidates.Any(m => m.GetParameters().Length + (m.IsStatic ? 0 : 1) == given);
    }

    /// <summary>Whether any global redirect targets the given function path.</summary>
    public bool HasRedirects(string funcPath) => _globalRedirsDict.ContainsKey(funcPath);

    /// <summary>
    /// Gets any redirections for the given function path if it applies to the given GameObject.
    /// </summary>
    /// <returns>Objects representing the registered global redirects.
    /// The collection may be empty if there are no redircts.</returns>
    public IEnumerable<GlobalRedirectorInfo> GetRedirectors(GameObject obj, string funcPath)
    {
        if (!_globalRedirsDict.TryGetValue(funcPath, out var infos))
        {
            return [];
        }

        var objType = obj.GetType();

        return infos.Where(info =>
        {
            if (info.AllowSubtypes)
            {
                return objType.IsAssignableTo(info.TargetType);
            }
            else
            {
                return objType == info.TargetType;
            }
        });
    }

    /// <summary>
    /// BmSDK-AO: redirects with <see cref="RedirectAttribute.IncludeOverrides"/> registered on a function that the
    /// running one overrides (<paramref name="superPaths"/>, nearest first). The nearest match wins.
    /// </summary>
    public IEnumerable<GlobalRedirectorInfo> GetOverrideRedirectors(GameObject obj, string[] superPaths)
    {
        foreach (var path in superPaths)
        {
            var found = GetRedirectors(obj, path).Where(info => info.IncludeOverrides).ToArray();
            if (found.Length > 0)
            {
                return found;
            }
        }
        return [];
    }

    /// <summary>
    /// Executes a global redirect from its record instance and the data available in UObject::ProcessInternal().
    /// </summary>
    public unsafe void ExecuteRedirector(
        GlobalRedirectorInfo redirInfo,
        GameObject selfObj,
        Function funcObj,
        FFrame* stackPtr,
        IntPtr Result
    )
    {
        var redirMethod = redirInfo.RedirectMethod;

        // Marshal args, add self as first arg if needed.
        var values = stackPtr->ParamsToManaged(redirInfo.GetParamTypes(funcObj));
        object?[] args;
        if (funcObj.IsStatic)
        {
            args = values;
        }
        else
        {
            args = new object?[values.Length + 1];
            args[0] = selfObj;
            Array.Copy(values, 0, args, 1, values.Length);
        }

        // Execute detour
        var result = redirInfo.Invoker.Invoke(obj: null, arguments: args);

        // Hand ref/out arguments back to the caller
        stackPtr->WriteBackParams(redirInfo.GetParamTypes(funcObj), args, funcObj.IsStatic ? 0 : 1);

        // Marshal result back (if non-void)
        if (result != null && redirMethod.ReturnType != typeof(void))
        {
            MarshalUtil.ToUnmanaged(result, Result, redirMethod.ReturnType);
        }
    }

    /// <summary>
    /// Unregisters all global redirectors originating from the specified assembly.
    /// </summary>
    public void UnregisterRedirectors(Assembly asm)
    {
        var emptyKeys = new List<string>();
        foreach (var (funcPath, redirects) in _globalRedirsDict)
        {
            redirects.RemoveAll(r => r.SourceAssembly == asm);
            if (redirects.Count == 0)
            {
                emptyKeys.Add(funcPath);
            }
        }

        foreach (var key in emptyKeys)
        {
            _globalRedirsDict.Remove(key);
        }

        RedirectManager.BumpGeneration();
    }

    /// <summary>
    /// Clears the backing redirector dictionary, therefore, uninstalling all global redirects.
    /// </summary>
    public void UnregisterAll()
    {
        _globalRedirsDict.Clear();
        RedirectManager.BumpGeneration();
    }
}
