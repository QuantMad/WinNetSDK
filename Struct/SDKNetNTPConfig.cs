using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Настройки NTP
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SDK_NetNTPConfig
    {
        /// <summary>
        /// Whether to open
        /// </summary>
        public byte Enable;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] res;

        /// <summary>
        /// PPPOE сервер
        /// </summary>
        public SDK_RemoteServerConfig Server;
        /// <summary>
        /// Период обновления
        /// </summary>
        public Int32 UpdatePeriod;
        /// <summary>
        /// Часовой пояс
        /// </summary>
        public Int32 TimeZone;
    }
}
