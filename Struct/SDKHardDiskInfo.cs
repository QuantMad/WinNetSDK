using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SDK_HardDiskInfo
    {
        /// <summary>
        /// 是否为当前工作盘
        /// </summary>
        public bool bIsCurrent;
        /// <summary>
        /// Общая емкость (МБ)
        /// </summary>
        public UInt32 uiTotalSpace;
        /// <summary>
        /// Доступный объём (МБ)
        /// </summary>
        public UInt32 uiRemainSpace;
    }
}
