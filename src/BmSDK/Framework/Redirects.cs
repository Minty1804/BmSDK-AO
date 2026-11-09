using BmSDK.Framework.Redirection;

namespace BmSDK.Framework;

/// <summary>
/// What a redirect may ask about the call it is handling.
/// </summary>
public static class Redirects
{
    /// <summary>
    /// Runs the game's own version of the function being redirected, with the caller's arguments. For a redirect
    /// declared with a managed type, calling the method on <c>self</c> does this already; a redirect declared by
    /// function path has no managed method to call, so it uses this instead. Returns false outside a redirect, or
    /// when the original has already run for this call.
    /// </summary>
    public static unsafe bool RunOriginal()
    {
        var call = RedirectManager.Current;
        if (call is null || call.OriginalRan || call.Stack == IntPtr.Zero)
        {
            return false;
        }

        call.RunOriginal((FFrame*)call.Stack, call.Result);
        return true;
    }

    /// <summary>
    /// <see cref="RunOriginal()"/> for a function with a return value: the game's result, which the redirect
    /// should return itself to pass it on. Throws outside a redirect or when the original has already run.
    /// </summary>
    public static unsafe T RunOriginal<T>()
    {
        var call = RedirectManager.Current;
        if (call is null || call.Stack == IntPtr.Zero)
        {
            throw new InvalidOperationException("Not inside a redirect");
        }

        if (call.OriginalRan)
        {
            throw new InvalidOperationException("The original has already run for this call");
        }

        call.RunOriginal((FFrame*)call.Stack, call.Result);
        return MarshalUtil.ToManaged<T>(call.Result);
    }
}
