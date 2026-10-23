#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: MDualClawAttachable<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface MDualClawAttachable : BmSDK.Interface
{
    /// <summary>
    /// Function: IsForcedLowEntry
    /// </summary>
    public unsafe bool IsForcedLowEntry();

    /// <summary>
    /// Function: IsForcedZipline
    /// </summary>
    public unsafe bool IsForcedZipline();

    /// <summary>
    /// Function: SetCanZipline
    /// </summary>
    public unsafe void SetCanZipline(bool Value);

    /// <summary>
    /// Function: CanZipLine
    /// </summary>
    public unsafe bool CanZipLine();

    /// <summary>
    /// Function: DetachDualClawCluster
    /// </summary>
    public unsafe void DetachDualClawCluster(BmSDK.BmGame.MDualClawClusterProjectile DualClawCluster);

    /// <summary>
    /// Function: AttachDualClawCluster
    /// </summary>
    public unsafe void AttachDualClawCluster(BmSDK.BmGame.MDualClawClusterProjectile DualClawCluster);
}
