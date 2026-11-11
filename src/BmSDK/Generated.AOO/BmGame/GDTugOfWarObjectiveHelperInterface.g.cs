#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: GDTugOfWarObjectiveHelperInterface<br/>
/// (size = 48)
/// (flags = 49171)
/// </summary>
public partial interface GDTugOfWarObjectiveHelperInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: RegisterObjectiveMatinee
    /// </summary>
    public unsafe void RegisterObjectiveMatinee(BmSDK.BmGame.GDSeqAct_ObjectiveInterp ObjectiveMatinee);

    /// <summary>
    /// Function: OnObjectiveReset
    /// </summary>
    public unsafe void OnObjectiveReset();

    /// <summary>
    /// Function: OnObjectiveComplete
    /// </summary>
    public unsafe void OnObjectiveComplete();

    /// <summary>
    /// Function: OnObjectiveActivated
    /// </summary>
    public unsafe void OnObjectiveActivated(BmSDK.BmGame.GDTugOfWarObjective ObjectiveOwner);
}
