#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_NavMeshPathObstacle<br/>
/// (size = 48)
/// (flags = 134267027)
/// </summary>
public partial interface Interface_NavMeshPathObstacle : BmSDK.Interface
{
    /// <summary>
    /// Enum: EEdgeHandlingStatus
    /// </summary>
    public enum EEdgeHandlingStatus : byte
    {
        EHS_AddedBothDirs = 0,
        EHS_Added0to1 = 1,
        EHS_Added1to0 = 2,
        EHS_AddedNone = 3,
        EHS_MAX = 4,
    }
}
