namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains list of device capabilities. Current version of SDK only supports lighting and property lookup, but future versions may also support other capabilities.
    /// </summary>
    public enum CorsairDeviceCaps
    {
        /// <summary>
        /// For devices that do not support any SDK functions
        /// </summary>
        CDC_None = 0,

        /// <summary>
        /// For devices that has controlled lighting
        /// </summary>
        CDC_Lighting = 1,

        /// <summary>
        /// For devices that provide current state through set of properties. These properties could be read with CorsairGetPropertyValue function.
        /// </summary>
        CDC_PropertyLookup = 2
    }
}
