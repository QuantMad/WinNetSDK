using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    public struct SDK_CONFIG_VIDEOCOLOR
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public SDK_VIDEOCOLOR[] dstVideoColor;
    }
}