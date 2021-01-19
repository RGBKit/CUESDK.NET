namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains list of event identifiers.
    /// </summary>
    public enum CorsairEventId
    {
        /// <summary>
        /// Dummy value
        /// </summary>
        CEI_Invalid = 0,

        /// <summary>
        /// Connection status changed
        /// </summary>
        CEI_DeviceConnectionStatusChangedEvent,

        /// <summary>
        /// Key event
        /// </summary>
        CEI_KeyEvent
    }
}
