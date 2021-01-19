namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains led id and position of led rectangle. Most of the keys are rectangular. In case if key is not rectangular (like Enter in ISO/UK layout) it returns the smallest rectangle that fully contains the key.
    /// </summary>
    public class CorsairLedPosition
    {
        /// <summary>
        /// Identifier of led
        /// </summary>
        public CorsairLedId ledId;

        /// <summary>
        /// For keyboards, mice, mousemats, headset stands and memory modules values are in mm, for DIY-devices, headsets and coolers values are in logical units.
        /// </summary>
        public double top;

        /// <summary>
        /// For keyboards, mice, mousemats, headset stands and memory modules values are in mm, for DIY-devices, headsets and coolers values are in logical units.
        /// </summary>
        public double left;

        /// <summary>
        /// For keyboards, mice, mousemats, headset stands and memory modules values are in mm, for DIY-devices, headsets and coolers values are in logical units.
        /// </summary>
        public double height;

        /// <summary>
        /// For keyboards, mice, mousemats, headset stands and memory modules values are in mm, for DIY-devices, headsets and coolers values are in logical units.
        /// </summary>
        public double width;

        /// <summary>
        /// The native led position
        /// </summary>
        internal CorsairLedPositionNative native;

        /// <summary>
        /// Creates a instance of CorsairLedPosition
        /// </summary>
        /// <param name="ledPositionNative">The native led position</param>
        internal CorsairLedPosition(CorsairLedPositionNative ledPositionNative)
        {
            native = ledPositionNative;
            ledId = native.ledId;
            top = native.top;
            left = native.left;
            height = native.height;
            width = native.width;
        }
    }
}
