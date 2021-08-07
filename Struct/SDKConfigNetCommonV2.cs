using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SDK_CONFIG_NET_COMMON_V2
    {
        /// <summary>
        /// Имя хоста
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
        /// IP адрес шлюза
        /// </summary>
        public CONFIG_IPAddress Gateway;

        /// <summary>
        /// Адрес локальной ссылки
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string pLocalLinkAddr;

        /// <summary>
        /// IPv6-адрес
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string pAddr;

        /// <summary>
        /// IPv6 щлюз
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string pGateway;

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
        /// Протокол мониторинга {"TCP", "UDP", "MCAST",…}
        /// </summary>
        public Int32 MonMode;
        /// <summary>
        /// Ограничение значения кодового потока
        /// </summary>
        public Int32 MaxBps;

        //char TransferPlan[NET_NAME_PASSWORD_LEN];
        /// <summary>
        /// Стратегия передачи
        /// </summary>
        public Int32 TransferPlan;

        /// <summary>
        /// Включать ли высокоскоростную загрузку видео?
        /// </summary>
        public byte bUseHSDownLoad;

        /// <summary>
        /// MAC-адрес
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string sMac;

        /// <summary>
        /// серийный номер
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string sSn;

        /// <summary>
        /// Количество каналов
        /// </summary>
        public Int32 ChannelNum;
        /// <summary>
        /// Тип устройства, см. Enum SDK_DevType
        /// </summary>
        public Int32 Device_Type;

        /// <summary>
        /// Информация о версии
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string Version;

        /// <summary>
        /// Дата сборки
        /// </summary>
        SDK_SYSTEM_TIME BuildDate;

        /// <summary>
        /// Used to save and modify the information required by other manufacturers IP
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 49)]
        public string OtherFunction;

        /// <summary>
        /// Производитель устройства, см. Перечисление SDK_Manufacturer
        /// </summary>
        public char Manufacturer;

        /// <summary>
        /// Retain
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string Resume;
    }
}