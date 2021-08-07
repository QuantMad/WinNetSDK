using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    public struct SDK_UUID
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string uuid;
    }
}
