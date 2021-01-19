namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains list of the LED-devices which can be connected to the DIY-device or cooler.
    /// </summary>
    public enum CorsairChannelDeviceType
    {
        /// <summary>
        /// Dummy value
        /// </summary>
        CCDT_Invalid = 0,

        /// <summary>
        /// For a HD fan
        /// </summary>
        CCDT_HD_Fan = 1,

        /// <summary>
        /// For a SP fan
        /// </summary>
        CCDT_SP_Fan = 2,

        /// <summary>
        /// For a LL fan
        /// </summary>
        CCDT_LL_Fan = 3,

        /// <summary>
        /// For a ML fan
        /// </summary>
        CCDT_ML_Fan = 4,

        /// <summary>
        /// For a light strip
        /// </summary>
        CCDT_Strip = 5,

        /// <summary>
        /// For a DAP
        /// </summary>
        CCDT_DAP = 6,

        /// <summary>
        /// For a pump
        /// </summary>
        CCDT_Pump = 7,

        /// <summary>
        /// For a QL fan
        /// </summary>
        CCDT_QL_Fan = 8,

        /// <summary>
        /// For a water block
        /// </summary>
        CCDT_WaterBlock = 9,

        /// <summary>
        /// For a SP Pro fan
        /// </summary>
        CCDT_SPPRO_Fan = 10
    }
}
