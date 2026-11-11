#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: GDSpeakerInterface<br/>
/// (size = 48)
/// (flags = 134267027)
/// </summary>
public partial interface GDSpeakerInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetTeam
    /// </summary>
    public unsafe BmSDK.Engine.TeamInfo GetTeam();

    /// <summary>
    /// Function: GetVoiceName
    /// </summary>
    public unsafe BmSDK.FName GetVoiceName();

    /// <summary>
    /// Function: GetVoiceNameOther
    /// </summary>
    public unsafe BmSDK.FName GetVoiceNameOther();
}
