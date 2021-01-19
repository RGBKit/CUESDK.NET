using System;
using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about some device that is connected or disconnected.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal class CorsairDeviceConnectionStatusChangedEventNative
    {
        /// <summary>
        /// Null-terminated string that contains unique device identifier
        /// </summary>
        public char[] deviceId;

        /// <summary>
        /// True if connected, false if disconnected.
        /// </summary>
        public bool isConnected;
    }
}
