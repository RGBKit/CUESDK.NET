namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about event id and event data.
    /// </summary>
    public class CorsairEvent
    {
        /// <summary>
        /// Event identifier.
        /// </summary>
        public CorsairEventId id;

        /// <summary>
        /// When id == CEI_DeviceConnectionStatusChangedEvent contains valid pointer to structure with information about connected or disconnected device.
        /// </summary>
        public CorsairDeviceConnectionStatusChangedEvent deviceConnectionStatusChangedEvent;

        /// <summary>
        /// When id == CEI_KeyEvent contains valid pointer to structure with information about pressed or released G or M button and device where this event happened.
        /// </summary>
        public CorsairKeyEvent keyEvent;

        /// <summary>
        /// The native event
        /// </summary>
        internal CorsairEventNative native;

        /// <summary>
        /// Creates a instance of CorsairEvent
        /// </summary>
        /// <param name="eventNative">The native event</param>
        internal CorsairEvent(CorsairEventNative eventNative)
        {
            native = eventNative;
            id = eventNative.id;

            if (id == CorsairEventId.CEI_KeyEvent)
            {
                keyEvent = native.keyEvent;
            }
            else if (id == CorsairEventId.CEI_DeviceConnectionStatusChangedEvent)
            {
                deviceConnectionStatusChangedEvent = native.deviceConnectionStatusChangedEvent;
            }
        }
    }
}
