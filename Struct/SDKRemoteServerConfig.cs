using WinNetSDK.Class;
using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Определение структуры сервера
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SDK_RemoteServerConfig
    {
        /// <summary>
        /// Наименование сервера
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_NAME_PASSWORD_LEN)]
        public string ServerName;

        /// <summary>
        /// IP адрес
        /// </summary>
        public CONFIG_IPAddress ip;
        /// <summary>
        /// Номер порта
        /// </summary>
        public Int32 Port;

        /// <summary>
        /// Имя пользователя
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_NAME_PASSWORD_LEN)]
        public string UserName;

        /// <summary>
        /// Пароль
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_NAME_PASSWORD_LEN)]
        public string Password;

        /// <summary>
        /// Анонимный вход
        /// </summary>
        public byte Anonymity;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] res;
    };
}
