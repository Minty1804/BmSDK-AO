#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RJammerInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RJammerInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetCommsJammedMovieString
    /// </summary>
    public unsafe BmSDK.FString GetCommsJammedMovieString();

    /// <summary>
    /// Function: CanJamComms
    /// </summary>
    public unsafe bool CanJamComms();

    /// <summary>
    /// Function: IsActiveJamer
    /// </summary>
    public unsafe bool IsActiveJamer();

    /// <summary>
    /// Function: OnForensicDeviceLevelChange
    /// </summary>
    public unsafe void OnForensicDeviceLevelChange();

    /// <summary>
    /// Function: CanSendJammerToHud
    /// </summary>
    public unsafe bool CanSendJammerToHud();

    /// <summary>
    /// Function: GetJammerLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetJammerLocation();

    /// <summary>
    /// Function: GetParameterInterference
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GetParameterInterference();

    /// <summary>
    /// Function: GetParameterAngle
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GetParameterAngle();
}
