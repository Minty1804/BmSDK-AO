#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDHudExtensionObituaries<br/>
/// (size = 168)
/// (flags = 32786)
/// </summary>
public partial class GDHudExtensionObituaries : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDHudExtensionObituaries", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDHudExtensionObituaries.
    /// </summary>
    public static GDHudExtensionObituaries DefaultObject => (GDHudExtensionObituaries)StaticClass().DefaultObject;

    internal GDHudExtensionObituaries() { }

    /// <summary>
    /// Constructs a new GDHudExtensionObituaries
    /// </summary>
    public GDHudExtensionObituaries(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDHudExtensionObituaries Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDHudExtensionObituaries(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionObituaries>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionObituaries>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionObituaries>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionObituaries>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionObituaries>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionObituaries>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionObituaries>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionObituaries>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetMoviePath;
    /// <summary>
    /// Function: SetMoviePath
    /// </summary>
    public unsafe virtual void SetMoviePath(BmSDK.FString _path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMoviePath, "BmGame.GDHudExtensionObituaries.SetMoviePath");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestNextObituaryMethod;
    /// <summary>
    /// Function: TestNextObituaryMethod
    /// </summary>
    public unsafe void TestNextObituaryMethod()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestNextObituaryMethod, "BmGame.GDHudExtensionObituaries.TestNextObituaryMethod");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestObituaryMessages;
    /// <summary>
    /// Function: TestObituaryMessages
    /// </summary>
    public unsafe virtual void TestObituaryMessages()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestObituaryMessages, "BmGame.GDHudExtensionObituaries.TestObituaryMessages");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDisconnectionObituary;
    /// <summary>
    /// Function: AddDisconnectionObituary
    /// </summary>
    public unsafe void AddDisconnectionObituary(BmSDK.FString PlayerName, int PlayerColor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDisconnectionObituary, "BmGame.GDHudExtensionObituaries.AddDisconnectionObituary");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerColor, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddObituary;
    /// <summary>
    /// Function: AddObituary
    /// </summary>
    public unsafe void AddObituary(BmSDK.FString KillerName, bool KillerLocal, bool KillerIsBatman, bool KillerIsRobin, int KillerColor, BmSDK.FString method, BmSDK.FString VictimName, bool VictimLocal, bool VictimIsBatman, bool VictimIsRobin, int VictimColor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddObituary, "BmGame.GDHudExtensionObituaries.AddObituary");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerLocal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerIsBatman, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerIsRobin, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerColor, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(method, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimName, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimLocal, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimIsBatman, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimIsRobin, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimColor, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowObituaryMessage;
    /// <summary>
    /// Function: ShowObituaryMessage
    /// </summary>
    public unsafe virtual void ShowObituaryMessage(BmSDK.BmGame.RPlayerRI KillerPRI, BmSDK.Class dmgType, BmSDK.BmGame.RPlayerRI VictimPRI, BmSDK.BmGame.RGameInfo.ESpecialistObitType SpecialType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowObituaryMessage, "BmGame.GDHudExtensionObituaries.ShowObituaryMessage");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerPRI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimPRI, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowPlayerDisconnectionMessage;
    /// <summary>
    /// Function: ShowPlayerDisconnectionMessage
    /// </summary>
    public unsafe virtual void ShowPlayerDisconnectionMessage(BmSDK.BmGame.RPlayerRI DisconnectedPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPlayerDisconnectionMessage, "BmGame.GDHudExtensionObituaries.ShowPlayerDisconnectionMessage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisconnectedPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.GDHudExtensionObituaries.Close");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDHudExtensionObituaries.Init");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// StrProperty: MovieTargetPath
    /// </summary>
    public unsafe BmSDK.FString MovieTargetPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: TestObituaryMethodNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TestObituaryMethodNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: NextTestIndex
    /// </summary>
    public unsafe int NextTestIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bTesting
    /// </summary>
    public unsafe bool bTesting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }
}
