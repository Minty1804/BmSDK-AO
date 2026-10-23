#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkComponentSettings<br/>
/// (size = 296)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_AkComponentSettings : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkComponentSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SeqAct_AkComponentSettings.
    /// </summary>
    public static SeqAct_AkComponentSettings DefaultObject => (SeqAct_AkComponentSettings)StaticClass().DefaultObject;

    internal SeqAct_AkComponentSettings() { }

    /// <summary>
    /// Constructs a new SeqAct_AkComponentSettings
    /// </summary>
    public SeqAct_AkComponentSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkComponentSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkComponentSettings(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SeqAct_AkComponentSettings>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SeqAct_AkComponentSettings>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SeqAct_AkComponentSettings>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SeqAct_AkComponentSettings>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SeqAct_AkComponentSettings>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SeqAct_AkComponentSettings>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SeqAct_AkComponentSettings>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SeqAct_AkComponentSettings>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: LifetimeEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LifetimeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ByteProperty: AutoPlayLifetimeEvent
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool AutoPlayLifetimeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ByteProperty: NeverAutoDestroySource
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool NeverAutoDestroySource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 229); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 229); }
    }

    /// <summary>
    /// ByteProperty: AlwaysAutoCreateSource
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool AlwaysAutoCreateSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 230); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 230); }
    }

    /// <summary>
    /// ByteProperty: AutoDestroySourceWhenHidden
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool AutoDestroySourceWhenHidden
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 231); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 231); }
    }

    /// <summary>
    /// ByteProperty: AutoDestroySourceWhenDead
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool AutoDestroySourceWhenDead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ByteProperty: KillSoundsOnDestroy
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool KillSoundsOnDestroy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 233); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 233); }
    }

    /// <summary>
    /// ByteProperty: CameraDistanceParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool CameraDistanceParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 234); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 234); }
    }

    /// <summary>
    /// ByteProperty: CameraOffsetParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool CameraOffsetParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 235); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 235); }
    }

    /// <summary>
    /// ByteProperty: CameraAngleParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool CameraAngleParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ByteProperty: PlayerDistanceParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool PlayerDistanceParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 237); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 237); }
    }

    /// <summary>
    /// ByteProperty: PlayerOffsetParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool PlayerOffsetParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 238); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 238); }
    }

    /// <summary>
    /// ByteProperty: PlayerAngleParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool PlayerAngleParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 239); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 239); }
    }

    /// <summary>
    /// ByteProperty: ObjectVelocityParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool ObjectVelocityParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ByteProperty: Enable2DMode
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool Enable2DMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 241); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 241); }
    }

    /// <summary>
    /// ByteProperty: DialogueMeter
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool DialogueMeter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 242); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 242); }
    }

    /// <summary>
    /// ByteProperty: Occlusion
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool Occlusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 243); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 243); }
    }

    /// <summary>
    /// ByteProperty: ParameterOnlyOcclusion
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool ParameterOnlyOcclusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ByteProperty: UseDistanceBasedInterpolation
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool UseDistanceBasedInterpolation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 245); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 245); }
    }

    /// <summary>
    /// ByteProperty: PrimaryListener
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsListenerID PrimaryListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsListenerID>(Ptr + 246); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 246); }
    }

    /// <summary>
    /// ObjectProperty: DialogueMeterEffect
    /// </summary>
    public unsafe BmSDK.Engine.AkEnvironmentName DialogueMeterEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEnvironmentName>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: OcclusionInterpolationDistance
    /// </summary>
    public unsafe float OcclusionInterpolationDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: OcclusionUpdateTimeFast
    /// </summary>
    public unsafe float OcclusionUpdateTimeFast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: OcclusionUpdateTimeSlow
    /// </summary>
    public unsafe float OcclusionUpdateTimeSlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: OcclusionInterpolationTime
    /// </summary>
    public unsafe float OcclusionInterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: OcclusionScalingDistance
    /// </summary>
    public unsafe float OcclusionScalingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplier
    /// </summary>
    public unsafe float OcclusionMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplierAux
    /// </summary>
    public unsafe float OcclusionMultiplierAux
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: WetDryMixVolume
    /// </summary>
    public unsafe float WetDryMixVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// FloatProperty: WetDryMixVolumeAux
    /// </summary>
    public unsafe float WetDryMixVolumeAux
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: FalloffRadiusMultiplier
    /// </summary>
    public unsafe float FalloffRadiusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// FloatProperty: FalloffEnhancement
    /// </summary>
    public unsafe float FalloffEnhancement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// Enum: EAkComponentSettingsListenerID
    /// </summary>
    public enum EAkComponentSettingsListenerID : byte
    {
        AK_SETTING_LISTENER_PLAYER_1 = 0,
        AK_SETTING_LISTENER_CAMERA_1 = 1,
        AK_SETTING_LISTENER_COMPOSITE_1 = 2,
        AK_SETTING_LISTENER_UNCHANGED = 3,
        AK_SETTING_LISTENER_MAX = 4,
    }

    /// <summary>
    /// Enum: EAkComponentSettingsBool
    /// </summary>
    public enum EAkComponentSettingsBool : byte
    {
        AK_SETTING_UNCHANGED = 0,
        AK_SETTING_TRUE = 1,
        AK_SETTING_FALSE = 2,
        AK_SETTING_MAX = 3,
    }
}
