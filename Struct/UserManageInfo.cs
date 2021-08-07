using WinNetSDK.Class;
using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Структура конфигурации пользовательской информации
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct USER_MANAGE_INFO
    {
        public Int32 rigthNum;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = SDK_TYPE_LEN.NET_MAX_RIGTH_NUM)]
        public OPR_RIGHT[] rightList;

        public Int32 groupNum;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = SDK_TYPE_LEN.NET_MAX_GROUP_NUM)]
        public USER_GROUP_INFO[] groupList;

        public Int32 userNum;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = SDK_TYPE_LEN.NET_MAX_USER_NUM)]
        public USER_INFO[] userList;
    }
}
