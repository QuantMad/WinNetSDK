using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct CONFIG_IPAddress
    {	//IP addr
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] c;
    }
}