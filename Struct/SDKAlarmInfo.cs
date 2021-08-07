using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Информация об оповещении
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SDK_ALARM_INFO
    {
        /// <summary>
        /// Номер канала
        /// </summary>
        public Int32 nChannel;
        /// <summary>
        /// Код события оповещения: см. Перечисление SDK_EventCodeTypes
        /// </summary>
        public Int32 iEvent;
        /// <summary>
        /// 0: оповещение начинается, 1: оповещение заканчивается
        /// </summary>
        public Int32 iStatus;
        public SDK_SYSTEM_TIME SysTime;

        /// <summary>
        /// 附加信息，发送者和接收者对各种报警类型进行格式约定
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] pExtInfo;
    }
}
