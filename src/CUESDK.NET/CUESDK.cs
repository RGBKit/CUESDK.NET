using System;
using System.Runtime.InteropServices;

namespace Corsair.CUE.SDK
{
    /// <summary>
    /// The Corsair Utility Engine (CUE) SDK gives ability for third-party applications to control lightings on Corsair RGB devices. CUE SDK interacts with hardware through CUE so it should be running in order for SDK to work properly.
    /// </summary>
    public class CUESDK
    {
        /// <summary>
        /// Set specified leds to some colors. The color is retained until changed by successive calls. This function does not take logical layout into account. This function executes synchronously, if you are concerned about delays consider using CorsairSetLedsColorsAsync
        /// </summary>
        /// <param name="size">Number of leds in ledsColors array</param>
        /// <param name="ledsColors">Array containing colors for each LED.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it’s disconnected) then function completes successfully and returns true.</returns>
        [Obsolete("It is not recommended to use this function with DIY-devices, coolers and memory modules. Consider using CorsairSetLedsColorsBufferByDeviceIndex() to fill buffer and CorsairSetLedsColorsFlushBuffer() to send data to CUE instead.")]
        public static bool CorsairSetLedsColors(int size, CorsairLedColor[] ledsColors)
        {
            var corsairLedColorSize = Marshal.SizeOf<CorsairLedColorNative>();
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (int i = 0; i < size; i++)
            {
                ledsColors[i].ApplyToNative();
                Marshal.StructureToPtr(ledsColors[i].native, ledsPtr + corsairLedColorSize * i, false);
            }

            var result = CUESDKNative.CorsairSetLedsColors(size, ledsPtr);

            Marshal.FreeHGlobal(ledsPtr);

            return result;
        }

        /// <summary>
        /// Set specified LEDs to some colors. This function set LEDs colors in the buffer which is written to the devices via CorsairSetLedsColorsFlushBuffer or CorsairSetLedsColorsFlushBufferAsync. Typical usecase is next: CorsairSetLedsColorsFlushBuffer or CorsairSetLedsColorsFlushBufferAsync is called to write LEDs colors to the device and follows after one or more calls of CorsairSetLedsColorsBufferByDeviceIndex to set the LEDs buffer. This function does not take logical layout into account.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by CorsairGetDeviceCount()</param>
        /// <param name="size">Number of leds in ledsColors array</param>
        /// <param name="ledsColors">Array containing colors for each LED.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it’s disconnected) then functions completes successfully and returns true.</returns>
        public static bool CorsairSetLedsColorsBufferByDeviceIndex(int deviceIndex, int size, CorsairLedColor[] ledsColors)
        {
            var corsairLedColorSize = Marshal.SizeOf<CorsairLedColorNative>();
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (int i = 0; i < size; i++)
            {
                ledsColors[i].ApplyToNative();
                Marshal.StructureToPtr(ledsColors[i].native, ledsPtr + corsairLedColorSize * i, false);
            }

            var result = CUESDKNative.CorsairSetLedsColorsBufferByDeviceIndex(deviceIndex, size, ledsPtr);

            Marshal.FreeHGlobal(ledsPtr);

            return result;
        }

        /// <summary>
        /// Writes to the devices LEDs colors buffer which is previously filled by the CorsairSetLedsColorsBufferByDeviceIndex function. This function executes synchronously, if you are concerned about delays consider using CorsairSetLedsColorsFlushBufferAsync
        /// </summary>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId in the LEDs colors buffer present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it’s disconnected) then functions completes successfully and returns true.</returns>
        public static bool CorsairSetLedsColorsFlushBuffer()
        {
            return CUESDKNative.CorsairSetLedsColorsFlushBuffer();
        }

        /// <summary>
        /// Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result
        /// </summary>
        /// <param name="context">Context contains value that was supplied by user in CorsairSetLedsColorsFlushBufferAsync call.</param>
        /// <param name="result">Result is true if call was successful, otherwise false</param>
        /// <param name="error">Error contains error code if call was not successful (result==false)</param>
        public delegate void CorsairSetLedsColorsFlushBufferAsyncCallback(object context, bool result, CorsairError error);

        /// <summary>
        /// Same as CorsairSetLedsColorsFlushBuffer but returns control to the caller immediately.
        /// </summary>
        /// <param name="callback">Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId in the LEDs colors buffer present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it’s disconnected) then functions completes successfully and returns true.</returns>
        public static bool CorsairSetLedsColorsFlushBufferAsync(CorsairSetLedsColorsFlushBufferAsyncCallback callback, object context)
        {
            var callbackMethod = new CUESDKNative.CorsairSetLedsColorsFlushBufferAsyncCallback((IntPtr nativeContext, bool result, CorsairError error) =>
            {
                callback?.Invoke(context, result, error);
            });

            return CUESDKNative.CorsairSetLedsColorsFlushBufferAsync(callbackMethod, new IntPtr());
        }

        /// <summary>
        /// Get current color for the list of requested LEDs. The color should represent the actual state of the hardware LED, which could be a combination of SDK and/or CUE input. This function works only for keyboard, mouse, mousemat, headset and headset stand devices.
        /// </summary>
        /// <param name="size">Number of leds in ledsColors array</param>
        /// <param name="ledsColors">Array containing colors for each LED. Caller should only fill ledId field, and then SDK will fill R, G and B values on return</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it’s disconnected) then functions completes successfully and returns true. Also ledsColors array will contain R, G and B values of colors on return.</returns>
        public static bool CorsairGetLedsColors(int size, CorsairLedColor[] ledsColors)
        {
            var corsairLedColorSize = Marshal.SizeOf<CorsairLedColorNative>();
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (int i = 0; i < size; i++)
            {
                ledsColors[i].ApplyToNative();
                Marshal.StructureToPtr(ledsColors[i].native, ledsPtr + corsairLedColorSize * i, false);
            }

            var result = CUESDKNative.CorsairGetLedsColors(size, ledsPtr);

            for (int i = 0; i < size; i++)
            {
                ledsColors[i].native = Marshal.PtrToStructure<CorsairLedColorNative>(ledsPtr + corsairLedColorSize * i);
                ledsColors[i].ApplyToManaged();
            }

            Marshal.FreeHGlobal(ledsPtr);

            return result;
        }

        /// <summary>
        /// Get current color for the list of requested LEDs. The color should represent the actual state of the hardware LED, which could be a combination of SDK and/or CUE input. This function works for keyboard, mouse, mousemat, headset, headset stand, DIY-devices, memory module and cooler.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by CorsairGetDeviceCount()</param>
        /// <param name="size">Number of LEDs in ledsColors array</param>
        /// <param name="ledsColors">Array containing colors for each LED. Caller should only fill ledId field, and then SDK will fill R, G and B values on return.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it’s disconnected) then functions completes successfully and returns true. Also ledsColors array will contain R, G and B values of colors on return.</returns>
        public static bool CorsairGetLedsColorsByDeviceIndex(int deviceIndex, int size, CorsairLedColor[] ledsColors)
        {
            var corsairLedColorSize = Marshal.SizeOf<CorsairLedColorNative>();
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (int i = 0; i < size; i++)
            {
                ledsColors[i].ApplyToNative();
                Marshal.StructureToPtr(ledsColors[i].native, ledsPtr + corsairLedColorSize * i, false);
            }

            var result = CUESDKNative.CorsairGetLedsColorsByDeviceIndex(deviceIndex, size, ledsPtr);

            for (int i = 0; i < size; i++)
            {
                ledsColors[i].native = Marshal.PtrToStructure<CorsairLedColorNative>(ledsPtr + corsairLedColorSize * i);
                ledsColors[i].ApplyToManaged();
            }

            Marshal.FreeHGlobal(ledsPtr);

            return result;
        }

        /// <summary>
        /// Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result
        /// </summary>
        /// <param name="context">Context contains value that was supplied by user in CorsairSetLedsColorsAsync call</param>
        /// <param name="result">Result is true if call was successful, otherwise false</param>
        /// <param name="error">Error contains error code if call was not successful (result==false)</param>
        public delegate void CorsairSetLedsColorsAsyncCallback(object context, bool result, CorsairError error);

        /// <summary>
        /// Same as CorsairSetLedsColors but returns control to the caller immediately.
        /// </summary>
        /// <param name="size">Number of leds in ledsColors array</param>
        /// <param name="ledsColors">Array containing colors for each LED</param>
        /// <param name="callbackType">Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure.</returns>
        [Obsolete("It is not recommended to use this function with DIY-devices, coolers and memory modules. Consider using CorsairSetLedsColorsBufferByDeviceIndex() to fill buffer and CorsairSetLedsColorsFlushBufferAsync() to send data to CUE instead.")]
        public static bool CorsairSetLedsColorsAsync(int size, CorsairLedColor[] ledsColors, CorsairSetLedsColorsAsyncCallback callbackType, object context)
        {
            var callbackMethod = new CUESDKNative.CorsairSetLedsColorsAsyncCallback((IntPtr nativeContext, bool result, CorsairError error) =>
            {
                callbackType?.Invoke(context, result, error);
            });

            var corsairLedColorSize = Marshal.SizeOf<CorsairLedColorNative>();
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (int i = 0; i < size; i++)
            {
                ledsColors[i].ApplyToNative();
                Marshal.StructureToPtr(ledsColors[i].native, ledsPtr + corsairLedColorSize * i, false);
            }

            var callResult = CUESDKNative.CorsairSetLedsColorsAsync(size, ledsPtr, callbackMethod, new IntPtr());

            Marshal.FreeHGlobal(ledsPtr);

            return callResult;
        }

        /// <summary>
        /// Returns number of connected Corsair devices. For keyboards, mice, mousemats, headsets and headset stands  not more than one device of each type is included in return value in case if there are multiple devices of same type connected to the system. For DIY-devices and coolers actual number of connected devices is included in return value. For memory modules actual number of connected modules is included in return value, modules are enumerated with respect to their logical position (counting from left to right, from top to bottom). Use CorsairGetDeviceInfo() to get information about a certain device.
        /// </summary>
        /// <returns>Integer value. -1 in case of error.</returns>
        public static int CorsairGetDeviceCount()
        {
            return CUESDKNative.CorsairGetDeviceCount();
        }

        /// <summary>
        /// Returns information about a device based on provided index.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than a value returned by CorsairGetDeviceInfo()</param>
        /// <returns>CorsairDeviceInfo structure that contains information about device or NULL if error has occurred.</returns>
        public static CorsairDeviceInfo CorsairGetDeviceInfo(int deviceIndex)
        {
            var deviceInfoPtr = CUESDKNative.CorsairGetDeviceInfo(deviceIndex);
            var deviceInfo = Marshal.PtrToStructure<CorsairDeviceInfoNative>(deviceInfoPtr);

            return new CorsairDeviceInfo(deviceInfo);
        }

        /// <summary>
        /// Provides list of keyboard LEDs with their physical positions. Coordinates grids for different device models can be found in Device coordinates.
        /// </summary>
        /// <returns>Returns CorsairLedPositions struct or NULL if error has occured.</returns>
        public static CorsairLedPositions CorsairGetLedPositions()
        {
            var ledPositionsPtr = CUESDKNative.CorsairGetLedPositions();
            var ledPositions = Marshal.PtrToStructure<CorsairLedPositionsNative>(ledPositionsPtr);

            return new CorsairLedPositions(ledPositions);
        }

        /// <summary>
        /// Provides list of keyboard, mouse, headset, mousemat, headset stand, DIY-devices, memory module and cooler LEDs by its index with their positions. Position could be either physical (only device-dependent) or logical (depend on device as well as CUE settings).
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than a value returned by CorsairGetDeviceCount()</param>
        /// <returns>Returns CorsairLedPositions struct or NULL if error has occurred.</returns>
        public static CorsairLedPositions CorsairGetLedPositionsByDeviceIndex(int deviceIndex)
        {
            var ledPositionsPtr = CUESDKNative.CorsairGetLedPositionsByDeviceIndex(deviceIndex);
            var ledPositions = Marshal.PtrToStructure<CorsairLedPositionsNative>(ledPositionsPtr);

            return new CorsairLedPositions(ledPositions);
        }

        /// <summary>
        /// Retrieves led id for key name taking logical layout into account. So on AZERTY keyboards if user calls CorsairGetLedIdForKeyName(‘A’) he gets CLK_Q. This id can be used in CorsairSetLedsColors function.
        /// </summary>
        /// <param name="keyName">Key name. [‘A’..’Z’] (26 values) are valid values.</param>
        /// <returns>Proper CorsairLedId or CorserLed_Invalid if error occurred.</returns>
        public static CorsairLedId CorsairGetLedIdForKeyName(char keyName)
        {
            return CUESDKNative.CorsairGetLedIdForKeyName(keyName);
        }

        /// <summary>
        /// Requests control using specified access mode.  By default client has shared control over lighting so there is no need to call CorsairRequestControl() unless a client requires exclusive control.
        /// </summary>
        /// <param name="accessMode">Requested accessMode</param>
        /// <returns>Boolean value. Returns true if SDK received requested control or false otherwise.</returns>
        public static bool CorsairRequestControl(CorsairAccessMode accessMode)
        {
            return CUESDKNative.CorsairRequestControl(accessMode);
        }

        /// <summary>
        /// Checks file and protocol version of CUE to understand which of SDK functions can be used with this version of CUE.
        /// </summary>
        /// <returns>CorsairProtocolDetails struct.</returns>
        public static CorsairProtocolDetails CorsairPerformProtocolHandshake()
        {
            var protocolDetails = CUESDKNative.CorsairPerformProtocolHandshake();

            return new CorsairProtocolDetails(protocolDetails);
        }

        /// <summary>
        /// Returns last error that occurred in this thread while using any of Corsair* functions.
        /// </summary>
        /// <returns>CorsairError value.</returns>
        public static CorsairError CorsairGetLastError()
        {
            return CUESDKNative.CorsairGetLastError();
        }

        /// <summary>
        /// Releases previously requested control for specified access mode.
        /// </summary>
        /// <param name="accessMode">AccessMode that is requested to be released.</param>
        /// <returns>Boolean value. Returns true if SDK released control or false otherwise.</returns>
        public static bool CorsairReleaseControl(CorsairAccessMode accessMode)
        {
            return CUESDKNative.CorsairReleaseControl(accessMode);
        }

        /// <summary>
        /// Set layer priority for this shared client. By default CUE has priority of 127 and all shared clients have priority of 128 if they don’t call this function. Layers with higher priority value are shown on top of layers with lower priority.
        /// </summary>
        /// <param name="priority">Priority of a layer [0..255]</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If this function is called in exclusive  mode then it will return true.</returns>
        public static bool CorsairSetLayerPriority(int priority)
        {
            return CUESDKNative.CorsairSetLayerPriority(priority);
        }

        /// <summary>
        /// Callback that is called by SDK when key is pressed or released
        /// </summary>
        /// <param name="context">Contains value that was supplied by user in CorsairRegisterKeypressCallback call.</param>
        /// <param name="keyId">The id of the key that was pressed or released</param>
        /// <param name="pressed">True if the key was pressed and false if it was released</param>
        public delegate void CorsairRegisterKeypressCallbackCallback(object context, CorsairKeyId keyId, bool pressed);

        /// <summary>
        /// Registers a callback that will be called by SDK when some of G or M keys are pressed or released
        /// </summary>
        /// <param name="CallbackType">Callback that is called by SDK when key is pressed or released</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure</returns>
        public static bool CorsairRegisterKeypressCallback(CorsairRegisterKeypressCallbackCallback CallbackType, object context)
        {
            var callbackMethod = new CUESDKNative.CorsairRegisterKeypressCallbackCallback((IntPtr nativeContext, CorsairKeyId keyId, bool pressed) =>
            {
                CallbackType?.Invoke(context, keyId, pressed);
            });

            return CUESDKNative.CorsairRegisterKeypressCallback(callbackMethod, new IntPtr());
        }

        /// <summary>
        /// Reads boolean property value for device at provided index.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by CorsairGetDeviceCount()</param>
        /// <param name="propertyId">Id of property to read from device</param>
        /// <param name="propertyValue">Boolean property value read from device.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure.</returns>
        public static bool CorsairGetBoolPropertyValue(int deviceIndex, CorsairDevicePropertyId propertyId, ref bool propertyValue)
        {
            var propertySize = Marshal.SizeOf<int>();
            var propertyPtr = Marshal.AllocHGlobal(propertySize);

            Marshal.WriteInt32(propertyPtr, Convert.ToInt32(propertyValue));

            var result = CUESDKNative.CorsairGetBoolPropertyValue(deviceIndex, propertyId, propertyPtr);

            propertyValue = Convert.ToBoolean(Marshal.ReadInt32(propertyPtr));

            Marshal.FreeHGlobal(propertyPtr);

            return result;
        }

        /// <summary>
        /// Reads integer property value for device at provided index.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by CorsairGetDeviceCount()</param>
        /// <param name="propertyId">Id of property to read from device</param>
        /// <param name="propertyValue">Integer property value read from device.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure.</returns>
        public static bool CorsairGetInt32PropertyValue(int deviceIndex, CorsairDevicePropertyId propertyId, ref int propertyValue)
        {
            var propertySize = Marshal.SizeOf<int>();
            var propertyPtr = Marshal.AllocHGlobal(propertySize);

            Marshal.WriteInt32(propertyPtr, propertyValue);

            var result = CUESDKNative.CorsairGetInt32PropertyValue(deviceIndex, propertyId, propertyPtr);

            propertyValue = Marshal.ReadInt32(propertyPtr);

            Marshal.FreeHGlobal(propertyPtr);

            return result;
        }

        /// <summary>
        /// Registers a callback that will be called by SDK when some event happened.
        /// </summary>
        /// <param name="context">Contains value that was supplied by user in CorsairSubscribeForEvents call</param>
        /// <param name="cEvent">Information about event, user can distinguish between events by reading event->id field</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CorsairEventHandler(IntPtr context, CorsairEvent cEvent);

        /// <summary>
        /// Registers a callback that will be called by SDK when some event happened
        /// </summary>
        /// <param name="onEvent">Callback that is called by SDK when key is pressed or released</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure</returns>
        public static bool CorsairSubscribeForEvents(CorsairEventHandler onEvent, IntPtr context)
        {
            var callbackMethod = new CUESDKNative.CorsairEventHandler((IntPtr context, CorsairEvent cEvent) =>
            {
                onEvent?.Invoke(context, cEvent);
            });

            return CUESDKNative.CorsairSubscribeForEvents(callbackMethod, new IntPtr());
        }

        /// <summary>
        /// Unregisters callback previously registered by CorsairSubscribeForEvents call.
        /// </summary>
        /// <returns>If successful</returns>
        public static bool CorsairUnsubscribeFromEvents()
        {
            return CUESDKNative.CorsairUnsubscribeFromEvents();
        }
    }
}
