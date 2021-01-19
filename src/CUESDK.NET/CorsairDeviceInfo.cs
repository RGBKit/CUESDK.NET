using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about device.
    /// </summary>
    public class CorsairDeviceInfo
    {
        /// <summary>
        /// Enum describing device type
        /// </summary>
        public CorsairDeviceType type;

        /// <summary>
        /// Null-terminated device model (like “K95RGB”)
        /// </summary>
        public string model;

        /// <summary>
        /// Enum describing physical layout of the keyboard or mouse. If device is neither keyboard nor mouse then value is CPL_Invalid
        /// </summary>
        public CorsairPhysicalLayout physicalLayout;

        /// <summary>
        /// Enum describing logical layout of the keyboard as set in CUE settings. If device is not keyboard then value is CLL_Invalid
        /// </summary>
        public CorsairLogicalLayout logicalLayout;

        /// <summary>
        /// Mask that describes device capabilities, formed as logical “or” of CorsairDeviceCaps enum values
        /// </summary>
        public int capsMask;

        /// <summary>
        /// Number of controllable LEDs on the device
        /// </summary>
        public int ledsCount;

        /// <summary>
        /// Structure that describes channels of the DIY-devices and coolers.
        /// </summary>
        public CorsairChannelsInfo channels;

        /// <summary>
        /// null-terminated string that contains unique device identifier
        /// </summary>
        internal char[] deviceId;

        /// <summary>
        /// The native channels info
        /// </summary>
        internal CorsairDeviceInfoNative native;

        /// <summary>
        /// Creates a instance of CorsairDeviceInfo
        /// </summary>
        /// <param name="deviceInfoNative">The native device info</param>
        internal CorsairDeviceInfo(CorsairDeviceInfoNative deviceInfoNative)
        {
            native = deviceInfoNative;
            model = Marshal.PtrToStringAnsi(native.model);
            physicalLayout = native.physicalLayout;
            logicalLayout = native.logicalLayout;
            capsMask = native.capsMask;
            ledsCount = native.ledsCount;
            channels = new CorsairChannelsInfo(native.channels);
            deviceId = native.deviceId;
        }
    }
}
