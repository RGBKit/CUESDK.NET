using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains number of leds and array with their positions.
    /// </summary>
    public class CorsairLedPositions
    {
        /// <summary>
        /// Integer value. Number of elements in the following array
        /// </summary>
        public int numberOfLeds;

        /// <summary>
        /// Array of led positions.
        /// </summary>
        public CorsairLedPosition[] pLedPosition;

        /// <summary>
        /// The native led positions
        /// </summary>
        internal CorsairLedPositionsNative native;

        /// <summary>
        /// Creates a instance of CorsairLedPositions
        /// </summary>
        /// <param name="ledPositionsNative">The native led positions</param>
        internal CorsairLedPositions(CorsairLedPositionsNative ledPositionsNative)
        {
            native = ledPositionsNative;
            numberOfLeds = native.numberOfLeds;
            pLedPosition = new CorsairLedPosition[native.numberOfLeds];

            int corsairLedPositionSize = Marshal.SizeOf(typeof(CorsairLedPositionNative));

            for (int i = 0; i < native.numberOfLeds; i++)
            {
                var nativeLedPosition = Marshal.PtrToStructure<CorsairLedPositionNative>(native.pLedPosition + corsairLedPositionSize * i);
                pLedPosition[i] = new CorsairLedPosition(nativeLedPosition);
            }
        }
    }
}
