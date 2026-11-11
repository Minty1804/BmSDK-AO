#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: GDUnlockableItemInterface<br/>
/// (size = 48)
/// (flags = 49171)
/// </summary>
public partial interface GDUnlockableItemInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetRelevantWeaponId
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.WeaponId GetRelevantWeaponId();

    /// <summary>
    /// Function: GetUnlockableItemComponent
    /// </summary>
    public unsafe BmSDK.BmGame.GDUnlockableItemComponent GetUnlockableItemComponent();
}
