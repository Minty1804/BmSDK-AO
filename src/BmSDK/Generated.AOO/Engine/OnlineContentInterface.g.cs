#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineContentInterface<br/>
/// (size = 48)
/// (flags = 49171)
/// </summary>
public partial interface OnlineContentInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearSaveGames
    /// </summary>
    public unsafe bool ClearSaveGames(byte LocalUserNum);

    /// <summary>
    /// Function: DeleteSaveGame
    /// </summary>
    public unsafe bool DeleteSaveGame(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearWriteSaveGameDataComplete
    /// </summary>
    public unsafe void ClearWriteSaveGameDataComplete(byte LocalUserNum, System.IntPtr WriteSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: AddWriteSaveGameDataComplete
    /// </summary>
    public unsafe void AddWriteSaveGameDataComplete(byte LocalUserNum, System.IntPtr WriteSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: OnWriteSaveGameDataComplete
    /// </summary>
    public unsafe void OnWriteSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: WriteSaveGameData
    /// </summary>
    public unsafe bool WriteSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, in BmSDK.TArray<byte> SaveGameData);

    /// <summary>
    /// Function: ClearReadSaveGameDataComplete
    /// </summary>
    public unsafe void ClearReadSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: AddReadSaveGameDataComplete
    /// </summary>
    public unsafe void AddReadSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: OnReadSaveGameDataComplete
    /// </summary>
    public unsafe void OnReadSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: GetSaveGameData
    /// </summary>
    public unsafe bool GetSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out BmSDK.TArray<byte> SaveGameData);

    /// <summary>
    /// Function: ReadSaveGameData
    /// </summary>
    public unsafe bool ReadSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: GetAvailableDownloadCounts
    /// </summary>
    public unsafe void GetAvailableDownloadCounts(byte LocalUserNum, out int NewDownloads, out int TotalDownloads);

    /// <summary>
    /// Function: ClearQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void ClearQueryAvailableDownloadsComplete(byte LocalUserNum, System.IntPtr QueryDownloadsDelegate);

    /// <summary>
    /// Function: AddQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void AddQueryAvailableDownloadsComplete(byte LocalUserNum, System.IntPtr QueryDownloadsDelegate);

    /// <summary>
    /// Function: OnQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void OnQueryAvailableDownloadsComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: QueryAvailableDownloads
    /// </summary>
    public unsafe bool QueryAvailableDownloads(byte LocalUserNum, int CategoryMask = default);

    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> ContentList);

    /// <summary>
    /// Function: ClearContentList
    /// </summary>
    public unsafe void ClearContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType);

    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe bool ReadContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int DeviceID = default);

    /// <summary>
    /// Function: ClearReadContentComplete
    /// </summary>
    public unsafe void ClearReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate);

    /// <summary>
    /// Function: AddReadContentComplete
    /// </summary>
    public unsafe void AddReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate);

    /// <summary>
    /// Function: OnReadContentComplete
    /// </summary>
    public unsafe void OnReadContentComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ClearContentChangeDelegate
    /// </summary>
    public unsafe void ClearContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default);

    /// <summary>
    /// Function: AddContentChangeDelegate
    /// </summary>
    public unsafe void AddContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default);

    /// <summary>
    /// Function: OnContentChange
    /// </summary>
    public unsafe void OnContentChange();
}
