using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about event id and event data.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal class CorsairEventNative
    {
        /// <summary>
        /// Event identifier.
        /// </summary>
        [FieldOffset(0)]
        public CorsairEventId id;

        /// <summary>
        /// When id == CEI_DeviceConnectionStatusChangedEvent contains valid pointer to structure with information about connected or disconnected device.
        /// </summary>
        [FieldOffset(1)]
        public CorsairDeviceConnectionStatusChangedEvent deviceConnectionStatusChangedEvent;

        /// <summary>
        /// When id == CEI_KeyEvent contains valid pointer to structure with information about pressed or released G or M button and device where this event happened.
        /// </summary>
        [FieldOffset(1)]
        public CorsairKeyEvent keyEvent;
    }
}
