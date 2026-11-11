#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Interface: SDVisibilityTargetInterface<br/>
/// (size = 48)
/// (flags = 134267027)
/// </summary>
public partial interface SDVisibilityTargetInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: VisibilityTargetGetBounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds VisibilityTargetGetBounds();

    /// <summary>
    /// Function: VisibilityTargetGetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 VisibilityTargetGetLocation();
}
