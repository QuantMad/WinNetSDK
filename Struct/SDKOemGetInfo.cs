using WinNetSDK.Class;
using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SDK_OemGetInfo
    {
        /// <summary>
        /// Количество подключений
        /// </summary>
        public Int32 iConnectNum;
        /// <summary>
        /// Количество жестких дисков
        /// </summary>
        public Int32 iDisk;

        /// <summary>
        /// Оставшаяся емкость жесткого диска
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = SDK_TYPE_LEN.SDK_MAX_DISK_PER_MACHINE)]
        public SDK_HardDiskInfo[] cHardDisk;

        /// <summary>
        /// Статус записи
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = SDK_TYPE_LEN.NET_MAX_CHANNUM)]
        public byte[] cRecordState;

        /// <summary>
        /// Информация о версии
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string version;
    }
}
