global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using BmSDK.Framework.Redirection;
using MoreLinq;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK.Framework;

internal static partial class Loader
{
    private const string InitFuncName = "Engine.GameInfo:InitGame";
    private const string EnterMenuFuncName = "GFxUI.GFxMoviePlayer:Init";
    private const string EnterGameFuncName = "BmGame.RPlayerController:ClientReady";
    private const string TickFuncName = "BmGame.RGameInfo:Tick";
    private const string DLCScanCompleteFuncName =
        "Engine.DownloadableContentManager:RefreshDLCEnumComplete";

    private static GameFunctions.EngineTickDelegate? _EngineTickDetourBase = null;
    private static GameFunctions.ProcessInternalDelegate? _ProcessInternalDetourBase = null;
    private static GameFunctions.ProcessDeferredMessageDelegate? _ProcessDeferredMessageDetourBase =
        null;
    private static GameFunctions.AddObjectDelegate? _AddObjectDelegateDetourBase = null;
    private static GameFunctions.ConditionalPostLoadDelegate? _ConditionalPostLoadDetourBase = null;
    private static GameFunctions.ConditionalDestroyDelegate? _ConditionalDestroyDetourBase = null;

    /// <summary>
    /// Main .NET entry point, called from BmSDK.Host.
    /// This is done when FEngineLoop::PreInit() is executed.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void GuardedDllMain() => Debug.RunWithSender("Loader", () => RunGuarded(DllMain));

    private static void DllMain()
    {
        CrashContext.Init(); // BmSDK-AO: names the running script in BmSDK.Host.log on a native crash
        EngineSynchronizationContext.InitOnThread();

        Debug.InitFileLog();
        Debug.Log($"Detected {GameDefine.Current.Name} build");

#if BMSDK_AOO
        // This BmSDK.dll carries AO Online's classes and object layout: nothing else can run it
        if (GameDefine.Current is not GameDefineAOOnline)
        {
            Debug.LogError("This BmSDK.dll is the Arkham Origins Online build; install the SinglePlayer one here");
            return;
        }
#endif

        // Arkham Origins port: run only what the known addresses allow (Loader.AO.cs)
        if (!GameDefine.Current.SupportsFullRuntime)
        {
            BringUpMain();
            return;
        }

        // Perform static init (before engine load)
        StaticInit.StaticInitClasses();

        // Find/load scripts
        ScriptManager.Init();

        // Register BmSDK's internal redirectors.
        RedirectManager.Global.RegisterRedirectors(typeof(Loader).Assembly);

        // Create function detours
        _EngineTickDetourBase = DetourUtil.NewDetour<GameFunctions.EngineTickDelegate>(
            GameDefine.Current.EngineTick,
            EngineTickDetour
        );

        _ProcessInternalDetourBase = DetourUtil.NewDetour<GameFunctions.ProcessInternalDelegate>(
            GameDefine.Current.ProcessInternal,
            ProcessInternalDetour
        );

        _ProcessDeferredMessageDetourBase =
            DetourUtil.NewDetour<GameFunctions.ProcessDeferredMessageDelegate>(
                GameDefine.Current.ProcessDeferredMessage,
                ProcessDeferredMessageDetour
            );

        _AddObjectDelegateDetourBase = DetourUtil.NewDetour<GameFunctions.AddObjectDelegate>(
            GameDefine.Current.AddObject,
            AddObjectDetour
        );

        _ConditionalPostLoadDetourBase =
            DetourUtil.NewDetour<GameFunctions.ConditionalPostLoadDelegate>(
                GameDefine.Current.ConditionalPostLoad,
                ConditionalPostLoadDetour
            );

        _ConditionalDestroyDetourBase =
            DetourUtil.NewDetour<GameFunctions.ConditionalDestroyDelegate>(
                GameDefine.Current.ConditionalDestroy,
                ConditionalDestroyDetour
            );
    }

    private static IntPtr EngineTickDetour(IntPtr self)
    {
        // Run the scheduled callbacks
        EngineSynchronizationContext.Instance.ExecutePending();

        // Key presses are delivered from here rather than the world tick, so they still arrive while
        // the game is paused or in a cutscene. Scripts hear about them once they have run Main().
        try
        {
            InputManager.Tick(dispatch: s_hasGameInited);
            InputRouting.Tick();
        }
        catch (Exception ex)
        {
            Abort(ex);
        }

        // BmSDK-AO: options menu, also while the game is paused (RGameInfo.Tick stops then)
        RunTracked(s_optionsTick, OptionsManager.EngineTick);
        RunTracked(s_modScreenTick, PauseModScreen.Tick); // BmSDK-AO: the pause menu's MODS screen

        // BmSDK-AO: scripts' engine tick, also while paused
        if (s_hasGameInited)
        {
            foreach (var script in ScriptManager.Scripts)
            {
                ModGuard.Run(script, script.Name, "OnEngineTick", script.OnEngineTick);
            }
        }
        return _EngineTickDetourBase!.Invoke(self);
    }

    private static bool s_hasGameStarted = false;
    private static bool s_hasGameInited = false;

    // Detour for UObject::ProcessInternal(). Runs on every UnrealScript call in the game, so it must
    // not allocate: a function's path and lifecycle role are worked out once per UFunction (see
    // Classify), whether any redirect targets it is cached until the set of redirects changes, and
    // the guard is a plain try/catch rather than a captured lambda.
    private static unsafe void ProcessInternalDetour(IntPtr self, IntPtr Stack, IntPtr Result)
    {
        // Kept outside the try so a native fault inside the game's own function body can be named below.
        string? funcName = null;
        GameObject? selfObj = null;
        try
        {
            IntPtr selfPtr = self;
            FFrame* stackPtr = (FFrame*)Stack.ToPointer();
            selfObj = MarshalUtil.ToManaged<GameObject>(&selfPtr);
            var funcObj = MarshalUtil.ToManaged<Function>(&stackPtr->Node);
            // BmSDK-AO: path, super paths and crash-log label, cached on the function's wrapper
            var funcInfo = funcObj.CacheEntry ?? Classify(funcObj);
            funcName = funcInfo.Path;

            switch (funcObj.LifecycleKind)
            {
                // Notify scripts of game init
                case Function.Lifecycle.Init when !s_hasGameInited:
                    // Install DLC bundles
                    DLCManager.Run(true);

                    // Preload packages and root keep-alive objects before any world loads
                    PreloadManager.Run();

                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "Main", script.Main);
                    }
                    s_hasGameInited = true;
                    break;

                // The game's own DLC scan begins by clearing every bundle, so reinstall once it completes.
                case Function.Lifecycle.DLCScanComplete:
                    DLCManager.Run(false);
                    break;

                // Notify scripts of game start
                case Function.Lifecycle.EnterMenu when !s_hasGameStarted:
                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "OnEnterMenu", script.OnEnterMenu);
                    }
                    s_hasGameStarted = true;
                    break;

                // Notify scripts of game begin play
                case Function.Lifecycle.EnterGame:
                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "OnEnterGame", script.OnEnterGame);
                    }
                    break;

                // Notify scripts of game tick
                case Function.Lifecycle.Tick:
                    OptionsManager.Tick(); // BmSDK-AO: tells the options menu the game is running

                    // Call OnTick() for scripts
                    foreach (var script in ScriptManager.Scripts)
                    {
                        ModGuard.Run(script, script.Name, "OnTick", script.OnTick);
                    }

                    // Call OnTick() for script components
                    if (GameObject.AllScriptComponents.Count > 0)
                    {
                        foreach (var scriptComponent in GameObject.AllScriptComponents.ToArray())
                        {
                            ModGuard.Run(scriptComponent, scriptComponent.GetType().Name, "OnTick", scriptComponent.OnTick);
                        }
                    }
                    break;
            }

            // BmSDK-AO: the crash log names the script functions running (a native crash inside a script's native
            // call, GFx for example, shows no BmSDK code at all)
            var tracked = CrashContext.TracksScripts;
            if (tracked)
            {
                CrashContext.EnterScript(funcInfo.Label);
            }
            try
            {
                // Run redirect and skip base implementation if applicable to this function
                if (
                    RedirectManager.MayRedirect(funcObj, funcName, funcInfo.Supers)
                    && RedirectManager.ExecuteRedirector(selfObj, funcObj, funcName, stackPtr, Result, funcInfo.Supers)
                )
                {
                    return;
                }

                // Call base impl. Redirected implementations are expected to reach this by calling "themselves" a second time.
                _ProcessInternalDetourBase!.Invoke(self, Stack, Result);
            }
            finally
            {
                if (tracked)
                {
                    CrashContext.LeaveScript();
                }
            }
        }
        catch (Exception ex)
        {
            // A hardware fault in the game's code surfaces here as an SEHException with no clue where it was: name
            // the UnrealScript function that was running and the object it ran on, which is usually enough to find it.
            string where = "?";
            try
            {
                where = (funcName ?? "?") + " on " + (selfObj != null ? selfObj.GetPathName() : "?");
            }
            catch
            {
                // Naming the object must never hide the original failure.
            }

            Debug.LogError("ProcessInternal failed while the game ran " + where);
            Abort(ex);
        }
    }

    /// <summary>Works out a function's path, super paths and lifecycle role, once per UFunction wrapper.</summary>
    private static FunctionCache.Entry Classify(Function func)
    {
        var entry = FunctionCache.Get(func);
        var path = entry.Path;
        func.LifecycleKind =
            UENames.Equal(path, InitFuncName) ? Function.Lifecycle.Init
            : UENames.Equal(path, EnterMenuFuncName) ? Function.Lifecycle.EnterMenu
            : UENames.Equal(path, EnterGameFuncName) ? Function.Lifecycle.EnterGame
            : UENames.Equal(path, TickFuncName) ? Function.Lifecycle.Tick
            : UENames.Equal(path, DLCScanCompleteFuncName) ? Function.Lifecycle.DLCScanComplete
            : Function.Lifecycle.None;
        func.CacheEntry = entry;
        return entry;
    }

    // Detour for FWindowsViewport::ProcessDeferredMessage(). Key and mouse-button messages are
    // recorded for scripts, and dropped before the engine sees them when a mod swallowed the key.
    private static void ProcessDeferredMessageDetour(IntPtr self, ref FDeferredMessage message)
    {
        // WM_KILLFOCUS, or WM_ACTIVATE with WA_INACTIVE: every key counts as released.
        if (message.Message == 0x08 || (message.Message == 0x06 && (message.WParam & 0xFFFF) == 0))
        {
            InputManager.OnFocusLost();
        }

        var swallow = message.Message switch
        {
            // WM_KEYDOWN, WM_SYSKEYDOWN
            0x100 or 0x104 => InputManager.OnKeyDown((Keys)(uint)message.WParam),
            // WM_KEYUP, WM_SYSKEYUP
            0x101 or 0x105 => InputManager.OnKeyUp((Keys)(uint)message.WParam),
            // WM_CHAR, WM_DEADCHAR, WM_SYSCHAR, WM_SYSDEADCHAR: the text form of the press before it
            0x102 or 0x103 or 0x106 or 0x107 => InputManager.OnChar(),
            // WM_LBUTTONDOWN, WM_LBUTTONDBLCLK / WM_LBUTTONUP
            0x201 or 0x203 => InputManager.OnKeyDown(Keys.LButton),
            0x202 => InputManager.OnKeyUp(Keys.LButton),
            // WM_RBUTTONDOWN, WM_RBUTTONDBLCLK / WM_RBUTTONUP
            0x204 or 0x206 => InputManager.OnKeyDown(Keys.RButton),
            0x205 => InputManager.OnKeyUp(Keys.RButton),
            // WM_MBUTTONDOWN, WM_MBUTTONDBLCLK / WM_MBUTTONUP
            0x207 or 0x209 => InputManager.OnKeyDown(Keys.MButton),
            0x208 => InputManager.OnKeyUp(Keys.MButton),
            // WM_XBUTTONDOWN, WM_XBUTTONDBLCLK / WM_XBUTTONUP (button in the high word of wParam)
            0x20B or 0x20D => InputManager.OnKeyDown(XButton(message.WParam)),
            0x20C => InputManager.OnKeyUp(XButton(message.WParam)),
            _ => false,
        };

        if (swallow)
        {
            return;
        }

        // Call base impl
        _ProcessDeferredMessageDetourBase!.Invoke(self, ref message);
    }

    private static Keys XButton(nuint wParam) =>
        ((wParam >> 16) & 0xFFFF) == 2 ? Keys.XButton2 : Keys.XButton1;

    /// <summary>Gives every script its OnDraw, from BmSDK's PostRender redirect.</summary>
    internal static void DispatchDraw(Engine.Canvas canvas)
    {
        if (!s_hasGameInited)
        {
            return;
        }

        foreach (var script in ScriptManager.Scripts)
        {
            ModGuard.Run(script, script.Name, "OnDraw", () => script.OnDraw(canvas));
        }
    }

    // Detour for UObject::AddObject()
    private static void AddObjectDetour(IntPtr self, int InIndex)
    {
        // Call base impl to instantiate UObject
        _AddObjectDelegateDetourBase!.Invoke(self, InIndex);
        MarshalUtil.NoteCreated(self); // BmSDK-AO: the address holds a live object again

        // Runs for every object the game creates: no captured lambda here.
        try
        {
            var obj = MarshalUtil.GetOrCreateWrapper(self);

            // Auto-attach script components to non-serialized objs
            if (!obj.IsClassDefaultObject && ScriptComponentManager.HasAutoAttachTypes())
            {
                ScriptComponentManager.TryAutoAttachComponents(obj, objNotLoaded: true);
            }
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    // Detour for UObject::ConditionalPostLoad()
    private static void ConditionalPostLoadDetour(IntPtr self)
    {
        // Call base impl to set default func flags first
        _ConditionalPostLoadDetourBase!.Invoke(self);

        // Configure redirected functions
        try
        {
            var obj = MarshalUtil.GetOrCreateWrapper(self);
            if (obj is Function func)
            {
                RedirectManager.TryConfigureFunction(func);
            }

            // Auto-attach script components to serialized objs
            if (!obj.IsClassDefaultObject && ScriptComponentManager.HasAutoAttachTypes())
            {
                ScriptComponentManager.TryAutoAttachComponents(obj, objNotLoaded: true);
            }
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    // Detour for UObject::ConditionalDestroy()
    private static void ConditionalDestroyDetour(IntPtr self)
    {
        // Destroy this object's managed instance
        try
        {
            MarshalUtil.DestroyManagedWrapper(self);
        }
        catch (Exception ex)
        {
            Abort(ex);
        }

        // Call base impl
        _ConditionalDestroyDetourBase!.Invoke(self);
    }

    // BmSDK-AO: framework code run from the engine tick, named in the crash log like scripts and redirects are
    private static readonly System.Reflection.MethodInfo s_optionsTick = ((Action)OptionsManager.EngineTick).Method;
    private static readonly System.Reflection.MethodInfo s_modScreenTick = ((Action)PauseModScreen.Tick).Method;

    private static void RunTracked(System.Reflection.MethodInfo method, Action action)
    {
        var prev = CrashContext.Enter("BmSDK", method);
        try
        {
            RunGuarded(action);
        }
        finally
        {
            CrashContext.Leave(prev);
        }
    }

    private static void RunGuarded(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            Abort(ex);
        }
    }

    /// <summary>A fault inside BmSDK itself (mod exceptions are handled by <see cref="ModGuard"/>).</summary>
    private static void Abort(Exception ex)
    {
        // Just abort, because otherwise UE3 will crash anyway but print
        // its more-or-less useless DBGHELP messages.
        Debug.LogError(ex.ToString());
        Environment.Exit(1);
    }
}
