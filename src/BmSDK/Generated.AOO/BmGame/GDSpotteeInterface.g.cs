#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: GDSpotteeInterface<br/>
/// (size = 48)
/// (flags = 134267027)
/// </summary>
public partial interface GDSpotteeInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetSpotteeComponent
    /// </summary>
    public unsafe BmSDK.BmGame.GDSpotteeComponent GetSpotteeComponent(BmSDK.BmGame.RPawn Spotter);
}
