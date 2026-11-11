#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineSystemInterface<br/>
/// (size = 48)
/// (flags = 49171)
/// </summary>
public partial interface OnlineSystemInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetSessionRegistrants
    /// </summary>
    public unsafe bool GetSessionRegistrants(BmSDK.FName SessionName, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineRegistrant> RegistrantList);

    /// <summary>
    /// Function: SetAllowInviteMessages
    /// </summary>
    public unsafe void SetAllowInviteMessages(bool Allow);

    /// <summary>
    /// Function: ProcessBootInviteMessage
    /// </summary>
    public unsafe bool ProcessBootInviteMessage();

    /// <summary>
    /// Function: CheckBootInviteMessage
    /// </summary>
    public unsafe bool CheckBootInviteMessage(out int AcceptedUserNum);

    /// <summary>
    /// Function: FakeDisconnection
    /// </summary>
    public unsafe void FakeDisconnection();

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
    /// Function: GetNATType
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ENATType GetNATType();

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
    /// Function: SetNetworkNotificationPosition
    /// </summary>
    public unsafe void SetNetworkNotificationPosition(BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition NewPos);

    /// <summary>
    /// Function: GetNetworkNotificationPosition
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition GetNetworkNotificationPosition();

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

    /// <summary>
    /// Function: HasLinkConnection
    /// </summary>
    public unsafe bool HasLinkConnection();
}
