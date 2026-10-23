#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: MDualClawInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface MDualClawInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetAttachBoneNameForPawn
    /// </summary>
    public unsafe BmSDK.FName GetAttachBoneNameForPawn(BmSDK.BmGame.RPawnCombat toVictim, BmSDK.Engine.Actor fromActor);

    /// <summary>
    /// Function: StopFireSoundWithCam
    /// </summary>
    public unsafe void StopFireSoundWithCam();

    /// <summary>
    /// Function: GetDualClawMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent GetDualClawMesh();

    /// <summary>
    /// Function: GetHidePointWireClass
    /// </summary>
    public unsafe BmSDK.Class GetHidePointWireClass();

    /// <summary>
    /// Function: StopDualClawClusterFollowCam
    /// </summary>
    public unsafe void StopDualClawClusterFollowCam();

    /// <summary>
    /// Function: GetDualClawConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase GetDualClawConfig();

    /// <summary>
    /// Function: GetAimingPositionFromTarget
    /// </summary>
    public unsafe void GetAimingPositionFromTarget(BmSDK.Engine.Actor Target, int socketIndex, out System.Numerics.Vector3 AimPos, out BmSDK.FName aimSocket);

    /// <summary>
    /// Function: GetGadgetConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase GetGadgetConfig();

    /// <summary>
    /// Function: GetDualClawProjectileClass
    /// </summary>
    public unsafe BmSDK.Class GetDualClawProjectileClass();

    /// <summary>
    /// Function: FailedReachedDest
    /// </summary>
    public unsafe void FailedReachedDest(BmSDK.BmGame.MDualClawClusterProjectile DualClawClusterProjectile);

    /// <summary>
    /// Function: RemoveDualClawProjectile
    /// </summary>
    public unsafe bool RemoveDualClawProjectile(BmSDK.BmGame.MDualClawClusterProjectile DualClawClusterProjectile);
}
