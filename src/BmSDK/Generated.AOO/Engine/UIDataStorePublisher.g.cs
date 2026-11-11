#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: UIDataStorePublisher<br/>
/// (size = 48)
/// (flags = 134267027)
/// </summary>
public partial interface UIDataStorePublisher : BmSDK.Engine.UIDataStoreSubscriber
{
    /// <summary>
    /// Function: SaveSubscriberValue
    /// </summary>
    public unsafe bool SaveSubscriberValue(out BmSDK.TArray<BmSDK.Engine.UIDataStore> out_BoundDataStores, int BindingIndex = default);
}
