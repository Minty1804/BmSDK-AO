#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Interface: MFreezeGunShooterInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface MFreezeGunShooterInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: SetShouldForceBeatdownEnd
    /// </summary>
    public unsafe void SetShouldForceBeatdownEnd();

    /// <summary>
    /// Function: GetOverrideTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor GetOverrideTarget();

    /// <summary>
    /// Function: SetOverrideTarget
    /// </summary>
    public unsafe void SetOverrideTarget(BmSDK.Engine.Actor ATarget);

    /// <summary>
    /// Function: HandleObstructedLineOfFire
    /// </summary>
    public unsafe void HandleObstructedLineOfFire(System.Numerics.Vector3 ObstructedLocation);

    /// <summary>
    /// Function: GetHitTimeToFreezePlayer
    /// </summary>
    public unsafe float GetHitTimeToFreezePlayer();

    /// <summary>
    /// Function: ForceWeaponStop
    /// </summary>
    public unsafe void ForceWeaponStop();

    /// <summary>
    /// Function: NotifyFreezeVillain
    /// </summary>
    public unsafe void NotifyFreezeVillain(BmSDK.Engine.Actor HitActor, System.Numerics.Vector3 HitPosition, System.Numerics.Vector3 HitNormal);
}
