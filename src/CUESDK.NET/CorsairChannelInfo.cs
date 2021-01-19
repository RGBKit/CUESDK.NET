using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about separate channel of the DIY-device or cooler.
    /// </summary>
    public class CorsairChannelInfo
    {
        /// <summary>
        /// Total number of LEDs connected to the channel
        /// </summary>
        public int totalLedsCount;

        /// <summary>
        /// Number of LED-devices (fans, strips, etc.) connected to the channel which is controlled by the device
        /// </summary>
        public int devicesCount;

        /// <summary>
        /// Array containing information about each separate LED-device connected to the channel controlled by the device. Index of the LED-device in array is same as the index of the LED-device connected to the device.
        /// </summary>
        public CorsairChannelDeviceInfo[] devices;

        /// <summary>
        /// The native channel info
        /// </summary>
        internal CorsairChannelInfoNative native;

        /// <summary>
        /// Creates a instance of CorsairChannelInfo
        /// </summary>
        /// <param name="channelInfoNative">The native channel info</param>
        internal CorsairChannelInfo(CorsairChannelInfoNative channelInfoNative)
        {
            native = channelInfoNative;
            totalLedsCount = native.totalLedsCount;
            devicesCount = native.devicesCount;
            devices = new CorsairChannelDeviceInfo[native.devicesCount];

            int corsairChannelDeviceInfoSize = Marshal.SizeOf(typeof(CorsairChannelDeviceInfoNative));

            for (int i = 0; i < native.devicesCount; i++)
            {
                var nativeChannelDeviceInfo = Marshal.PtrToStructure<CorsairChannelDeviceInfoNative>(native.devices + corsairChannelDeviceInfoSize * i);
                devices[i] = new CorsairChannelDeviceInfo(nativeChannelDeviceInfo);
            }
        }
    }
}
