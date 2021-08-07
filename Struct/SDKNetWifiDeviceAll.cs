using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    public struct SDK_NetWifiDeviceAll
    {
        public Int32 nDevNumber;

        /// <summary>
        /// NET_MAX_AP_NUMBER=32
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	    public SDK_NetWifiDevice[] vNetWifiDeviceAll;
    }
}
