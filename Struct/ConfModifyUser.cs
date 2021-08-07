using WinNetSDK.Class;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    // 修改用户
    [StructLayout(LayoutKind.Sequential)]
    public struct CONF_MODIFYUSER
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_MAX_USER_LENGTH)]
        public string UserName;
        public USER_INFO User;
    }
}
