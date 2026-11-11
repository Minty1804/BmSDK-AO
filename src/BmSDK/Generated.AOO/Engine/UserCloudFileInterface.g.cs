#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: UserCloudFileInterface<br/>
/// (size = 48)
/// (flags = 49171)
/// </summary>
public partial interface UserCloudFileInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearAllDelegates
    /// </summary>
    public unsafe void ClearAllDelegates();

    /// <summary>
    /// Function: ClearDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe void ClearDeleteUserFileCompleteDelegate(System.IntPtr DeleteUserFileCompleteDelegate);

    /// <summary>
    /// Function: AddDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe void AddDeleteUserFileCompleteDelegate(System.IntPtr DeleteUserFileCompleteDelegate);

    /// <summary>
    /// Function: DeleteUserFile
    /// </summary>
    public unsafe bool DeleteUserFile(BmSDK.FString UserId, BmSDK.FString Filename, bool bShouldCloudDelete, bool bShouldLocallyDelete);

    /// <summary>
    /// Function: OnDeleteUserFileComplete
    /// </summary>
    public unsafe void OnDeleteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe void ClearWriteUserFileCompleteDelegate(System.IntPtr WriteUserFileCompleteDelegate);

    /// <summary>
    /// Function: AddWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe void AddWriteUserFileCompleteDelegate(System.IntPtr WriteUserFileCompleteDelegate);

    /// <summary>
    /// Function: WriteUserFile
    /// </summary>
    public unsafe bool WriteUserFile(BmSDK.FString UserId, BmSDK.FString Filename, in BmSDK.TArray<byte> FileContents);

    /// <summary>
    /// Function: OnWriteUserFileComplete
    /// </summary>
    public unsafe void OnWriteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearReadUserFileCompleteDelegate
    /// </summary>
    public unsafe void ClearReadUserFileCompleteDelegate(System.IntPtr ReadUserFileCompleteDelegate);

    /// <summary>
    /// Function: AddReadUserFileCompleteDelegate
    /// </summary>
    public unsafe void AddReadUserFileCompleteDelegate(System.IntPtr ReadUserFileCompleteDelegate);

    /// <summary>
    /// Function: ReadUserFile
    /// </summary>
    public unsafe bool ReadUserFile(BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: OnReadUserFileComplete
    /// </summary>
    public unsafe void OnReadUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: GetUserFileList
    /// </summary>
    public unsafe void GetUserFileList(BmSDK.FString UserId, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile> UserFiles);

    /// <summary>
    /// Function: ClearEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe void ClearEnumerateUserFileCompleteDelegate(System.IntPtr EnumerateUserFileCompleteDelegate);

    /// <summary>
    /// Function: AddEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe void AddEnumerateUserFileCompleteDelegate(System.IntPtr EnumerateUserFileCompleteDelegate);

    /// <summary>
    /// Function: EnumerateUserFiles
    /// </summary>
    public unsafe void EnumerateUserFiles(BmSDK.FString UserId);

    /// <summary>
    /// Function: OnEnumerateUserFilesComplete
    /// </summary>
    public unsafe void OnEnumerateUserFilesComplete(bool bWasSuccessful, BmSDK.FString UserId);

    /// <summary>
    /// Function: ClearFile
    /// </summary>
    public unsafe bool ClearFile(BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearFiles
    /// </summary>
    public unsafe bool ClearFiles(BmSDK.FString UserId);

    /// <summary>
    /// Function: GetFileContents
    /// </summary>
    public unsafe bool GetFileContents(BmSDK.FString UserId, BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents);
}
