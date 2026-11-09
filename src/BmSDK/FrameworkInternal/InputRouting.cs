using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Swallows input by its engine name ("MouseX", "MouseScrollUp", "LeftMouseButton", ...), which is
/// how axes and the wheel can be kept from the game: they never pass through the window messages
/// <see cref="InputManager"/> filters.
/// </summary>
/// <remarks>
/// The viewport client routes every key and axis event through its HandleInputKey/HandleInputAxis
/// delegates before the player's input sees them, and an event the delegate reports as handled goes
/// no further. The engine only calls a delegate that is bound, so while anything is swallowed by name
/// BmSDK binds both delegates to the viewport client's own (empty) implementations and redirects
/// those. A binding the game made itself is never replaced.
/// </remarks>
internal static class InputRouting
{
    /// <summary>Name indices of the swallowed inputs.</summary>
    private static readonly HashSet<int> s_swallowed = [];

    /// <summary>Keys whose press was dropped, so their release is dropped too (see <see cref="InputManager"/>).</summary>
    private static readonly HashSet<int> s_pressSwallowed = [];

    private static bool s_bound;
    private static IntPtr s_boundViewport;
    private static int s_keyOffset = -1;
    private static int s_axisOffset = -1;
    private static FName s_keyFunc;
    private static FName s_axisFunc;

    public static bool IsSwallowed(FName name) => s_swallowed.Contains(name.Index);

    public static void SetSwallowed(FName name, bool swallow)
    {
        if (name.Index == 0)
        {
            return;
        }

        if (swallow)
        {
            s_swallowed.Add(name.Index);
        }
        else
        {
            s_swallowed.Remove(name.Index);
        }
    }

    public static void UnswallowAll() => s_swallowed.Clear();

    /// <summary>The window lost focus: no release will come for a press that was dropped.</summary>
    public static void OnFocusLost() => s_pressSwallowed.Clear();

    /// <summary>Keeps the delegates bound while anything is swallowed, and unbound otherwise.</summary>
    public static void Tick()
    {
        var wantBound = s_swallowed.Count > 0;
        if (wantBound == s_bound && (!s_bound || IsStillBound()))
        {
            return;
        }

        if (wantBound)
        {
            Bind();
        }
        else
        {
            Unbind();
        }
    }

    private static unsafe void Bind()
    {
        if (!Game.TryGetGameViewportClient(out var viewport) || !ResolveOffsets(viewport))
        {
            return;
        }

        // Leave a binding the game made alone: our swallowing then waits until it is released.
        if (ReadObject(viewport.Ptr, s_keyOffset) != 0 && ReadObject(viewport.Ptr, s_keyOffset) != viewport.Ptr)
        {
            return;
        }

        if (ReadObject(viewport.Ptr, s_axisOffset) != 0 && ReadObject(viewport.Ptr, s_axisOffset) != viewport.Ptr)
        {
            return;
        }

        WriteDelegate(viewport.Ptr, s_keyOffset, viewport.Ptr, s_keyFunc);
        WriteDelegate(viewport.Ptr, s_axisOffset, viewport.Ptr, s_axisFunc);
        s_bound = true;
        s_boundViewport = viewport.Ptr;
    }

    private static void Unbind()
    {
        if (s_bound && s_boundViewport != 0 && IsStillBound())
        {
            WriteDelegate(s_boundViewport, s_keyOffset, 0, FName.None);
            WriteDelegate(s_boundViewport, s_axisOffset, 0, FName.None);
        }

        s_bound = false;
        s_boundViewport = 0;
        s_pressSwallowed.Clear();
    }

    /// <summary>Whether the viewport client we bound still exists and still points at itself.</summary>
    private static bool IsStillBound()
    {
        if (!Game.TryGetGameViewportClient(out var viewport) || viewport.Ptr != s_boundViewport)
        {
            return false;
        }

        return ReadObject(viewport.Ptr, s_keyOffset) == viewport.Ptr
            && ReadObject(viewport.Ptr, s_axisOffset) == viewport.Ptr;
    }

    private static bool ResolveOffsets(GameViewportClient viewport)
    {
        if (s_keyOffset >= 0)
        {
            return true;
        }

        foreach (var cls in viewport.Class.EnumerateSupersAndSelf())
        {
            foreach (var field in cls.EnumerateFields())
            {
                if (field is not Property prop)
                {
                    continue;
                }

                var name = prop.Name.ToString();
                if (name == "__HandleInputKey__Delegate")
                {
                    s_keyOffset = prop.Offset;
                }
                else if (name == "__HandleInputAxis__Delegate")
                {
                    s_axisOffset = prop.Offset;
                }
            }
        }

        if (s_keyOffset < 0 || s_axisOffset < 0)
        {
            Debug.LogWarning("Input routing: the viewport client has no HandleInputKey/HandleInputAxis delegates; swallowing by name is off.");
            s_keyOffset = s_axisOffset = int.MaxValue;
            return false;
        }

        s_keyFunc = new FName("HandleInputKey");
        s_axisFunc = new FName("HandleInputAxis");
        return true;
    }

    // An FScriptDelegate is the bound object followed by the function name (BmSDK-AO: 32-bit, so the name is at +4).
    private static IntPtr ReadObject(IntPtr obj, int offset) => Marshal.ReadIntPtr(obj + offset);

    private static unsafe void WriteDelegate(IntPtr obj, int offset, IntPtr target, FName func)
    {
        Marshal.WriteIntPtr(obj + offset, target);
        *(FName*)(obj + offset + IntPtr.Size) = func;
    }

    // Both redirects call the original when they don't swallow, so a mod's own redirect of these
    // delegates still runs after BmSDK's.

    [Redirect(typeof(GameViewportClient), nameof(GameViewportClient.HandleInputAxis))]
    private static bool HandleInputAxisRedirect(GameViewportClient self, int controllerId, FName key, float delta, float deltaTime, bool gamepad)
    {
        return s_swallowed.Contains(key.Index)
            || self.HandleInputAxis(controllerId, key, delta, deltaTime, gamepad);
    }

    [Redirect(typeof(GameViewportClient), nameof(GameViewportClient.HandleInputKey))]
    private static bool HandleInputKeyRedirect(GameViewportClient self, int controllerId, FName key, GameObject.EInputEvent eventType, float amountDepressed, bool gamepad)
    {
        var swallow = false;
        switch (eventType)
        {
            case GameObject.EInputEvent.IE_Pressed:
            case GameObject.EInputEvent.IE_DoubleClick:
                // The release of a press the game saw must reach it too, or the key stays down in the game.
                if (s_swallowed.Contains(key.Index))
                {
                    s_pressSwallowed.Add(key.Index);
                    swallow = true;
                }
                else
                {
                    s_pressSwallowed.Remove(key.Index);
                }
                break;

            case GameObject.EInputEvent.IE_Released:
                swallow = s_pressSwallowed.Remove(key.Index);
                break;

            default:
                swallow = s_swallowed.Contains(key.Index);
                break;
        }

        return swallow || self.HandleInputKey(controllerId, key, eventType, amountDepressed, gamepad);
    }
}
