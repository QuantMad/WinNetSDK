using WinNetSDK.Class;
using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct USER_INFO
    {
        public Int32 rigthNum;

        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SDK_TYPE_LEN.NET_MAX_RIGTH_NUM)]
        public OPR_RIGHT[] rights;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_MAX_USER_LENGTH)]
        public string Groupname;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_MAX_USER_LENGTH)]
        public string memo;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_MAX_USER_LENGTH)]
        public string name;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_MAX_USER_LENGTH)]
        public string passWord;

        /// <summary>
        /// 是否保留
        /// </summary>
        public byte reserved;
        /// <summary>
        /// Разрешено ли этому пользователю повторно использовать 1-мультиплексный, 0-немультиплексный режим
        /// </summary>
        public byte shareable;
        
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] res;
    }
}
