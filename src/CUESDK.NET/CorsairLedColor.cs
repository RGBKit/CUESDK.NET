namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains information about led and its color.
    /// </summary>
    public class CorsairLedColor
    {
        /// <summary>
        /// Identifier of LED to set
        /// </summary>
        public CorsairLedId ledId;

        /// <summary>
        /// Red brightness [0..255]
        /// </summary>
        public int r;

        /// <summary>
        /// Green brightness [0..255]
        /// </summary>
        public int g;

        /// <summary>
        /// Blue brightness [0..255]
        /// </summary>
        public int b;

        /// <summary>
        /// The native led color
        /// </summary>
        internal CorsairLedColorNative native;

        /// <summary>
        /// Creates a instance of CorsairLedColor
        /// </summary>
        public CorsairLedColor()
        {
            ledId = CorsairLedId.CLI_Invalid;
            r = 0;
            g = 0;
            b = 0;

            ApplyToNative();
        }

        /// <summary>
        /// Creates a instance of CorsairLedColor
        /// </summary>
        /// <param name="ledColorNative">The native led color</param>
        internal CorsairLedColor(CorsairLedColorNative ledColorNative)
        {
            ledId = CorsairLedId.CLI_Invalid;
            r = 0;
            g = 0;
            b = 0;

            native = ledColorNative;

            ApplyToManaged();
        }

        /// <summary>
        /// Applies changes on the object to the native instance
        /// </summary>
        internal void ApplyToNative()
        {
            if (native == null)
                native = new CorsairLedColorNative();

            native.ledId = ledId;
            native.r = r;
            native.g = g;
            native.b = b;
        }

        /// <summary>
        /// Applies changes on the native instance to the object
        /// </summary>
        internal void ApplyToManaged()
        {
            if (native == null)
                native = new CorsairLedColorNative();

            ledId = native.ledId;
            r = native.r;
            g = native.g;
            b = native.b;
        }
    }
}
