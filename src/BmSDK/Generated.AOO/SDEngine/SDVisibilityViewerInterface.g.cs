#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Interface: SDVisibilityViewerInterface<br/>
/// (size = 48)
/// (flags = 134267027)
/// </summary>
public partial interface SDVisibilityViewerInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: VisibilityViewerGetRange
    /// </summary>
    public unsafe float VisibilityViewerGetRange();

    /// <summary>
    /// Function: VisibilityViewerGetHorizontalFOV
    /// </summary>
    public unsafe float VisibilityViewerGetHorizontalFOV();

    /// <summary>
    /// Function: VisibilityViewerGetAspectRatio
    /// </summary>
    public unsafe float VisibilityViewerGetAspectRatio();

    /// <summary>
    /// Function: VisibilityViewerGetRotation
    /// </summary>
    public unsafe BmSDK.Rotator VisibilityViewerGetRotation();

    /// <summary>
    /// Function: VisibilityViewerGetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 VisibilityViewerGetLocation();

    /// <summary>
    /// Function: VisibilityViewerGetHandle
    /// </summary>
    public unsafe int VisibilityViewerGetHandle();

    /// <summary>
    /// Function: VisibilityViewerSetHandle
    /// </summary>
    public unsafe void VisibilityViewerSetHandle(int ViewerHandle);
}
