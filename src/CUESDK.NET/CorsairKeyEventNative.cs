using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about device where G or M key was pressed/released and the key itself.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal class CorsairKeyEventNative
    {
        /// <summary>
        /// Null-terminated string that contains unique device identifier.
        /// </summary>
        public char[] deviceId;

        /// <summary>
        /// G or M key that was pressed/released.
        /// </summary>
        public CorsairKeyId keyId;

        /// <summary>
        /// True if pressed, false if released
        /// </summary>
        public bool isPressed;
    }
}
