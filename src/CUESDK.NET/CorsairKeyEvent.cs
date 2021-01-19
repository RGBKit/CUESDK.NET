namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about device where G or M key was pressed/released and the key itself.
    /// </summary>
    public class CorsairKeyEvent
    {
        /// <summary>
        /// Null-terminated string that contains unique device identifier.
        /// </summary>
        public string deviceId;

        /// <summary>
        /// G or M key that was pressed/released.
        /// </summary>
        public CorsairKeyId keyId;

        /// <summary>
        /// True if pressed, false if released
        /// </summary>
        public bool isPressed;

        /// <summary>
        /// The native key event
        /// </summary>
        internal CorsairKeyEventNative native;

        /// <summary>
        /// Creates a instance of CorsairKeyEvent
        /// </summary>
        /// <param name="keyEventNative">The native key event</param>
        internal CorsairKeyEvent(CorsairKeyEventNative keyEventNative)
        {
            native = keyEventNative;
            deviceId = native.deviceId;
            keyId = native.keyId;
            isPressed = native.isPressed;
        }
    }
}
