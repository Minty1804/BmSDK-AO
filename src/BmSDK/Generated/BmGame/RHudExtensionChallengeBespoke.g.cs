#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionChallengeBespoke<br/>
/// (size = 104)
/// (flags = 18)
/// </summary>
public partial class RHudExtensionChallengeBespoke : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudExtensionChallengeBespoke", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudExtensionChallengeBespoke.
    /// </summary>
    public static RHudExtensionChallengeBespoke DefaultObject => (RHudExtensionChallengeBespoke)StaticClass().DefaultObject;

    internal RHudExtensionChallengeBespoke() { }

    /// <summary>
    /// Constructs a new RHudExtensionChallengeBespoke
    /// </summary>
    public RHudExtensionChallengeBespoke(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudExtensionChallengeBespoke Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudExtensionChallengeBespoke(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionChallengeBespoke>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionChallengeBespoke>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionChallengeBespoke>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionChallengeBespoke>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionChallengeBespoke>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionChallengeBespoke>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionChallengeBespoke>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionChallengeBespoke>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdatePushYourLuckBandDetails;
    /// <summary>
    /// Function: UpdatePushYourLuckBandDetails
    /// </summary>
    public unsafe virtual void UpdatePushYourLuckBandDetails(int Band_Index, int Bonus_Points, int Bonus_Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePushYourLuckBandDetails, "BmGame.RHudExtensionChallengeBespoke.UpdatePushYourLuckBandDetails");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Band_Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bonus_Points, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bonus_Time, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushYourLuckShakeGauge;
    /// <summary>
    /// Function: PushYourLuckShakeGauge
    /// </summary>
    public unsafe virtual void PushYourLuckShakeGauge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushYourLuckShakeGauge, "BmGame.RHudExtensionChallengeBespoke.PushYourLuckShakeGauge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushYourLuckBankValue;
    /// <summary>
    /// Function: PushYourLuckBankValue
    /// </summary>
    public unsafe virtual void PushYourLuckBankValue(int bank_level, int Score, int Bonus_Time, bool max_gauge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushYourLuckBankValue, "BmGame.RHudExtensionChallengeBespoke.PushYourLuckBankValue");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bank_level, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bonus_Time, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max_gauge, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPushYourLuckGaugeValue;
    /// <summary>
    /// Function: SetPushYourLuckGaugeValue
    /// </summary>
    public unsafe virtual void SetPushYourLuckGaugeValue(int raw_value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPushYourLuckGaugeValue, "BmGame.RHudExtensionChallengeBespoke.SetPushYourLuckGaugeValue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(raw_value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPushYourLuckBandDetails;
    /// <summary>
    /// Function: SetPushYourLuckBandDetails
    /// </summary>
    public unsafe virtual void SetPushYourLuckBandDetails(int Band_Index, BmSDK.FString Band_Title, int Bonus_Points, int Bonus_Time, int GaugeValueForNext)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPushYourLuckBandDetails, "BmGame.RHudExtensionChallengeBespoke.SetPushYourLuckBandDetails");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Band_Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Band_Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bonus_Points, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bonus_Time, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GaugeValueForNext, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHeadToHeadBankLocal;
    /// <summary>
    /// Function: SetHeadToHeadBankLocal
    /// </summary>
    public unsafe virtual void SetHeadToHeadBankLocal(int bank_level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeadToHeadBankLocal, "BmGame.RHudExtensionChallengeBespoke.SetHeadToHeadBankLocal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bank_level, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudExtensionChallengeBespoke.Close");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudExtensionChallengeBespoke.Init");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// BoolProperty: SuppressDetectiveModeInfo
    /// </summary>
    public unsafe bool SuppressDetectiveModeInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }
}
