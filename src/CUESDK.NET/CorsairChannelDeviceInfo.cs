namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about separate LED-device connected to the channel controlled by the DIY-device or cooler.
    /// </summary>
    public class CorsairChannelDeviceInfo
    {
        /// <summary>
        /// Type of the LED-device
        /// </summary>
        public CorsairChannelDeviceType type;

        /// <summary>
        /// Number of LEDs controlled by LED-device.
        /// </summary>
        public int deviceLedCount;

        /// <summary>
        /// The native channel device info
        /// </summary>
        internal CorsairChannelDeviceInfoNative native;

        /// <summary>
        /// Creates a instance of CorsairChannelDeviceInfo
        /// </summary>
        /// <param name="channelDeviceInfoNative">The native channel device info</param>
        internal CorsairChannelDeviceInfo(CorsairChannelDeviceInfoNative channelDeviceInfoNative)
        {
            native = channelDeviceInfoNative;
            type = native.type;
            deviceLedCount = native.deviceLedCount;
        }
    }
}
