#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionHealth<br/>
/// (size = 116)
/// (flags = 18)
/// </summary>
public partial class RHudExtensionHealth : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudExtensionHealth", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudExtensionHealth.
    /// </summary>
    public static RHudExtensionHealth DefaultObject => (RHudExtensionHealth)StaticClass().DefaultObject;

    internal RHudExtensionHealth() { }

    /// <summary>
    /// Constructs a new RHudExtensionHealth
    /// </summary>
    public RHudExtensionHealth(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudExtensionHealth Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudExtensionHealth(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionHealth>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionHealth>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionHealth>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionHealth>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionHealth>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionHealth>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionHealth>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionHealth>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetComboTrainingParameters;
    /// <summary>
    /// Function: SetComboTrainingParameters
    /// </summary>
    public unsafe virtual void SetComboTrainingParameters(float CriticalDuration, float EarlyDuration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboTrainingParameters, "BmGame.RHudExtensionHealth.SetComboTrainingParameters");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CriticalDuration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EarlyDuration, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessXPData;
    /// <summary>
    /// Function: ProcessXPData
    /// </summary>
    public unsafe virtual void ProcessXPData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessXPData, "BmGame.RHudExtensionHealth.ProcessXPData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueXPData;
    /// <summary>
    /// Function: QueueXPData
    /// </summary>
    public unsafe virtual bool QueueXPData(BmSDK.GFxUI.GFxObject Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueXPData, "BmGame.RHudExtensionHealth.QueueXPData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_QueueXPMessage;
    /// <summary>
    /// Function: QueueXPMessage
    /// </summary>
    public unsafe virtual void QueueXPMessage(BmSDK.FString Title, BmSDK.FString Message, float HoldDuration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueXPMessage, "BmGame.RHudExtensionHealth.QueueXPMessage");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HoldDuration, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCritical;
    /// <summary>
    /// Function: ShowCritical
    /// </summary>
    public unsafe virtual void ShowCritical()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCritical, "BmGame.RHudExtensionHealth.ShowCritical");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetComboTokens;
    /// <summary>
    /// Function: SetComboTokens
    /// </summary>
    public unsafe virtual void SetComboTokens(int numTokens)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboTokens, "BmGame.RHudExtensionHealth.SetComboTokens");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(numTokens, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetComboChallenge;
    /// <summary>
    /// Function: SetComboChallenge
    /// </summary>
    public unsafe virtual void SetComboChallenge(int ColourID, int ComboNumber, int ComboValue, BmSDK.FString movename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboChallenge, "BmGame.RHudExtensionHealth.SetComboChallenge");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColourID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboNumber, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(movename, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetComboLevel;
    /// <summary>
    /// Function: SetComboLevel
    /// </summary>
    public unsafe virtual void SetComboLevel(int Value, int iPowerUpLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboLevel, "BmGame.RHudExtensionHealth.SetComboLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iPowerUpLevel, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombo;
    /// <summary>
    /// Function: SetCombo
    /// </summary>
    public unsafe virtual void SetCombo(int Value, bool bPowerUp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombo, "BmGame.RHudExtensionHealth.SetCombo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPowerUp, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWallClimbBonus;
    /// <summary>
    /// Function: ShowWallClimbBonus
    /// </summary>
    public unsafe virtual void ShowWallClimbBonus(BmSDK.FString BonusTitle, BmSDK.FString BonusDetail)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWallClimbBonus, "BmGame.RHudExtensionHealth.ShowWallClimbBonus");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BonusTitle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BonusDetail, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowTwoStringBonus;
    /// <summary>
    /// Function: ShowTwoStringBonus
    /// </summary>
    public unsafe virtual void ShowTwoStringBonus(BmSDK.FString BonusTitle, BmSDK.FString BonusDetail)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTwoStringBonus, "BmGame.RHudExtensionHealth.ShowTwoStringBonus");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BonusTitle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BonusDetail, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLevelUpDisplaySuppressed;
    /// <summary>
    /// Function: SetLevelUpDisplaySuppressed
    /// </summary>
    public unsafe virtual void SetLevelUpDisplaySuppressed(bool _bLevelUpSuppressed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLevelUpDisplaySuppressed, "BmGame.RHudExtensionHealth.SetLevelUpDisplaySuppressed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bLevelUpSuppressed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowLevelUp;
    /// <summary>
    /// Function: ShowLevelUp
    /// </summary>
    public unsafe virtual void ShowLevelUp(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLevelUp, "BmGame.RHudExtensionHealth.ShowLevelUp");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowLevelUpTrigger;
    /// <summary>
    /// Function: ShowLevelUpTrigger
    /// </summary>
    public unsafe virtual void ShowLevelUpTrigger(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLevelUpTrigger, "BmGame.RHudExtensionHealth.ShowLevelUpTrigger");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowXPBar;
    /// <summary>
    /// Function: ShowXPBar
    /// </summary>
    public unsafe virtual void ShowXPBar(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowXPBar, "BmGame.RHudExtensionHealth.ShowXPBar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetXPBar;
    /// <summary>
    /// Function: SetXPBar
    /// </summary>
    public unsafe virtual void SetXPBar(int Current, int Minimum, int Maximum, int Duration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXPBar, "BmGame.RHudExtensionHealth.SetXPBar");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Minimum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetArray;
    /// <summary>
    /// Function: GetArray
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject GetArray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArray, "BmGame.RHudExtensionHealth.GetArray");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetObject;
    /// <summary>
    /// Function: GetObject
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject GetObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObject, "BmGame.RHudExtensionHealth.GetObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowLootBar;
    /// <summary>
    /// Function: ShowLootBar
    /// </summary>
    public unsafe virtual void ShowLootBar(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLootBar, "BmGame.RHudExtensionHealth.ShowLootBar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLootBar;
    /// <summary>
    /// Function: SetLootBar
    /// </summary>
    public unsafe virtual void SetLootBar(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLootBar, "BmGame.RHudExtensionHealth.SetLootBar");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisibilityPrivate;
    /// <summary>
    /// Function: SetVisibilityPrivate
    /// </summary>
    public unsafe virtual void SetVisibilityPrivate(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisibilityPrivate, "BmGame.RHudExtensionHealth.SetVisibilityPrivate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckWhetherShouldBeVisible;
    /// <summary>
    /// Function: CheckWhetherShouldBeVisible
    /// </summary>
    public unsafe virtual void CheckWhetherShouldBeVisible()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckWhetherShouldBeVisible, "BmGame.RHudExtensionHealth.CheckWhetherShouldBeVisible");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowHealthBar;
    /// <summary>
    /// Function: ShowHealthBar
    /// </summary>
    public unsafe virtual void ShowHealthBar(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowHealthBar, "BmGame.RHudExtensionHealth.ShowHealthBar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetArmourLevel;
    /// <summary>
    /// Function: SetArmourLevel
    /// </summary>
    public unsafe virtual void SetArmourLevel(int armour_type, int current_armour, int max_armour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetArmourLevel, "BmGame.RHudExtensionHealth.SetArmourLevel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour_type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_armour, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max_armour, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPoisonLevel;
    /// <summary>
    /// Function: SetPoisonLevel
    /// </summary>
    public unsafe virtual void SetPoisonLevel(int PoisonLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPoisonLevel, "BmGame.RHudExtensionHealth.SetPoisonLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoisonLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPoisonChangePeriod;
    /// <summary>
    /// Function: SetPoisonChangePeriod
    /// </summary>
    public unsafe virtual void SetPoisonChangePeriod(float new_period)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPoisonChangePeriod, "BmGame.RHudExtensionHealth.SetPoisonChangePeriod");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_period, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PoisonedMax;
    /// <summary>
    /// Function: PoisonedMax
    /// </summary>
    public unsafe virtual int PoisonedMax(int MaximumHealth)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PoisonedMax, "BmGame.RHudExtensionHealth.PoisonedMax");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaximumHealth, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PoisonedHealth;
    /// <summary>
    /// Function: PoisonedHealth
    /// </summary>
    public unsafe virtual int PoisonedHealth(int CurrentHealth, int MaximumHealth)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PoisonedHealth, "BmGame.RHudExtensionHealth.PoisonedHealth");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentHealth, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaximumHealth, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetHealthBarWithPoisonEffectPrivate;
    /// <summary>
    /// Function: SetHealthBarWithPoisonEffectPrivate
    /// </summary>
    public unsafe virtual void SetHealthBarWithPoisonEffectPrivate(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealthBarWithPoisonEffectPrivate, "BmGame.RHudExtensionHealth.SetHealthBarWithPoisonEffectPrivate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPoisonHealthBarScaled;
    /// <summary>
    /// Function: SetPoisonHealthBarScaled
    /// </summary>
    public unsafe virtual void SetPoisonHealthBarScaled(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPoisonHealthBarScaled, "BmGame.RHudExtensionHealth.SetPoisonHealthBarScaled");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealthBarWithPoisonEffect;
    /// <summary>
    /// Function: SetHealthBarWithPoisonEffect
    /// </summary>
    public unsafe virtual void SetHealthBarWithPoisonEffect(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealthBarWithPoisonEffect, "BmGame.RHudExtensionHealth.SetHealthBarWithPoisonEffect");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealthBarCurrent;
    /// <summary>
    /// Function: SetHealthBarCurrent
    /// </summary>
    public unsafe virtual void SetHealthBarCurrent(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealthBarCurrent, "BmGame.RHudExtensionHealth.SetHealthBarCurrent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealthBarPrivate;
    /// <summary>
    /// Function: SetHealthBarPrivate
    /// </summary>
    public unsafe virtual void SetHealthBarPrivate(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealthBarPrivate, "BmGame.RHudExtensionHealth.SetHealthBarPrivate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealthBarScaled;
    /// <summary>
    /// Function: SetHealthBarScaled
    /// </summary>
    public unsafe virtual void SetHealthBarScaled(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealthBarScaled, "BmGame.RHudExtensionHealth.SetHealthBarScaled");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealthBar;
    /// <summary>
    /// Function: SetHealthBar
    /// </summary>
    public unsafe virtual void SetHealthBar(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealthBar, "BmGame.RHudExtensionHealth.SetHealthBar");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetScaledHealth;
    /// <summary>
    /// Function: GetScaledHealth
    /// </summary>
    public unsafe virtual int GetScaledHealth(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScaledHealth, "BmGame.RHudExtensionHealth.GetScaledHealth");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsBruceWayne;
    /// <summary>
    /// Function: IsBruceWayne
    /// </summary>
    public unsafe virtual bool IsBruceWayne()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBruceWayne, "BmGame.RHudExtensionHealth.IsBruceWayne");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowCharacterName;
    /// <summary>
    /// Function: ShowCharacterName
    /// </summary>
    public unsafe virtual void ShowCharacterName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCharacterName, "BmGame.RHudExtensionHealth.ShowCharacterName");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHealthBarPrivate;
    /// <summary>
    /// Function: InitHealthBarPrivate
    /// </summary>
    public unsafe virtual void InitHealthBarPrivate(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHealthBarPrivate, "BmGame.RHudExtensionHealth.InitHealthBarPrivate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHealthBar;
    /// <summary>
    /// Function: InitHealthBar
    /// </summary>
    public unsafe virtual void InitHealthBar(int Current, int Maximum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHealthBar, "BmGame.RHudExtensionHealth.InitHealthBar");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudExtensionHealth.Close");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostAdvance;
    /// <summary>
    /// Function: PostAdvance
    /// </summary>
    public unsafe override void PostAdvance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostAdvance, "BmGame.RHudExtensionHealth.PostAdvance");
        byte* paramsPtr = stackalloc byte[28];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudExtensionHealth.Init");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// BoolProperty: bCurrentlyVisible
    /// </summary>
    public unsafe bool bCurrentlyVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bHealthBarRequested
    /// </summary>
    public unsafe bool bHealthBarRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bXPBarRequested
    /// </summary>
    public unsafe bool bXPBarRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bLootBarRequested
    /// </summary>
    public unsafe bool bLootBarRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bXPBarFull
    /// </summary>
    public unsafe bool bXPBarFull
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bSurpressLevelupSound
    /// </summary>
    public unsafe bool bSurpressLevelupSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bLevelUpVisible
    /// </summary>
    public unsafe bool bLevelUpVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bLevelUpSuppressed
    /// </summary>
    public unsafe bool bLevelUpSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bLevelUpActuallyDisplayed
    /// </summary>
    public unsafe bool bLevelUpActuallyDisplayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: ArmourInitialised
    /// </summary>
    public unsafe bool ArmourInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bReplayPreventsLevelUp
    /// </summary>
    public unsafe bool bReplayPreventsLevelUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: HUDEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HUDEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// IntProperty: PoisonMaxHealth
    /// </summary>
    public unsafe int PoisonMaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: HealthBarScaling
    /// </summary>
    public unsafe float HealthBarScaling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
