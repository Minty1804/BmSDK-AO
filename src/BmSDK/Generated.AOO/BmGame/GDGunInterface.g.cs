#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: GDGunInterface<br/>
/// (size = 48)
/// (flags = 49171)
/// </summary>
public partial interface GDGunInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetOwningPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer GetOwningPawn();
}
