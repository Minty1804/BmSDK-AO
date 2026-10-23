#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Interface: MShivaBossInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface MShivaBossInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetShivaAttackPriorityOffset
    /// </summary>
    public unsafe int GetShivaAttackPriorityOffset();

    /// <summary>
    /// Function: GoToNextPhase
    /// </summary>
    public unsafe void GoToNextPhase();

    /// <summary>
    /// Function: PrepareNextPhase
    /// </summary>
    public unsafe void PrepareNextPhase();

    /// <summary>
    /// Function: SwapOut
    /// </summary>
    public unsafe void SwapOut();

    /// <summary>
    /// Function: SwapIn
    /// </summary>
    public unsafe void SwapIn(BmSDK.BmGame.RPawnVillain Other);

    /// <summary>
    /// Function: CanBecomeInactive
    /// </summary>
    public unsafe bool CanBecomeInactive();

    /// <summary>
    /// Function: IsBossActive
    /// </summary>
    public unsafe bool IsBossActive();
}
