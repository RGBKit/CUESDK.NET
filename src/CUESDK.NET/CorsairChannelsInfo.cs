using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about channels of the DIY-devices or cooler.
    /// </summary>
    public class CorsairChannelsInfo
    {
        /// <summary>
        /// Number of channels controlled by the device
        /// </summary>
        public int channelsCount;

        /// <summary>
        /// Array containing information about each separate channel of the device. Index of the channel in the array is same as index of the channel on the device.
        /// </summary>
        public CorsairChannelInfo[] channels;

        /// <summary>
        /// The native channels info
        /// </summary>
        internal CorsairChannelsInfoNative native;

        /// <summary>
        /// Creates a instance of CorsairChannelsInfo
        /// </summary>
        /// <param name="channelsInfoNative">The native channels info</param>
        internal CorsairChannelsInfo(CorsairChannelsInfoNative channelsInfoNative)
        {
            native = channelsInfoNative;
            channelsCount = native.channelsCount;
            channels = new CorsairChannelInfo[native.channelsCount];

            int corsairChannelInfoSize = Marshal.SizeOf(typeof(CorsairChannelInfoNative));

            for (int i = 0; i < native.channelsCount; i++)
            {
                var nativeChannelInfo = Marshal.PtrToStructure<CorsairChannelInfoNative>(native.channels + corsairChannelInfoSize * i);
                channels[i] = new CorsairChannelInfo(nativeChannelInfo);
            }
        }
    }
}
