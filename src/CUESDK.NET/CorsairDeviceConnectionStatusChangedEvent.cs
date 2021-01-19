using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about some device that is connected or disconnected.
    /// </summary>
    public class CorsairDeviceConnectionStatusChangedEvent
    {
        /// <summary>
        /// Null-terminated string that contains unique device identifier
        /// </summary>
        public string deviceId;

        /// <summary>
        /// True if connected, false if disconnected.
        /// </summary>
        public bool isConnected;

        /// <summary>
        /// The native device connection status changed event
        /// </summary>
        internal CorsairDeviceConnectionStatusChangedEventNative native;

        /// <summary>
        /// Creates a instance of CorsairDeviceConnectionStatusChangedEvent
        /// </summary>
        /// <param name="deviceConnectionStatusChangedEventNative">The native device connection status changed event</param>
        internal CorsairDeviceConnectionStatusChangedEvent(CorsairDeviceConnectionStatusChangedEventNative deviceConnectionStatusChangedEventNative)
        {
            native = deviceConnectionStatusChangedEventNative;
            deviceId = native.deviceId;
            isConnected = native.isConnected;
        }
    }
}
