#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_Speaker<br/>
/// (size = 48)
/// (flags = 134267027)
/// </summary>
public partial interface Interface_Speaker : BmSDK.Interface
{
    /// <summary>
    /// Function: Speak
    /// </summary>
    public unsafe void Speak(BmSDK.Engine.SoundCue Cue);
}
