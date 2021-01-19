using System;
using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about SDK and CUE versions.
    /// </summary>
    public struct CorsairProtocolDetails
    {
        /// <summary>
        /// Null-terminated string containing version of SDK (like “1.0.0.1”). Always contains valid value even if there was no CUE found
        /// </summary>
        public string sdkVersion;

        /// <summary>
        /// Null-terminated string containing version of CUE (like “1.0.0.1”) or NULL if CUE was not found
        /// </summary>
        public string serverVersion;

        /// <summary>
        /// Integer number that specifies version of protocol that is implemented by current SDK. Numbering starts from 1. Always contains valid value even if there was no CUE found
        /// </summary>
        public int sdkProtocolVersion;

        /// <summary>
        /// Integer number that specifies version of protocol that is implemented by CUE. Numbering starts from 1. If CUE was not found then this value will be 0
        /// </summary>
        public int serverProtocolVersion;

        /// <summary>
        /// Boolean value that specifies if there were breaking changes between version of protocol implemented by server and client.
        /// </summary>
        public bool breakingChanges;

        /// <summary>
        /// The native protocol details
        /// </summary>
        internal CorsairProtocolDetailsNative native;

        /// <summary>
        /// Creates a instance of CorsairProtocolDetails
        /// </summary>
        /// <param name="protocolDetailsNative">The native protocol details</param>
        internal CorsairProtocolDetails(CorsairProtocolDetailsNative protocolDetailsNative)
        {
            native = protocolDetailsNative;
            sdkVersion = Marshal.PtrToStringAnsi(native.sdkVersion);
            serverVersion = Marshal.PtrToStringAnsi(native.serverVersion);
            sdkProtocolVersion = native.sdkProtocolVersion;
            serverProtocolVersion = native.serverProtocolVersion;
            breakingChanges = Convert.ToBoolean(native.breakingChanges);
        }
    }
}
