#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: MGlitchesInterface<br/>
/// (size = 44)
/// (flags = 134234259)
/// </summary>
public partial interface MGlitchesInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetDisplayName
    /// </summary>
    public unsafe BmSDK.FName GetDisplayName();

    /// <summary>
    /// Function: SetGlitchesController
    /// </summary>
    public unsafe void SetGlitchesController(BmSDK.BmGame.MGlitchesController cont);

    /// <summary>
    /// Function: GetGlitchLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetGlitchLocation();

    /// <summary>
    /// Function: SetIsEnabled
    /// </summary>
    public unsafe void SetIsEnabled(bool IsEnabled);

    /// <summary>
    /// Function: GetIsEnabled
    /// </summary>
    public unsafe bool GetIsEnabled();

    /// <summary>
    /// Function: ResetChainAndToggleTop
    /// </summary>
    public unsafe void ResetChainAndToggleTop(bool Activate);

    /// <summary>
    /// Function: IsChainCurrentlyActivated
    /// </summary>
    public unsafe bool IsChainCurrentlyActivated();

    /// <summary>
    /// Function: StopChain
    /// </summary>
    public unsafe void StopChain();

    /// <summary>
    /// Function: EnableChain
    /// </summary>
    public unsafe void EnableChain(bool bEnabled);

    /// <summary>
    /// Function: SetCurrentlyActive
    /// </summary>
    public unsafe void SetCurrentlyActive(bool Activate);

    /// <summary>
    /// Function: IsCurrentlyActive
    /// </summary>
    public unsafe bool IsCurrentlyActive();

    /// <summary>
    /// Function: IsParent
    /// </summary>
    public unsafe bool IsParent();

    /// <summary>
    /// Function: GetTop
    /// </summary>
    public unsafe BmSDK.BmGame.MGlitchesInterface GetTop();

    /// <summary>
    /// Function: GetPrev
    /// </summary>
    public unsafe BmSDK.BmGame.MGlitchesInterface GetPrev();

    /// <summary>
    /// Function: GetNext
    /// </summary>
    public unsafe BmSDK.BmGame.MGlitchesInterface GetNext();

    /// <summary>
    /// Function: Toggle
    /// </summary>
    public unsafe bool Toggle(bool bActivate);

    /// <summary>
    /// Function: UnRegisterGlitch
    /// </summary>
    public unsafe bool UnRegisterGlitch();

    /// <summary>
    /// Function: RegisterGlitch
    /// </summary>
    public unsafe bool RegisterGlitch();
}
