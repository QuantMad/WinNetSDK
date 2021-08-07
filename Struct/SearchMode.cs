using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    public struct SearchMode
    {
        /// <summary>
        /// Тип запроса, см. SearchModeType
        /// </summary>
        public Int32 nType;

        /// <summary>
        /// Адрес сервера
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szSerIP;

        /// <summary>
        /// Номер порта сервера
        /// </summary>
        public Int32 nSerPort;

        /// <summary>
        /// Если вход выполнен по серийному номеру, то это серийный номер, если по имени пользователя, то это имя пользователя
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string szSerialInfo;
    }
}
