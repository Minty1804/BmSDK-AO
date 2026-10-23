#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineSystemInterface<br/>
/// (size = 116)
/// (flags = 16403)
/// </summary>
public partial interface OnlineSystemInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearThemeInstallCompleteDelegate
    /// </summary>
    public unsafe void ClearThemeInstallCompleteDelegate(System.IntPtr ThemeInstallCompleteDelegate);

    /// <summary>
    /// Function: AddThemeInstallCompleteDelegate
    /// </summary>
    public unsafe void AddThemeInstallCompleteDelegate(System.IntPtr ThemeInstallCompleteDelegate);

    /// <summary>
    /// Function: InstallTheme
    /// </summary>
    public unsafe bool InstallTheme(BmSDK.FString ThemeFilepath);

    /// <summary>
    /// Function: OnThemeInstallComplete
    /// </summary>
    public unsafe void OnThemeInstallComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ClearStorageDeviceChangeDelegate
    /// </summary>
    public unsafe void ClearStorageDeviceChangeDelegate(System.IntPtr StorageDeviceChangeDelegate);

    /// <summary>
    /// Function: AddStorageDeviceChangeDelegate
    /// </summary>
    public unsafe void AddStorageDeviceChangeDelegate(System.IntPtr StorageDeviceChangeDelegate);

    /// <summary>
    /// Function: OnStorageDeviceChange
    /// </summary>
    public unsafe void OnStorageDeviceChange();

    /// <summary>
    /// Function: ClearConnectionStatusChangeDelegate
    /// </summary>
    public unsafe void ClearConnectionStatusChangeDelegate(System.IntPtr ConnectionStatusDelegate);

    /// <summary>
    /// Function: AddConnectionStatusChangeDelegate
    /// </summary>
    public unsafe void AddConnectionStatusChangeDelegate(System.IntPtr ConnectionStatusDelegate);

    /// <summary>
    /// Function: OnConnectionStatusChange
    /// </summary>
    public unsafe void OnConnectionStatusChange(BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ConnectionStatus);

    /// <summary>
    /// Function: IsControllerConnected
    /// </summary>
    public unsafe bool IsControllerConnected(int ControllerId);

    /// <summary>
    /// Function: ClearControllerChangeDelegate
    /// </summary>
    public unsafe void ClearControllerChangeDelegate(System.IntPtr ControllerChangeDelegate);

    /// <summary>
    /// Function: AddControllerChangeDelegate
    /// </summary>
    public unsafe void AddControllerChangeDelegate(System.IntPtr ControllerChangeDelegate);

    /// <summary>
    /// Function: OnControllerChange
    /// </summary>
    public unsafe void OnControllerChange(int ControllerId, bool bIsConnected);

    /// <summary>
    /// Function: ClearExternalUIChangeDelegate
    /// </summary>
    public unsafe void ClearExternalUIChangeDelegate(System.IntPtr ExternalUIDelegate);

    /// <summary>
    /// Function: AddExternalUIChangeDelegate
    /// </summary>
    public unsafe void AddExternalUIChangeDelegate(System.IntPtr ExternalUIDelegate);

    /// <summary>
    /// Function: OnExternalUIChange
    /// </summary>
    public unsafe void OnExternalUIChange(bool bIsOpening);

    /// <summary>
    /// Function: ClearLinkStatusChangeDelegate
    /// </summary>
    public unsafe void ClearLinkStatusChangeDelegate(System.IntPtr LinkStatusDelegate);

    /// <summary>
    /// Function: AddLinkStatusChangeDelegate
    /// </summary>
    public unsafe void AddLinkStatusChangeDelegate(System.IntPtr LinkStatusDelegate);

    /// <summary>
    /// Function: OnLinkStatusChange
    /// </summary>
    public unsafe void OnLinkStatusChange(bool bIsConnected);
}
