#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: GDXRayInterface<br/>
/// (size = 48)
/// (flags = 134267027)
/// </summary>
public partial interface GDXRayInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: SetXRayOpacitySkillBased
    /// </summary>
    public unsafe void SetXRayOpacitySkillBased(bool bEnable);

    /// <summary>
    /// Function: ExitXRayMode
    /// </summary>
    public unsafe void ExitXRayMode();

    /// <summary>
    /// Function: ApplyXRayParameters
    /// </summary>
    public unsafe void ApplyXRayParameters(BmSDK.BmGame.GDXRayParameters Params);

    /// <summary>
    /// Function: GetOwningPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer GetOwningPawn();
}
