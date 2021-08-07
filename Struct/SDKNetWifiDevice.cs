using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    public struct SDK_NetWifiDevice
    {
        /// <summary>
        /// SSID Number
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string sSSID;

        /// <summary>
        /// см. SDK_RSSI_SINGNAL
        /// </summary>
        public Int32 nRSSI;
        /// <summary>
        /// Канал
        /// </summary>
        public Int32 nChannel;

        /// <summary>
        /// Infra, Adhoc
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string sNetType;

        /// <summary>
        /// NONE, WEP, TKIP, AES
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string sEncrypType;

        /// <summary>
        /// OPEN, SHARED, WEPAUTO, WPAPSK, WPA2PSK, WPANONE, WPA, WPA2
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string sAuth;
    }
}
