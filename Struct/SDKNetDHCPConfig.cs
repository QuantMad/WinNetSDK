using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    public struct SDK_NetDHCPConfig
    {
        public byte bEnable;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string ifName;
    }
}
