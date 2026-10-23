#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: MAttractorInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface MAttractorInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: AddAttracted
    /// </summary>
    public unsafe void AddAttracted(BmSDK.BmGame.RBMAIController attractedToAdd, bool isNotice);

    /// <summary>
    /// Function: IsNoticeFull
    /// </summary>
    public unsafe bool IsNoticeFull();

    /// <summary>
    /// Function: IsInvestigateFull
    /// </summary>
    public unsafe bool IsInvestigateFull();

    /// <summary>
    /// Function: IsAttractorFull
    /// </summary>
    public unsafe bool IsAttractorFull();

    /// <summary>
    /// Function: HasPreviouslyClaimed
    /// </summary>
    public unsafe bool HasPreviouslyClaimed(BmSDK.BmGame.RBMAIController CurrentAttracted);

    /// <summary>
    /// Function: NotifyDestroyAttractor
    /// </summary>
    public unsafe void NotifyDestroyAttractor();

    /// <summary>
    /// Function: End
    /// </summary>
    public unsafe void End();

    /// <summary>
    /// Function: ComputeAllPosition
    /// </summary>
    public unsafe void ComputeAllPosition();

    /// <summary>
    /// Function: GetUnreservedCloseLocation
    /// </summary>
    public unsafe bool GetUnreservedCloseLocation(BmSDK.BmGame.RBMAIController Attracted, out System.Numerics.Vector3 InteractPos, bool bReserve = default);

    /// <summary>
    /// Function: GetUnreservedInteractLocation
    /// </summary>
    public unsafe bool GetUnreservedInteractLocation(BmSDK.BmGame.RBMAIController Attracted, out System.Numerics.Vector3 InteractPos, bool bReserve = default);

    /// <summary>
    /// Function: NeedsLineOfSight
    /// </summary>
    public unsafe bool NeedsLineOfSight();

    /// <summary>
    /// Function: GetMaxNumNotice
    /// </summary>
    public unsafe int GetMaxNumNotice();

    /// <summary>
    /// Function: GetNoticeRange
    /// </summary>
    public unsafe float GetNoticeRange();

    /// <summary>
    /// Function: GetMaxNumInvestigate
    /// </summary>
    public unsafe int GetMaxNumInvestigate();

    /// <summary>
    /// Function: GetInvestigateRange
    /// </summary>
    public unsafe float GetInvestigateRange();

    /// <summary>
    /// Function: GetMaxInteractWith
    /// </summary>
    public unsafe int GetMaxInteractWith();

    /// <summary>
    /// Function: GetInteractRange
    /// </summary>
    public unsafe float GetInteractRange();

    /// <summary>
    /// Function: GetAttractorLocation
    /// </summary>
    public unsafe void GetAttractorLocation(out System.Numerics.Vector3 Position);

    /// <summary>
    /// Function: GetSubAttractorClass
    /// </summary>
    public unsafe BmSDK.Class GetSubAttractorClass();

    /// <summary>
    /// Function: Deactivate
    /// </summary>
    public unsafe bool Deactivate();

    /// <summary>
    /// Function: Activate
    /// </summary>
    public unsafe bool Activate();

    /// <summary>
    /// Struct: FInteractPosition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FInteractPosition
    {
        /// <summary>
        /// ObjectProperty: mUser
        /// </summary>
        public unsafe BmSDK.BmGame.RBMAIController mUser
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: mOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 mOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
