#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: GDDisruptableObjectiveHelperInterface<br/>
/// (size = 48)
/// (flags = 49171)
/// </summary>
public partial interface GDDisruptableObjectiveHelperInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ObjectiveDisrupted
    /// </summary>
    public unsafe void ObjectiveDisrupted();

    /// <summary>
    /// Function: DoScramblePulse
    /// </summary>
    public unsafe void DoScramblePulse();

    /// <summary>
    /// Function: ScramblerDestroyed
    /// </summary>
    public unsafe void ScramblerDestroyed();

    /// <summary>
    /// Function: StartScramble
    /// </summary>
    public unsafe void StartScramble(BmSDK.Engine.Actor Scrambler);
}
