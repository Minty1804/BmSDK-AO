#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentData<br/>
/// (size = 1532)
/// (flags = 134217874)
/// </summary>
public partial class RPersistentData : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPersistentData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPersistentData.
    /// </summary>
    public static RPersistentData DefaultObject => (RPersistentData)StaticClass().DefaultObject;

    internal RPersistentData() { }

    /// <summary>
    /// Constructs a new RPersistentData
    /// </summary>
    public RPersistentData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPersistentData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPersistentData(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentData>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetMaxStorySynopsisId
    /// </summary>
    public unsafe virtual int GetMaxStorySynopsisId()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetMaxStorySynopsisId", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSideStoryCharacterProgressStatus
    /// </summary>
    public unsafe virtual int GetSideStoryCharacterProgressStatus(BmSDK.BmGame.RPersistentData.EProgressCharacter Who)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetSideStoryCharacterProgressStatus", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Who, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetSideStoryCharacterProgressStatus
    /// </summary>
    public unsafe virtual void SetSideStoryCharacterProgressStatus(BmSDK.BmGame.RPersistentData.EProgressCharacter Who, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetSideStoryCharacterProgressStatus", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Who, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncreaseCatwomanJewellery
    /// </summary>
    public unsafe virtual bool IncreaseCatwomanJewellery(BmSDK.BmGame.RPlayerController RPC, int JewelleryValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncreaseCatwomanJewellery", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JewelleryValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: FinishedCatwomanJewellery
    /// </summary>
    public unsafe virtual bool FinishedCatwomanJewellery()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.FinishedCatwomanJewellery", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShowRaftCancelTutorial
    /// </summary>
    public unsafe virtual bool ShowRaftCancelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowRaftCancelTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementRaftCancelTutorial
    /// </summary>
    public unsafe virtual void IncrementRaftCancelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementRaftCancelTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartRaftCancelTutorial
    /// </summary>
    public unsafe virtual void StartRaftCancelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartRaftCancelTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGrappleBoostTutorial
    /// </summary>
    public unsafe virtual void StartGrappleBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGrappleBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGrappleBoostTutorial
    /// </summary>
    public unsafe virtual void IncrementGrappleBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGrappleBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGrappleBoostTutorial
    /// </summary>
    public unsafe virtual bool ShowGrappleBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGrappleBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetShowFastTravelTutorial
    /// </summary>
    public unsafe virtual bool GetShowFastTravelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetShowFastTravelTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetShowFastTravelTutorial
    /// </summary>
    public unsafe virtual void SetShowFastTravelTutorial(bool bShow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetShowFastTravelTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartStealthMoveTutorial
    /// </summary>
    public unsafe virtual void StartStealthMoveTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartStealthMoveTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementStealthMoveTutorialTimer
    /// </summary>
    public unsafe virtual void IncrementStealthMoveTutorialTimer(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementStealthMoveTutorialTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowStealthMoveTutorial
    /// </summary>
    public unsafe virtual bool ShowStealthMoveTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowStealthMoveTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartGrapplingTutorial
    /// </summary>
    public unsafe virtual void StartGrapplingTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGrapplingTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGrappleTutorial
    /// </summary>
    public unsafe virtual void IncrementGrappleTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGrappleTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGrappleTutorial
    /// </summary>
    public unsafe virtual bool ShowGrappleTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGrappleTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartGlideBoostTutorial
    /// </summary>
    public unsafe virtual void StartGlideBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGlideBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGlidingTutorial
    /// </summary>
    public unsafe virtual void StartGlidingTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGlidingTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowAnyGlideTutorials
    /// </summary>
    public unsafe virtual bool ShowAnyGlideTutorials()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowAnyGlideTutorials", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementPullUpFromDivePrompt
    /// </summary>
    public unsafe virtual void IncrementPullUpFromDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementPullUpFromDivePrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowPullUpFromDivePrompt
    /// </summary>
    public unsafe virtual bool ShowPullUpFromDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowPullUpFromDivePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementGlideDivePrompt
    /// </summary>
    public unsafe virtual void IncrementGlideDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideDivePrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGlideSteerPromptUD
    /// </summary>
    public unsafe virtual void IncrementGlideSteerPromptUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideSteerPromptUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGlideSteerPromptUD
    /// </summary>
    public unsafe virtual bool ShowGlideSteerPromptUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGlideSteerPromptUD", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementGlideSteerPromptLR
    /// </summary>
    public unsafe virtual void IncrementGlideSteerPromptLR()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideSteerPromptLR", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGlideTimer
    /// </summary>
    public unsafe virtual void IncrementGlideTimer(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGlidePrompt
    /// </summary>
    public unsafe virtual bool ShowGlidePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGlidePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearMapObjectivePanList
    /// </summary>
    public unsafe virtual void ClearMapObjectivePanList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ClearMapObjectivePanList", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveDynamicMapItemsByChapter
    /// </summary>
    public unsafe virtual void RemoveDynamicMapItemsByChapter(BmSDK.FString ChapterPrefix)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemoveDynamicMapItemsByChapter", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChapterPrefix, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveDynamicMapItem
    /// </summary>
    public unsafe virtual void RemoveDynamicMapItem(BmSDK.FString ItemName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemoveDynamicMapItem", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDynamicMapItem
    /// </summary>
    public unsafe virtual void AddDynamicMapItem(BmSDK.FString ItemName, BmSDK.FString ItemType, BmSDK.FString PMap, int X, int Y)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AddDynamicMapItem", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PMap, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveTrail
    /// </summary>
    public unsafe virtual void RemoveTrail(BmSDK.FString TrailName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemoveTrail", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddTrailItem
    /// </summary>
    public unsafe virtual void AddTrailItem(BmSDK.FString TrailName, BmSDK.FString PMap, int X, int Y)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AddTrailItem", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PMap, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemapCharacter_Progress2Bio
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentData.EBioCharacter RemapCharacter_Progress2Bio(BmSDK.BmGame.RPersistentData.EProgressCharacter inProgress)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemapCharacter_Progress2Bio", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inProgress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EBioCharacter>(paramsPtr + 1);
    }

    /// <summary>
    /// Function: SetObjectiveLocation
    /// </summary>
    public unsafe virtual void SetObjectiveLocation(System.Numerics.Vector3 the_location)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetObjectiveLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_location, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsObjectiveTrackingActive
    /// </summary>
    public unsafe virtual bool IsObjectiveTrackingActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsObjectiveTrackingActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetObjectiveTrackingActive
    /// </summary>
    public unsafe virtual void SetObjectiveTrackingActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetObjectiveTrackingActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateRadioStation
    /// </summary>
    public unsafe virtual int CreateRadioStation(BmSDK.FString StationName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.CreateRadioStation", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StationName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SetRadioStationFlag
    /// </summary>
    public unsafe virtual void SetRadioStationFlag(int station_index, byte attribute_flag, bool value_truefalse)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetRadioStationFlag", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(station_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(attribute_flag, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(value_truefalse, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckRadioStationFlag
    /// </summary>
    public unsafe virtual bool CheckRadioStationFlag(int station_index, byte attribute_flag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.CheckRadioStationFlag", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(station_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(attribute_flag, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetRadioStationIndex
    /// </summary>
    public unsafe virtual int GetRadioStationIndex(BmSDK.FString StationName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetRadioStationIndex", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StationName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: UpdateButtonBashDDA
    /// </summary>
    public unsafe virtual void UpdateButtonBashDDA(out float TimeAtMinSpeed, out float TimeAtMaxSpeed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.UpdateButtonBashDDA", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TimeAtMinSpeed = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        TimeAtMaxSpeed = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: SixaxisTeethPrompt
    /// </summary>
    public unsafe virtual bool SixaxisTeethPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisTeethPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SixaxisTeethPerformed
    /// </summary>
    public unsafe virtual void SixaxisTeethPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisTeethPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SixaxisBatarangPrompt
    /// </summary>
    public unsafe virtual bool SixaxisBatarangPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisBatarangPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SixaxisBatarangPerformed
    /// </summary>
    public unsafe virtual void SixaxisBatarangPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisBatarangPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SixaxisGlidePrompt
    /// </summary>
    public unsafe virtual bool SixaxisGlidePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisGlidePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SixaxisGlidePerformed
    /// </summary>
    public unsafe virtual void SixaxisGlidePerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisGlidePerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HangModeDropPrompt
    /// </summary>
    public unsafe virtual bool HangModeDropPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.HangModeDropPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HangModeDropPerformed
    /// </summary>
    public unsafe virtual void HangModeDropPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.HangModeDropPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DropOffGrapplePerformed
    /// </summary>
    public unsafe virtual void DropOffGrapplePerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DropOffGrapplePerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GlideOffWallPrompt
    /// </summary>
    public unsafe virtual bool GlideOffWallPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GlideOffWallPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GlideOffWallPerformed
    /// </summary>
    public unsafe virtual void GlideOffWallPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GlideOffWallPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LineLaunchDropPrompt
    /// </summary>
    public unsafe virtual bool LineLaunchDropPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.LineLaunchDropPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LineLaunchDropPerformed
    /// </summary>
    public unsafe virtual void LineLaunchDropPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.LineLaunchDropPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearAutomaticCombatTutorials
    /// </summary>
    public unsafe virtual void ClearAutomaticCombatTutorials()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ClearAutomaticCombatTutorials", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TutorialActionAchieved
    /// </summary>
    public unsafe virtual void TutorialActionAchieved(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.TutorialActionAchieved", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNumActivationsForAction
    /// </summary>
    public unsafe virtual int GetNumActivationsForAction(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetNumActivationsForAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ShouldShowTutorial
    /// </summary>
    public unsafe virtual int ShouldShowTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShouldShowTutorial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ResetTutorialProgress
    /// </summary>
    public unsafe virtual void ResetTutorialProgress(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ResetTutorialProgress", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DesignDeactivateTutorial
    /// </summary>
    public unsafe virtual void DesignDeactivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DesignDeactivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DesignActivateTutorial
    /// </summary>
    public unsafe virtual void DesignActivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DesignActivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerStopTutorial
    /// </summary>
    public unsafe virtual void PlayerStopTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.PlayerStopTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerStartTutorial
    /// </summary>
    public unsafe virtual void PlayerStartTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.PlayerStartTutorial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTutorialPlayerActive
    /// </summary>
    public unsafe virtual bool IsTutorialPlayerActive(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsTutorialPlayerActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AutoDeactivateTutorial
    /// </summary>
    public unsafe virtual void AutoDeactivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AutoDeactivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AutoActivateTutorial
    /// </summary>
    public unsafe virtual void AutoActivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AutoActivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTutorialAutoActive
    /// </summary>
    public unsafe virtual bool IsTutorialAutoActive(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsTutorialAutoActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PadStr
    /// </summary>
    public unsafe virtual BmSDK.FString PadStr(BmSDK.FString InStr, int DesiredLen)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.PadStr", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredLen, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe virtual void Dump()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.Dump", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToTimeStr
    /// </summary>
    public unsafe virtual BmSDK.FString ToTimeStr(float inTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ToTimeStr", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ClearActiveMapTrail
    /// </summary>
    public unsafe virtual void ClearActiveMapTrail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ClearActiveMapTrail", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPersistentLevelIndexByName
    /// </summary>
    public unsafe virtual int GetPersistentLevelIndexByName(BmSDK.FName MapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetPersistentLevelIndexByName", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IncreaseCharacterTapesCollected
    /// </summary>
    public unsafe virtual int IncreaseCharacterTapesCollected(BmSDK.BmGame.RPersistentData.ETapeCharacter CharacterName, BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncreaseCharacterTapesCollected", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetPlayableCharacter
    /// </summary>
    public unsafe virtual void SetPlayableCharacter(BmSDK.FName NewCharacterName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetPlayableCharacter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCharacterName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Struct: FDarkKnightChallengeDEPRC
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FDarkKnightChallengeDEPRC
    {
        /// <summary>
        /// StrProperty: Key
        /// </summary>
        public unsafe BmSDK.FString Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Score
        /// </summary>
        public unsafe float Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: BestScore
        /// </summary>
        public unsafe float BestScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Beaten
        /// </summary>
        public unsafe int Beaten
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FCharacterMissonStatus
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FCharacterMissonStatus
    {
        /// <summary>
        /// ArrayProperty: MissionStatus
        /// </summary>
        public unsafe BmSDK.TArray<int> MissionStatus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FTutorialInfoNew
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FTutorialInfoNew
    {
        /// <summary>
        /// ByteProperty: bPlayerActivated
        /// </summary>
        public unsafe byte bPlayerActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: bAutoActivated
        /// </summary>
        public unsafe byte bAutoActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: bDesignActivated
        /// </summary>
        public unsafe byte bDesignActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// IntProperty: ActionsRequired
        /// </summary>
        public unsafe int ActionsRequired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TotalAchieved
        /// </summary>
        public unsafe int TotalAchieved
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Progress
        /// </summary>
        public unsafe int Progress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FTutorialInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FTutorialInfo
    {
        /// <summary>
        /// ByteProperty: bPlayerActivated
        /// </summary>
        public unsafe byte bPlayerActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: bAutoActivated
        /// </summary>
        public unsafe byte bAutoActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// IntProperty: ActionsRequired
        /// </summary>
        public unsafe int ActionsRequired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TotalAchieved
        /// </summary>
        public unsafe int TotalAchieved
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Progress
        /// </summary>
        public unsafe int Progress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: ETutorialType
    /// </summary>
    public enum ETutorialType : byte
    {
        TUT_None = 0,
        TUT_Combat_Strike = 1,
        TUT_Combat_Counter = 2,
        TUT_Combat_BladeComboCounter = 3,
        TUT_Combat_SuperBladeComboCounter = 4,
        TUT_Combat_Beatdown = 5,
        TUT_Combat_AerialAttack = 6,
        TUT_Combat_DirectedAerialAttack = 7,
        TUT_Combat_Rhythm = 8,
        TUT_Combat_Takedown = 9,
        TUT_Combat_DisarmAndDestroy = 10,
        TUT_Combat_GroupStun = 11,
        TUT_Combat_GroupGroundKO = 12,
        TUT_Combat_GroupTrip = 13,
        TUT_Combat_GroupAttack = 14,
        TUT_Combat_SuperStun = 15,
        TUT_Combat_ComboGroundKO = 16,
        TUT_Combat_BatclawSlam = 17,
        TUT_Thug_Knife = 18,
        TUT_Thug_StunStick = 19,
        TUT_Thug_Armoured = 20,
        TUT_Thug_Shield = 21,
        TUT_Thug_Titan = 22,
        TUT_Thug_ArmouredLieutenant = 23,
        TUT_Thug_MartialArtistDoubleAttack = 24,
        TUT_Thug_MartialArtistComboAttack = 25,
        TUT_Boss_CounterStrikeDeathstroke = 26,
        TUT_Combat_GroundTakedown = 27,
        TUT_Predator_GroundTakedown = 28,
        TUT_Lunatic_GroundTakedown = 29,
        TUT_ShockGloves_Activation = 30,
        TUT_MAX = 31,
    }

    /// <summary>
    /// IntProperty: Version
    /// </summary>
    public unsafe int Version
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// IntProperty: SaveCount
    /// </summary>
    public unsafe int SaveCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StructProperty: PlayerLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PlayerLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 52);

    /// <summary>
    /// StructProperty: PlayerRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator PlayerRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 64);

    /// <summary>
    /// StructProperty: LastDoorData
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastDoorData
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 76);

    /// <summary>
    /// IntProperty: LastDoorRotation
    /// </summary>
    public unsafe int LastDoorRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StrProperty: LastDoorRoom
    /// </summary>
    public unsafe BmSDK.FString LastDoorRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: LevelsLoaded
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LevelsLoaded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: LevelsLoadedNotVisible
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LevelsLoadedNotVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: SeekFreePackagesToLoad
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SeekFreePackagesToLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StrProperty: PersistentLevel
    /// </summary>
    public unsafe BmSDK.FString PersistentLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StrProperty: CurrentLevel
    /// </summary>
    public unsafe BmSDK.FString CurrentLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StrProperty: NextLevel
    /// </summary>
    public unsafe BmSDK.FString NextLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: StreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> StreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: StreamingLevelsLODs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> StreamingLevelsLODs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: FlagNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FlagNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// ArrayProperty: FlagNamesOnLoad
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FlagNamesOnLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// IntProperty: StoryDLCImageId
    /// </summary>
    public unsafe int StoryDLCImageId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// IntProperty: SaveGameChapter
    /// </summary>
    public unsafe int SaveGameChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// IntProperty: SaveGameIndex
    /// </summary>
    public unsafe int SaveGameIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ByteProperty: IsSaveGameStartPoint
    /// </summary>
    public unsafe byte IsSaveGameStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ByteProperty: StorySynopsisState
    /// </summary>
    public unsafe byte StorySynopsisState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 237); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 237); }
    }

    /// <summary>
    /// ByteProperty: DetectiveModeJammed
    /// </summary>
    public unsafe byte DetectiveModeJammed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 238); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 238); }
    }

    /// <summary>
    /// ByteProperty: ARTraining_RaceWins
    /// </summary>
    public unsafe byte ARTraining_RaceWins
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 239); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 239); }
    }

    /// <summary>
    /// ByteProperty: BruceWayneLegChainsBroken
    /// </summary>
    public unsafe byte BruceWayneLegChainsBroken
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ByteProperty: HelpPrompt_GlideTutorialStage
    /// </summary>
    public unsafe byte HelpPrompt_GlideTutorialStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 241); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 241); }
    }

    /// <summary>
    /// ByteProperty: ShowFastTravelTutorial
    /// </summary>
    public unsafe byte ShowFastTravelTutorial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 242); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 242); }
    }

    /// <summary>
    /// ByteProperty: CurrentChapter
    /// </summary>
    public unsafe byte CurrentChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 243); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 243); }
    }

    /// <summary>
    /// ByteProperty: CurrentSubChapter
    /// </summary>
    public unsafe byte CurrentSubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: CurrentSideChapter
    /// </summary>
    public InlineArray<byte> CurrentSideChapter => new(26, Ptr + 245, 1, this);

    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 245); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 245); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 246); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 246); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 247); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 247); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 249); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 249); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 250); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 250); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 251); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 251); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 253); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 253); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 254); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 254); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 255); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 255); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 257); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 257); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 258); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 258); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 259); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 259); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 261); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 261); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 262); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 262); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 263); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 263); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 265); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 265); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 266); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 266); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 267); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 267); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 269); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 269); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 270); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 270); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: CurrentSideSubChapter
    /// </summary>
    public InlineArray<byte> CurrentSideSubChapter => new(26, Ptr + 271, 1, this);

    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 271); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 271); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 273); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 273); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 274); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 274); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 275); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 275); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 277); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 277); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 278); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 278); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 279); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 279); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 281); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 281); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 282); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 282); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 283); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 283); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 285); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 285); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 286); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 286); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 287); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 287); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 289); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 289); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 290); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 290); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 291); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 291); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 293); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 293); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 294); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 294); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 295); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 295); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ByteProperty: ProgressLastStatusUpdated
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter ProgressLastStatusUpdated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 297); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 297); }
    }

    /// <summary>
    /// ByteProperty: Map_CriminalDBIndex
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter Map_CriminalDBIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 298); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 298); }
    }

    /// <summary>
    /// ByteProperty: Bio_LocIndex
    /// </summary>
    public unsafe byte Bio_LocIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 299); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 299); }
    }

    /// <summary>
    /// ByteProperty: Bio_PageIndex
    /// </summary>
    public unsafe byte Bio_PageIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ByteProperty: Bio_TapeIndex
    /// </summary>
    public unsafe byte Bio_TapeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 301); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 301); }
    }

    /// <summary>
    /// ByteProperty: Progress_Index
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter Progress_Index
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 302); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 302); }
    }

    /// <summary>
    /// ByteProperty: Upgrade_CategoryIndex
    /// </summary>
    public unsafe byte Upgrade_CategoryIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 303); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 303); }
    }

    /// <summary>
    /// ByteProperty: Upgrade_ItemIndex
    /// </summary>
    public unsafe byte Upgrade_ItemIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ByteProperty: Riddler_LocIndex
    /// </summary>
    public unsafe byte Riddler_LocIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 305); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 305); }
    }

    /// <summary>
    /// ByteProperty: Riddler_IndexX
    /// </summary>
    public unsafe byte Riddler_IndexX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 306); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 306); }
    }

    /// <summary>
    /// ByteProperty: Riddler_IndexY
    /// </summary>
    public unsafe byte Riddler_IndexY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 307); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 307); }
    }

    /// <summary>
    /// ByteProperty: Enygma_IndexLeft
    /// </summary>
    public unsafe byte Enygma_IndexLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ByteProperty: Enygma_IndexRight
    /// </summary>
    public unsafe byte Enygma_IndexRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 309); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 309); }
    }

    /// <summary>
    /// ByteProperty: ChallengeUnlockIndex
    /// </summary>
    public unsafe byte ChallengeUnlockIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 310); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 310); }
    }

    /// <summary>
    /// ByteProperty: bObjectiveTrackerActive
    /// </summary>
    public unsafe byte bObjectiveTrackerActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 311); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 311); }
    }

    /// <summary>
    /// ByteProperty: CustomWaypoint_Type
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.ECustomWayPointType CustomWaypoint_Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ECustomWayPointType>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// ByteProperty: CustomWaypoint_Character
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter CustomWaypoint_Character
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 313); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 313); }
    }

    /// <summary>
    /// ByteProperty: CustomWaypoint_NotReached
    /// </summary>
    public unsafe byte CustomWaypoint_NotReached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 314); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 314); }
    }

    /// <summary>
    /// ByteProperty: PoisonLevel
    /// </summary>
    public unsafe byte PoisonLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 315); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 315); }
    }

    /// <summary>
    /// ByteProperty: CheckForRiddlerUnlocks
    /// </summary>
    public unsafe byte CheckForRiddlerUnlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ByteProperty: Zsasz_DoneRace0Taunt
    /// </summary>
    public unsafe byte Zsasz_DoneRace0Taunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 317); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 317); }
    }

    /// <summary>
    /// ByteProperty: Zsasz_NewRingingPhone
    /// </summary>
    public unsafe byte Zsasz_NewRingingPhone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 318); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 318); }
    }

    /// <summary>
    /// ByteProperty: Zsasz_DoneRace1Intro
    /// </summary>
    public unsafe byte Zsasz_DoneRace1Intro
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 319); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 319); }
    }

    /// <summary>
    /// ByteProperty: ExplainedBatarangRules
    /// </summary>
    public unsafe byte ExplainedBatarangRules
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// ByteProperty: bPlayedFreezeBlastHint
    /// </summary>
    public unsafe byte bPlayedFreezeBlastHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 321); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 321); }
    }

    /// <summary>
    /// ByteProperty: bPlayedGlueBlastHint
    /// </summary>
    public unsafe byte bPlayedGlueBlastHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 322); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 322); }
    }

    /// <summary>
    /// ByteProperty: GrundyQuickGelHappened
    /// </summary>
    public unsafe byte GrundyQuickGelHappened
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 323); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 323); }
    }

    /// <summary>
    /// ByteProperty: GrundyQuickDetonateHappened
    /// </summary>
    public unsafe byte GrundyQuickDetonateHappened
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ByteProperty: bFakeZsaszPhoneForMap
    /// </summary>
    public unsafe byte bFakeZsaszPhoneForMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 325); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 325); }
    }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StrProperty: SideObjective
    /// </summary>
    public unsafe BmSDK.FString SideObjective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StrProperty: PrimaryObjective
    /// </summary>
    public unsafe BmSDK.FString PrimaryObjective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: LDSetObjective
    /// </summary>
    public unsafe BmSDK.FString LDSetObjective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesIncomplete
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesIncomplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesMapObj
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesMapObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesNewMapObj
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesNewMapObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// IntProperty: ShowRiddlerFlag
    /// </summary>
    public unsafe int ShowRiddlerFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// IntProperty: ShowBioFlag
    /// </summary>
    public unsafe int ShowBioFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// NameProperty: CurrentGadgetName
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgetName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StrProperty: LastScannedLocMap
    /// </summary>
    public unsafe BmSDK.FString LastScannedLocMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StructProperty: LastScannedLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastScannedLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 440);

    /// <summary>
    /// StrProperty: LastAmbientSoundCue
    /// </summary>
    public unsafe BmSDK.FString LastAmbientSoundCue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// StrProperty: LastRoomMixBin
    /// </summary>
    public unsafe BmSDK.FString LastRoomMixBin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// IntProperty: PlayerHealth
    /// </summary>
    public unsafe int PlayerHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// IntProperty: BallisticArmour
    /// </summary>
    public unsafe int BallisticArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// IntProperty: MeleeArmour
    /// </summary>
    public unsafe int MeleeArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// IntProperty: CWBallisticArmour
    /// </summary>
    public unsafe int CWBallisticArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: CWMeleeArmour
    /// </summary>
    public unsafe int CWMeleeArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: ButtonBashDDA
    /// </summary>
    public unsafe float ButtonBashDDA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Strike
    /// </summary>
    public unsafe int HelpPromptCount_Strike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Counter
    /// </summary>
    public unsafe int HelpPromptCount_Counter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Throw
    /// </summary>
    public unsafe int HelpPromptCount_Throw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Takedown
    /// </summary>
    public unsafe int HelpPromptCount_Takedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GroundTakedown
    /// </summary>
    public unsafe int HelpPromptCount_GroundTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_LunaticGroundTakedown
    /// </summary>
    public unsafe int HelpPromptCount_LunaticGroundTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_PredatorGroundTakedown
    /// </summary>
    public unsafe int HelpPromptCount_PredatorGroundTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_ComboBatarang
    /// </summary>
    public unsafe int HelpPromptCount_ComboBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_LineLauncherDrop
    /// </summary>
    public unsafe int HelpPromptCount_LineLauncherDrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_HangModeDrop
    /// </summary>
    public unsafe int HelpPromptCount_HangModeDrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_DropOffGrapple
    /// </summary>
    public unsafe int HelpPromptCount_DropOffGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GlideOffWall
    /// </summary>
    public unsafe int HelpPromptCount_GlideOffWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SixaxisGlide
    /// </summary>
    public unsafe int HelpPromptCount_SixaxisGlide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SixaxisBatarang
    /// </summary>
    public unsafe int HelpPromptCount_SixaxisBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SixaxisTeeth
    /// </summary>
    public unsafe int HelpPromptCount_SixaxisTeeth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: HelpPrompt_TimeGliding
    /// </summary>
    public unsafe float HelpPrompt_TimeGliding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GlideSteerLR
    /// </summary>
    public unsafe int HelpPromptCount_GlideSteerLR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GlideSteerUD
    /// </summary>
    public unsafe int HelpPromptCount_GlideSteerUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_PullUpFromDive
    /// </summary>
    public unsafe int HelpPromptCount_PullUpFromDive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Dive
    /// </summary>
    public unsafe int HelpPromptCount_Dive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GrappleInOW
    /// </summary>
    public unsafe int HelpPromptCount_GrappleInOW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SlideUnderBarrier
    /// </summary>
    public unsafe int HelpPromptCount_SlideUnderBarrier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GrappleBoost
    /// </summary>
    public unsafe int HelpPromptCount_GrappleBoost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_RaftCancel
    /// </summary>
    public unsafe int HelpPromptCount_RaftCancel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: HelpPromptTimer_SteathMove
    /// </summary>
    public unsafe float HelpPromptTimer_SteathMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// IntProperty: NumTimesEscapeHelpDisplayed
    /// </summary>
    public unsafe int NumTimesEscapeHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: NumTimesGrateHelpDisplayed
    /// </summary>
    public unsafe int NumTimesGrateHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// IntProperty: NumTimesGroundTakedownHelpDisplayed
    /// </summary>
    public unsafe int NumTimesGroundTakedownHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: StoryPercentage
    /// </summary>
    public unsafe int StoryPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// IntProperty: CurrentAct
    /// </summary>
    public unsafe int CurrentAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// IntProperty: UpgradesIndex
    /// </summary>
    public unsafe int UpgradesIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ArrayProperty: InterrogationIndexes
    /// </summary>
    public unsafe BmSDK.TArray<int> InterrogationIndexes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ArrayProperty: MapTapeCharactersToBioCharacters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.EBioCharacter> MapTapeCharactersToBioCharacters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.EBioCharacter>>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ArrayProperty: MapBioToProgressCharacters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.EProgressCharacter> MapBioToProgressCharacters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.EProgressCharacter>>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// IntProperty: RadioStationIndexMostRecentlyFound
    /// </summary>
    public unsafe int RadioStationIndexMostRecentlyFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationCurrentSequences
    /// </summary>
    public unsafe BmSDK.TArray<byte> RadioStationCurrentSequences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationBitFields
    /// </summary>
    public unsafe BmSDK.TArray<byte> RadioStationBitFields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationTransmissionStrengths
    /// </summary>
    public unsafe BmSDK.TArray<int> RadioStationTransmissionStrengths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationFrequenciesX
    /// </summary>
    public unsafe BmSDK.TArray<float> RadioStationFrequenciesX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationFrequenciesY
    /// </summary>
    public unsafe BmSDK.TArray<float> RadioStationFrequenciesY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationDetailsTransmitter
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationDetailsTransmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationDetailsEncryptionType
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationDetailsEncryptionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationDetailsEncryptionStrength
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationDetailsEncryptionStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationAudioStateBaseParent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationAudioStateBaseParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationAudioStateBase
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationAudioStateBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationAudioStateCurrentSequenceParent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationAudioStateCurrentSequenceParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationAudioStateCurrentSequence
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationAudioStateCurrentSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ArrayProperty: RadioStationOneShotOverride
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RadioStationOneShotOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterLocation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ProgressCharacterLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterStatus
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterSynopsisTextId
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterSynopsisTextId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterProgressTextId
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterProgressTextId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterPercentage
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterIdentityUnknown
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterIdentityUnknown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterLocked
    /// </summary>
    public unsafe BmSDK.TArray<int> ProgressCharacterLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ArrayProperty: Bio_LocIndexs
    /// </summary>
    public unsafe BmSDK.TArray<int> Bio_LocIndexs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// FloatProperty: Enygma_CooldownTimer
    /// </summary>
    public unsafe float Enygma_CooldownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// StructProperty: vObjectiveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vObjectiveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 932);

    /// <summary>
    /// ArrayProperty: CustomWaypoint
    /// </summary>
    public unsafe BmSDK.TArray<float> CustomWaypoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// StrProperty: CustomWaypointName
    /// </summary>
    public unsafe BmSDK.FString CustomWaypointName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// StrProperty: CustomWaypointTypeName
    /// </summary>
    public unsafe BmSDK.FString CustomWaypointTypeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// StrProperty: RealWaypointName
    /// </summary>
    public unsafe BmSDK.FString RealWaypointName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// StrProperty: CustomWaypoint_VisibleFlag
    /// </summary>
    public unsafe BmSDK.FString CustomWaypoint_VisibleFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// StrProperty: CustomWaypoint_DoneFlag
    /// </summary>
    public unsafe BmSDK.FString CustomWaypoint_DoneFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ArrayProperty: CustomWaypoint_StatesVisible
    /// </summary>
    public unsafe BmSDK.TArray<byte> CustomWaypoint_StatesVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: FacePoisonLevel
    /// </summary>
    public unsafe float FacePoisonLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// NameProperty: PlayableCharacter
    /// </summary>
    public unsafe BmSDK.FName PlayableCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: Zsasz_RingingPhoneIndex
    /// </summary>
    public unsafe int Zsasz_RingingPhoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// IntProperty: Zsasz_NumRacesUnlocked
    /// </summary>
    public unsafe int Zsasz_NumRacesUnlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ArrayProperty: Zsasz_RaceCompleted
    /// </summary>
    public unsafe BmSDK.TArray<byte> Zsasz_RaceCompleted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_Active
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_Active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_Completed
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_Completed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_JackRyder_Active
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_JackRyder_Active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_JackRyder_Completed
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_JackRyder_Completed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceTrails_Name
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EvidenceTrails_Name
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceTrails_Map
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EvidenceTrails_Map
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceTrails_X
    /// </summary>
    public unsafe BmSDK.TArray<int> EvidenceTrails_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceTrails_Y
    /// </summary>
    public unsafe BmSDK.TArray<int> EvidenceTrails_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Name
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DynamicIcons_Name
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Type
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DynamicIcons_Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Map
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DynamicIcons_Map
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_X
    /// </summary>
    public unsafe BmSDK.TArray<int> DynamicIcons_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Y
    /// </summary>
    public unsafe BmSDK.TArray<int> DynamicIcons_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ArrayProperty: Music_Names
    /// </summary>
    public unsafe BmSDK.TArray<int> Music_Names
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ArrayProperty: Music_States
    /// </summary>
    public unsafe BmSDK.TArray<int> Music_States
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ArrayProperty: Music_ParamNames
    /// </summary>
    public unsafe BmSDK.TArray<int> Music_ParamNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ArrayProperty: Music_ParamValues
    /// </summary>
    public unsafe BmSDK.TArray<float> Music_ParamValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// IntProperty: Music_Event
    /// </summary>
    public unsafe int Music_Event
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// IntProperty: RiddlerResonatorAfterCh3Count
    /// </summary>
    public unsafe int RiddlerResonatorAfterCh3Count
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// IntProperty: RiddlerResonatorBeforeCh3Count
    /// </summary>
    public unsafe int RiddlerResonatorBeforeCh3Count
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// IntProperty: NumVanillaGlidesAfterDiveTutorial
    /// </summary>
    public unsafe int NumVanillaGlidesAfterDiveTutorial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// IntProperty: FakeZsaszPhoneForMapIndex
    /// </summary>
    public unsafe int FakeZsaszPhoneForMapIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// IntProperty: NumJewelleryFound
    /// </summary>
    public unsafe int NumJewelleryFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// ArrayProperty: CIPLastEventsStr
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CIPLastEventsStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// IntProperty: LastStoryAssassinDefeated
    /// </summary>
    public unsafe int LastStoryAssassinDefeated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ArrayProperty: BatwingTower_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> BatwingTower_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// ArrayProperty: BatwingTower_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> BatwingTower_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// ArrayProperty: ProgressCharacterMission
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FCharacterMissonStatus> ProgressCharacterMission
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FCharacterMissonStatus>>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ArrayProperty: TutInfoOld
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfo> TutInfoOld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfo>>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ArrayProperty: TutInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfoNew> TutInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfoNew>>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// ArrayProperty: AutomaticCombatTutorials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETutorialType> AutomaticCombatTutorials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETutorialType>>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// IntProperty: NumKnockoutSmashInstructions
    /// </summary>
    public unsafe int NumKnockoutSmashInstructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// IntProperty: NumGrappleBoostFailHints
    /// </summary>
    public unsafe int NumGrappleBoostFailHints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ArrayProperty: informantPriorities__OW_A
    /// </summary>
    public unsafe BmSDK.TArray<int> informantPriorities__OW_A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// ArrayProperty: informantPriorities__OW_C
    /// </summary>
    public unsafe BmSDK.TArray<int> informantPriorities__OW_C
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ArrayProperty: informantPriorities__OW_E
    /// </summary>
    public unsafe BmSDK.TArray<int> informantPriorities__OW_E
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// ArrayProperty: informantMaintainPriority__OW_A
    /// </summary>
    public unsafe BmSDK.TArray<int> informantMaintainPriority__OW_A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// ArrayProperty: informantMaintainPriority__OW_C
    /// </summary>
    public unsafe BmSDK.TArray<int> informantMaintainPriority__OW_C
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// ArrayProperty: informantMaintainPriority__OW_E
    /// </summary>
    public unsafe BmSDK.TArray<int> informantMaintainPriority__OW_E
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// IntProperty: ForensicsFilterTally
    /// </summary>
    public unsafe int ForensicsFilterTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// IntProperty: lastChapterSeenByInformantManager
    /// </summary>
    public unsafe int lastChapterSeenByInformantManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// IntProperty: numMaggotsBataranged
    /// </summary>
    public unsafe int numMaggotsBataranged
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// IntProperty: CWEpisodeReplayState
    /// </summary>
    public unsafe int CWEpisodeReplayState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// IntProperty: bBatmanMinimalHealth
    /// </summary>
    public unsafe int bBatmanMinimalHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// FloatProperty: Alfred_TotalTimePlayedAtLastWisdomBonus
    /// </summary>
    public unsafe float Alfred_TotalTimePlayedAtLastWisdomBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: Alfred_InteractForWisdomBonusCount
    /// </summary>
    public unsafe int Alfred_InteractForWisdomBonusCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// IntProperty: Alfred_TotalInteractCount
    /// </summary>
    public unsafe int Alfred_TotalInteractCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// IntProperty: Alfred_LastInteractChapter
    /// </summary>
    public unsafe int Alfred_LastInteractChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// IntProperty: CrimePrevented
    /// </summary>
    public unsafe int CrimePrevented
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// StrProperty: SaveGameTriggerEventDescription
    /// </summary>
    public unsafe BmSDK.FString SaveGameTriggerEventDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// ArrayProperty: PS3ThemeUnlockList
    /// </summary>
    public unsafe BmSDK.TArray<byte> PS3ThemeUnlockList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// ArrayProperty: PersistentLevelNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PersistentLevelNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// Enum: EBatmanChallenge
    /// </summary>
    public enum EBatmanChallenge : byte
    {
        EBatScore_None = 0,
        EBatScore_GlideDistanceWithoutGrappleBoost = 1,
        EBatScore_GlideDistance = 2,
        EBatScore_DiveHeight = 3,
        EBatScore_GlideSkimOverDistance = 4,
        EBatScore_Combo = 5,
        EBatScore_QuickFireGadgetUsePerCombat = 6,
        EBatScore_ComboVariations = 7,
        EBatScore_DirectedAerialAttack = 8,
        EBatScore_SlideTrip = 9,
        EBatScore_BeatDown = 10,
        EBatScore_CounterProjectile = 11,
        EBatScore_HeldExplosivePreemptiveTakeout = 12,
        EBatScore_GlideBoostAttackTakeOut = 13,
        EBatScore_UsingComboBatarang = 14,
        EBatScore_BatclawSlam = 15,
        EBatScore_ConcussionDetonatorVictims = 16,
        EBatScore_ExplosiveGelVictims = 17,
        EBatScore_DesorientFoesInSmoke = 18,
        EBatScore_DesorientFoesFromStunGrenade = 19,
        EBatScore_ComboBatarangFinish = 20,
        EBatScore_DisarmWithBatClaw = 21,
        EBatScore_GrappleBoostTakedown = 22,
        EBatScore_ReverseBatarangKnockdown = 23,
        EBatScore_SonicBatarangTakedown = 24,
        EBatScore_LineLauncherTakedown = 25,
        EBatScore_InvertedTakedown = 26,
        EBatScore_KnockOutSmash = 27,
        EBatScore_BatarangKnockdown = 28,
        EBatScore_UsingQuickFireGlueGrenade = 29,
        EBatScore_GlueGrenadeVictims = 30,
        EBatScore_TakedownGluedEnemy = 31,
        EBatScore_GlueGrenadeBatarangCombo = 32,
        EBatScore_DefeatArmedThug = 33,
        EBatScore_Takedown = 34,
        EBatScore_WindowOrWallTakedown = 35,
        EBatScore_ComboTakedown = 36,
        EBatScore_HangingTakedown = 37,
        EBatScore_DropAttack = 38,
        EBatScore_DualClawKnockdown = 39,
        EBatScore_BatwingAttack = 40,
        EBatScore_BatwingUpgradeAttack = 41,
        EBatScore_ShockWaveAttack = 42,
        EBatScore_BoostGlideLandHard = 43,
        EBatScore_FlawlessCombat = 44,
        EBatScore_FlawlessPredatorCombat = 45,
        EBatScore_VantagePointEscape = 46,
        EBatScore_Predator_BatmanUnseen = 47,
        EBatScore_Predator_OnlyTakedows = 48,
        EBatScore_Predator_NoDetective = 49,
        EBatScore_Predator_FastRoomClear = 50,
        EBatScore_WeaponDisruptorInPredatorRoom = 51,
        EBatScore_PreventCrimeInProgress = 52,
        EBatScore_ThreatLevelFFC = 53,
        EBatScore_ThreatLevelPredator = 54,
        EBatScore_SimultaneousCounter = 55,
        EBatScore_ShockGloveChargeFromBeatdown = 56,
        EBatScore_GradeXPBonusFFC = 57,
        EBatScore_GradeXPBonusPred = 58,
        EBatScore_WorldsGreatestDetective = 59,
        EBatChal_4 = 60,
        EBatChal_17 = 61,
        EBatChal_19 = 62,
        EBatChal_22 = 63,
        EBatChal_23 = 64,
        EBatChal_24 = 65,
        EBatChal_30 = 66,
        EBatChal_31 = 67,
        EBatChal_35 = 68,
        EBatChal_39 = 69,
        EBatChal_41 = 70,
        EBatChal_42 = 71,
        EBatChal_43 = 72,
        EBatChal_44 = 73,
        EBatChal_45 = 74,
        EBatChal_Max = 75,
        EBatmanChallenge_MAX = 76,
    }

    /// <summary>
    /// Enum: ERiddlerLocationName
    /// </summary>
    public enum ERiddlerLocationName : byte
    {
        RiddlerLoc_Coventry = 0,
        RiddlerLoc_Bowery = 1,
        RiddlerLoc_ParkRow = 2,
        RiddlerLoc_Industrial = 3,
        RiddlerLoc_Burnley = 4,
        RiddlerLoc_Diamond = 5,
        RiddlerLoc_AmusementMile = 6,
        RiddlerLoc_Bridge = 7,
        RiddlerLoc_BridgeInterior = 8,
        RiddlerLoc_Courthouse = 9,
        RiddlerLoc_Church = 10,
        RiddlerLoc_HatShop = 11,
        RiddlerLoc_Bank = 12,
        RiddlerLoc_BaneHQ = 13,
        RiddlerLoc_FinalOffer = 14,
        RiddlerLoc_Steel = 15,
        RiddlerLoc_Hotel = 16,
        RiddlerLoc_GCPD = 17,
        RiddlerLoc_Sewer = 18,
        RiddlerLoc_MyAlibi = 19,
        RiddlerLoc_LaceyTower = 20,
        RiddlerLoc_EnigmaHQ = 21,
        RiddlerLoc_MAX = 22,
    }

    /// <summary>
    /// Enum: EPMapNames
    /// </summary>
    public enum EPMapNames : byte
    {
        PMAP_None = 0,
        PMAP_Overworld = 1,
        PMAP_Court = 2,
        PMAP_Steel = 3,
        PMAP_Church = 4,
        PMAP_Museum = 5,
        PMAP_Under = 6,
        PMAP_GCPD = 7,
        PMAP_MAX = 8,
    }

    /// <summary>
    /// Enum: ECharacterViewer
    /// </summary>
    public enum ECharacterViewer : byte
    {
        EViewer_None = 0,
        EViewer_Batman = 1,
        EViewer_Deathstroke = 2,
        EViewer_Penguin = 3,
        EViewer_Santa_Hat_Thug = 4,
        EViewer_Alberto_Falcone = 5,
        EViewer_Black_Mask = 6,
        EViewer_Tiffany = 7,
        EViewer_Barbara_Gordon = 8,
        EViewer_Cpt_James_Gordon = 9,
        EViewer_Bane_with_Jacket = 10,
        EViewer_Bane_without_Jacket = 11,
        EViewer_Bane_3 = 12,
        EViewer_Harvey_Bullock = 13,
        EViewer_Copperhead = 14,
        EViewer_Firefly = 15,
        EViewer_Deadshot = 16,
        EViewer_Dr_Harleen_Quinzel = 17,
        EViewer_Branden = 18,
        EViewer_Electrocutioner = 19,
        EViewer_Alfred = 20,
        EViewer_Tracy = 21,
        EViewer_Candy = 22,
        EViewer_Bank_Manager = 23,
        EViewer_Roman_Sionis = 24,
        EViewer_Joker = 25,
        EViewer_Red_Hood_Joker = 26,
        EViewer_Anarky = 27,
        EViewer_Killer_Croc = 28,
        EViewer_Lady_Shiva = 29,
        EViewer_Bruce_Wayne = 30,
        EViewer_Bird = 31,
        EViewer_Bane_Thugs = 32,
        EViewer_Black_Mask_Thugs = 33,
        EViewer_Penguin_Thugs = 34,
        EViewer_Gotham_City_Thugs = 35,
        EViewer_Venom_User = 36,
        EViewer_GCPD_Police = 37,
        EViewer_GCPD_Swat = 38,
        EViewer_Lieutenant_Penguin = 39,
        EViewer_Armored_Lieutenant_Black_Mask = 40,
        EViewer_Martial_Artist_Black_Mask = 41,
        EViewer_Mad_Hatter = 42,
        EViewer_Commissioner_Loeb = 43,
        EViewer_Warden_Joseph = 44,
        EViewer_Robin = 45,
        EViewer_Edward_Nashton = 46,
        EViewer_Batman_Abstract_Batman = 47,
        EViewer_Batman_1_millions = 48,
        EViewer_DLC_ASBatman = 49,
        EViewer_DLC_Batman70s = 50,
        EViewer_DLC_BMYearOne = 51,
        EViewer_DLC_BMEarthOne = 52,
        EViewer_DLC_DarkKnight = 53,
        EViewer_DLC_BMBeyond = 54,
        EViewer_DLC_BatmanInc = 55,
        EViewer_DLC_BatmanCorps = 56,
        EViewer_DLC_ASCatwoman = 57,
        EViewer_DLC_CatwomanHalloween = 58,
        EViewer_DLC_ASRobin = 59,
        EViewer_DLC_RedRobin = 60,
        EViewer_DLC_Nightwing = 61,
        EViewer_DLC_ASNightwing = 62,
        EViewer_DLC_GrievingHarley = 63,
        EViewer_DLC_HarleyThugs = 64,
        EViewer_DLC_DeathstrokeJudas = 65,
        EViewer_DLC_Char2 = 66,
        EViewer_DLC_Char3 = 67,
        EViewer_DLC_Char4 = 68,
        EViewer_DLC_Char5 = 69,
        EViewer_DLC_Char6 = 70,
        EViewer_MAX = 71,
    }

    /// <summary>
    /// Enum: EProgressLocations
    /// </summary>
    public enum EProgressLocations : byte
    {
        EPL_Unknown = 0,
        EPL_Outside = 1,
        EPL_MAX = 2,
    }

    /// <summary>
    /// Enum: ECustomWayPointType
    /// </summary>
    public enum ECustomWayPointType : byte
    {
        CustomWayType_Proximity = 0,
        CustomWayType_MapObj = 1,
        CustomWayType_Riddler = 2,
        CustomWayType_SideStory = 3,
        CustomWayType_FastTravel = 4,
        CustomWayType_MAX = 5,
    }

    /// <summary>
    /// Enum: EProgressCharacter
    /// </summary>
    public enum EProgressCharacter : byte
    {
        ProgressCharacter_Enigma = 0,
        ProgressCharacter_Anarky = 1,
        ProgressCharacter_Penguin = 2,
        ProgressCharacter_Deadshot = 3,
        ProgressCharacter_MadHatter = 4,
        ProgressCharacter_Bird = 5,
        ProgressCharacter_BlackGatePrisoner = 6,
        ProgressCharacter_Shiva = 7,
        ProgressCharacter_BlackMask = 8,
        ProgressCharacter_MAX = 9,
    }

    /// <summary>
    /// Enum: EConceptArt
    /// </summary>
    public enum EConceptArt : byte
    {
        ConceptArt_0 = 0,
        ConceptArt_1 = 1,
        ConceptArt_2 = 2,
        ConceptArt_3 = 3,
        ConceptArt_4 = 4,
        ConceptArt_5 = 5,
        ConceptArt_6 = 6,
        ConceptArt_7 = 7,
        ConceptArt_8 = 8,
        ConceptArt_9 = 9,
        ConceptArt_10 = 10,
        ConceptArt_11 = 11,
        ConceptArt_12 = 12,
        ConceptArt_13 = 13,
        ConceptArt_14 = 14,
        ConceptArt_15 = 15,
        ConceptArt_16 = 16,
        ConceptArt_17 = 17,
        ConceptArt_18 = 18,
        ConceptArt_19 = 19,
        ConceptArt_20 = 20,
        ConceptArt_21 = 21,
        ConceptArt_22 = 22,
        ConceptArt_23 = 23,
        ConceptArt_24 = 24,
        ConceptArt_25 = 25,
        ConceptArt_26 = 26,
        ConceptArt_27 = 27,
        ConceptArt_28 = 28,
        ConceptArt_29 = 29,
        ConceptArt_30 = 30,
        ConceptArt_31 = 31,
        ConceptArt_32 = 32,
        ConceptArt_33 = 33,
        ConceptArt_34 = 34,
        ConceptArt_35 = 35,
        ConceptArt_36 = 36,
        ConceptArt_37 = 37,
        ConceptArt_38 = 38,
        ConceptArt_39 = 39,
        ConceptArt_40 = 40,
        ConceptArt_41 = 41,
        ConceptArt_42 = 42,
        ConceptArt_43 = 43,
        ConceptArt_44 = 44,
        ConceptArt_45 = 45,
        ConceptArt_46 = 46,
        ConceptArt_47 = 47,
        ConceptArt_48 = 48,
        ConceptArt_49 = 49,
        ConceptArt_50 = 50,
        ConceptArt_51 = 51,
        ConceptArt_52 = 52,
        ConceptArt_53 = 53,
        ConceptArt_54 = 54,
        ConceptArt_55 = 55,
        ConceptArt_56 = 56,
        ConceptArt_57 = 57,
        ConceptArt_58 = 58,
        ConceptArt_59 = 59,
        ConceptArt_60 = 60,
        ConceptArt_61 = 61,
        ConceptArt_62 = 62,
        ConceptArt_63 = 63,
        ConceptArt_64 = 64,
        ConceptArt_65 = 65,
        ConceptArt_66 = 66,
        ConceptArt_67 = 67,
        ConceptArt_68 = 68,
        ConceptArt_69 = 69,
        ConceptArt_70 = 70,
        ConceptArt_71 = 71,
        ConceptArt_72 = 72,
        ConceptArt_73 = 73,
        ConceptArt_74 = 74,
        ConceptArt_75 = 75,
        ConceptArt_76 = 76,
        ConceptArt_77 = 77,
        ConceptArt_78 = 78,
        ConceptArt_79 = 79,
        ConceptArt_80 = 80,
        ConceptArt_81 = 81,
        ConceptArt_82 = 82,
        ConceptArt_83 = 83,
        ConceptArt_84 = 84,
        ConceptArt_85 = 85,
        ConceptArt_86 = 86,
        ConceptArt_87 = 87,
        ConceptArt_88 = 88,
        ConceptArt_89 = 89,
        ConceptArt_90 = 90,
        ConceptArt_91 = 91,
        ConceptArt_92 = 92,
        ConceptArt_93 = 93,
        ConceptArt_94 = 94,
        ConceptArt_95 = 95,
        ConceptArt_96 = 96,
        ConceptArt_97 = 97,
        ConceptArt_98 = 98,
        ConceptArt_99 = 99,
        ConceptArt_100 = 100,
        ConceptArt_101 = 101,
        ConceptArt_102 = 102,
        ConceptArt_103 = 103,
        ConceptArt_104 = 104,
        ConceptArt_105 = 105,
        ConceptArt_106 = 106,
        ConceptArt_107 = 107,
        ConceptArt_108 = 108,
        ConceptArt_109 = 109,
        ConceptArt_110 = 110,
        ConceptArt_111 = 111,
        ConceptArt_112 = 112,
        ConceptArt_113 = 113,
        ConceptArt_114 = 114,
        ConceptArt_115 = 115,
        ConceptArt_116 = 116,
        ConceptArt_117 = 117,
        ConceptArt_118 = 118,
        ConceptArt_119 = 119,
        ConceptArt_MAX = 120,
    }

    /// <summary>
    /// Enum: EBioCharacterState
    /// </summary>
    public enum EBioCharacterState : byte
    {
        BioState_Normal = 0,
        BioState_Captured = 1,
        BioState_Unknown = 2,
        BioState_MAX = 3,
    }

    /// <summary>
    /// Enum: EBioCharacter
    /// </summary>
    public enum EBioCharacter : byte
    {
        BioCharacter_Batman = 0,
        BioCharacter_Bruce_Wayne = 1,
        BioCharacter_Killer_Croc = 2,
        BioCharacter_Cyrus_Pinkney = 3,
        BioCharacter_Alfred = 4,
        BioCharacter_Comm_Loeb = 5,
        BioCharacter_Warden_Joseph = 6,
        BioCharacter_Black_Mask = 7,
        BioCharacter_Calendar_Man = 8,
        BioCharacter_Electrocutioner = 9,
        BioCharacter_Deadshot = 10,
        BioCharacter_DeathStroke = 11,
        BioCharacter_Shiva = 12,
        BioCharacter_Copperhead = 13,
        BioCharacter_Firefly = 14,
        BioCharacter_Bane = 15,
        BioCharacter_Enigma = 16,
        BioCharacter_Tracey = 17,
        BioCharacter_Alberto_Falcone = 18,
        BioCharacter_Penguin = 19,
        BioCharacter_Candy = 20,
        BioCharacter_Anarky = 21,
        BioCharacter_James_Gordon = 22,
        BioCharacter_Barbara_Gordon = 23,
        BioCharacter_Branden = 24,
        BioCharacter_Mad_Hatter = 25,
        BioCharacter_Joker = 26,
        BioCharacter_Harvey_Bullock = 27,
        BioCharacter_Bird = 28,
        BioCharacter_Harleen_Quinzel = 29,
        BioCharacter_Vicki_Vale = 30,
        BioCharacter_Lefty_Leblanc = 31,
        BioCharacter_MAX = 32,
    }

    /// <summary>
    /// Enum: ETapeCharacter
    /// </summary>
    public enum ETapeCharacter : byte
    {
        Tape_Commissioner_Loeb = 0,
        Tape_Warden_Joseph = 1,
        Tape_Shiva = 2,
        Tape_Bane = 3,
        Tape_Alberto_Falcone = 4,
        Tape_James_Gordon = 5,
        Tape_Branden = 6,
        Tape_Joker = 7,
        Tape_CyrusPinkney = 8,
        Tape_Penguin = 9,
        Tape_Anarky = 10,
        Tape_MAX = 11,
    }

    /// <summary>
    /// Enum: EStorySynopsisId
    /// </summary>
    public enum EStorySynopsisId : byte
    {
        EStorySynopsisId_0 = 0,
        EStorySynopsisId_1 = 1,
        EStorySynopsisId_2 = 2,
        EStorySynopsisId_3 = 3,
        EStorySynopsisId_4 = 4,
        EStorySynopsisId_5 = 5,
        EStorySynopsisId_6 = 6,
        EStorySynopsisId_7 = 7,
        EStorySynopsisId_8 = 8,
        EStorySynopsisId_9 = 9,
        EStorySynopsisId_10 = 10,
        EStorySynopsisId_11 = 11,
        EStorySynopsisId_12 = 12,
        EStorySynopsisId_13 = 13,
        EStorySynopsisId_14 = 14,
        EStorySynopsisId_15 = 15,
        EStorySynopsisId_16 = 16,
        EStorySynopsisId_17 = 17,
        EStorySynopsisId_18 = 18,
        EStorySynopsisId_19 = 19,
        EStorySynopsisId_20 = 20,
        EStorySynopsisId_21 = 21,
        EStorySynopsisId_22 = 22,
        EStorySynopsisId_23 = 23,
        EStorySynopsisId_24 = 24,
        EStorySynopsisId_25 = 25,
        EStorySynopsisId_26 = 26,
        EStorySynopsisId_27 = 27,
        EStorySynopsisId_28 = 28,
        EStorySynopsisId_29 = 29,
        EStorySynopsisId_30 = 30,
        EStorySynopsisId_31 = 31,
        EStorySynopsisId_32 = 32,
        EStorySynopsisId_33 = 33,
        EStorySynopsisId_34 = 34,
        EStorySynopsisId_35 = 35,
        EStorySynopsisId_36 = 36,
        EStorySynopsisId_37 = 37,
        EStorySynopsisId_38 = 38,
        EStorySynopsisId_39 = 39,
        EStorySynopsisId_40 = 40,
        EStorySynopsisId_41 = 41,
        EStorySynopsisId_42 = 42,
        EStorySynopsisId_43 = 43,
        EStorySynopsisId_44 = 44,
        EStorySynopsisId_45 = 45,
        EStorySynopsisId_46 = 46,
        EStorySynopsisId_47 = 47,
        EStorySynopsisId_48 = 48,
        EStorySynopsisId_49 = 49,
        EStorySynopsisId_50 = 50,
        EStorySynopsisId_51 = 51,
        EStorySynopsisId_52 = 52,
        EStorySynopsisId_53 = 53,
        EStorySynopsisId_54 = 54,
        EStorySynopsisId_55 = 55,
        EStorySynopsisId_56 = 56,
        EStorySynopsisId_57 = 57,
        EStorySynopsisId_58 = 58,
        EStorySynopsisId_59 = 59,
        EStorySynopsisId_60 = 60,
        EStorySynopsisId_61 = 61,
        EStorySynopsisId_62 = 62,
        EStorySynopsisId_63 = 63,
        EStorySynopsisId_64 = 64,
        EStorySynopsisId_65 = 65,
        EStorySynopsisId_66 = 66,
        EStorySynopsisId_67 = 67,
        EStorySynopsisId_68 = 68,
        EStorySynopsisId_69 = 69,
        EStorySynopsisId_70 = 70,
        EStorySynopsisId_71 = 71,
        EStorySynopsisId_72 = 72,
        EStorySynopsisId_MAX = 73,
    }

    /// <summary>
    /// Enum: PDVersion
    /// </summary>
    public enum PDVersion : byte
    {
        PDVer_Initial = 0,
        PDVer_XPLevel = 1,
        PDVer_PercentageCompleted = 2,
        PDVer_StoryPercentage = 3,
        PDVer_UpgradesBought = 4,
        PDVer_ExtraProfileStrings = 5,
        PDVer_LevelsLoadedNotVisible = 6,
        PDVer_NextLevel = 7,
        PDVer_StoreButtonBashMod = 8,
        PDVer_MovedChallengeDataToOptions = 9,
        PDVer_CharacterViewer = 10,
        PDVer_MapKeyFlags = 11,
        PDVer_RemovedChallengeArrays = 12,
        PDVer_MovedNewArrays = 13,
        PDVer_CombatMovePrompts = 14,
        PDVer_UpgradesNew = 15,
        PDVer_LunaticGroundPrompt = 16,
        PDVer_ComboBatarangPrompt = 17,
        PDVer_LineLaunchPrompt = 18,
        PDVer_MovedExtraStrings = 19,
        PDVer_NewObjectivesList = 20,
        PDVer_PredatorGroundPrompt = 21,
        PDVer_UpgradesIndex = 22,
        PDVer_GrateTutorial = 23,
        PDVer_HangDropTutorial = 24,
        PDVer_TapesCollected = 25,
        PDVer_RemoveRiddlerSecretsTotal = 26,
        PDVer_LastDoorVector = 27,
        PDVer_MoveBiosAgain = 28,
        PDVer_SavedRoom = 29,
        PDVer_SixaxisTutorial = 30,
        PDVer_Mixbin = 31,
        PDVer_DetectiveJamming = 32,
        PDVer_InterrogationArrays = 33,
        PDVer_RadioStations = 34,
        PDVer_StreamingLevels = 35,
        PDVer_PickupCount = 36,
        PDVer_ObjectiveTracking = 37,
        PDVer_AddedPlayableChar = 38,
        PDVer_AddedRadioAudioStates = 39,
        PDVer_AddedCharacterProgress = 40,
        PDVer_RiddlerData = 41,
        PDVer_CustomWaypoint = 42,
        PDVer_GalleryUnlocks = 43,
        PDVer_BackScreen = 44,
        PDVer_DroneTrails = 45,
        PDVer_PoisonedHealthBar = 46,
        PDVer_ProgressNameUnknown = 47,
        PDVer_ProgressPercentage = 48,
        PDVer_ProgressTextIds = 49,
        PDVer_ZsaszPhones = 50,
        PDVer_RiddlerData2 = 51,
        PDVer_PlayOnceRadioStations = 52,
        PDVer_AddedTrailItems = 53,
        PDVer_OWTutorials = 54,
        PDVer_GrappleBoostTutorial = 55,
        PDVer_PickupReveals = 56,
        PDVer_Zsasz_NewRingingPhone = 57,
        PDVer_Tutorial = 58,
        PDVer_WaypointNames = 59,
        PDVer_TrackingCams = 60,
        PDVer_UpgradeVars = 61,
        PDVer_CatwomanJewellery = 62,
        PDVer_PoisonFaceLevel = 63,
        PDVer_Music = 64,
        PDVer_EnygmaData = 65,
        PDVer_DynamicMapIcons1 = 66,
        PDVer_Armour = 67,
        PDVer_StorySynopsisState = 68,
        PDVer_CatwomanEpisodes = 69,
        PDVer_BullyEncounters = 70,
        PDVer_ReplayInfo = 71,
        PDVer_MovedStuff1 = 72,
        PDVer_BruceWayneLegChains = 73,
        PDVer_ZsaszPhones2 = 74,
        PDVer_StealthTutorial = 75,
        PDVer_MusicParams = 76,
        PDVer_Chapter = 77,
        PDVer_JokerBalloons = 78,
        PDVer_ExplainedBatarangRules = 79,
        PDVer_DropOffGrapplePrompt = 80,
        PDVer_SeekFreePackages = 81,
        PDVer_BreakablePenguins = 82,
        PDVer_RiddlerData3 = 83,
        PDVer_RiddlerData4 = 84,
        PDVer_GroundTakedownTutorial = 85,
        PDVer_CityStories = 86,
        PDVer_ChallengeUnlockIndex = 87,
        PDVer_CantThrowFromFreezePlatform = 88,
        PDVer_MovedCityStories = 89,
        PDVer_ARTraining_RaceWins = 90,
        PDVer_CW_UpgradesBought = 91,
        PDVer_BullyEncounters_JackRyder = 92,
        PDVer_EnygmaData1 = 93,
        PDVer_PickupReveals2 = 94,
        PDVer_RiddlerResonator = 95,
        PDVer_KOSmashInstructions = 96,
        PDVer_GlideOffWallPrompt = 97,
        PDVer_MapUserMarkerExtension = 98,
        PDVer_GrappleBoostHints = 99,
        PDVer_WaypointTypeName = 100,
        PDVer_InformantManager = 101,
        PDVer_BrokenHarleyHeadTally = 102,
        PDVer_BatChallengeData = 103,
        PDVer_BrokenCameras = 104,
        PDVer_CheckForRiddlerUnlocks = 105,
        PDVer_GrundyHelpText = 106,
        PDVer_RadioStationOverrides = 107,
        PDVer_BrokenDemonSealTally = 108,
        PDVer_SideObjective = 109,
        PDVer_CWPicks = 110,
        PDVer_CWArmour = 111,
        PDVer_RemoveDroneTrails = 112,
        PDVer_SecuROMCheckData = 113,
        PDVer_GrundyMaggots = 114,
        PDVer_RiddlerRows = 115,
        PDVer_BioIndexChange = 116,
        PDVer_RaftCancel = 117,
        PDVer_TrackNumVanillaGlides = 118,
        PDVer_EliminatedReplayVars = 119,
        PDVer_FakeZsaszPhoneForMap = 120,
        PDVer_DesignTriggeredTutorials = 121,
        PDVer_InterrogationTutorial = 122,
        PDVer_ZsaszFakeMapPhone2 = 123,
        PDVer_MovedStuffForNGPShare = 124,
        PDVer_MovedStuffForNGPShare2 = 125,
        PDVer_StoryDLC = 126,
        PDVer_CustomReached = 127,
        PDVer_ProgressLastStatusUpdated = 128,
        PDVer_CWEpisodeReplay = 129,
        PDVer_PlayerMinimalHealth = 130,
        PDVer_GlueGrenade = 131,
        PDVer_DynamicEvents = 132,
        PDVer_DeathstrokePhase = 133,
        PDVer_AlfredWisdomBonus = 134,
        PDVer_CrimePrevented = 135,
        PDVer_DarkKnightChallenges = 136,
        PDVer_DeathstrokePhaseRemoved = 137,
        PDVer_SaveCurrentMusicEvent = 138,
        PDVer_SaveGameTriggerEventDescription = 139,
        PDVer_ActSystem = 140,
        PDVer_CIPLastEvents = 141,
        PDVer_MovedDarkKnightChallengesToShared = 142,
        PDVer_MovedTotalTimeToShared = 143,
        PDVer_CIPLastEventsStr = 144,
        PDVer_FastTravelTutorial = 145,
        PDVer_PrimaryObjectiveCache = 146,
        PDVer_LastStoryAssassinDefeated = 147,
        PDVer_ProgressCharacterMission = 148,
        PDVer_Themes = 149,
        PDVer_MovingTowersToPersistentData = 150,
        PDVer_MAX = 151,
    }
}
