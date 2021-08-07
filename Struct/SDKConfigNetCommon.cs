using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Общие сетевые настройки
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SDK_CONFIG_NET_COMMON
    {
        /// <summary>
        /// main engine name
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string HostName;

        /// <summary>
        /// IP-адрес хоста
        /// </summary>
        public CONFIG_IPAddress HostIP;
        /// <summary>
        /// Маска подсети
        /// </summary>
        public CONFIG_IPAddress Submask;
        /// <summary>
        /// IP шлюза
        /// </summary>
        public CONFIG_IPAddress Gateway;
        /// <summary>
        /// Порт службы HTTP
        /// </summary>
        public Int32 HttpPort;
        /// <summary>
        /// Порт прослушивания TCP
        /// </summary>
        public Int32 TCPPort;
        /// <summary>
        /// Порт прослушивания SSL
        /// </summary>
        public Int32 SSLPort;
        /// <summary>
        /// Порт прослушивания UDP
        /// </summary>
        public Int32 UDPPort;
        /// <summary>
        /// Максимальное количество подключений
        /// </summary>
        public Int32 MaxConn;
        /// <summary>
        /// Протокол наблюдения {"TCP","UDP","MCAST",…}
        /// </summary>
        public Int32 MonMode;
        /// <summary>
        /// Ограничить значение кодового потока
        /// </summary>
        public Int32 MaxBps;
        /// <summary>
        /// Стратегия передачи
        /// </summary>
        public Int32 TransferPlan;
                                            //char TransferPlan[NET_NAME_PASSWORD_LEN];
        public byte bUseHSDownLoad;         //!是否启用高速录像下载测率

        /// <summary>
        /// MAC-адрес
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string sMac;
    }
}