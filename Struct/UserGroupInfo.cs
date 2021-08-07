using WinNetSDK.Class;
using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct USER_GROUP_INFO
    {
        public Int32 rigthNum;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_MAX_USER_LENGTH)]
        public string memo;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_MAX_USER_LENGTH)]
        public string name;

        /// <summary>
        /// Список прав
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = SDK_TYPE_LEN.NET_MAX_RIGTH_NUM)]
        public OPR_RIGHT[] rights;
    }
}
