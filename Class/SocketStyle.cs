using System;

namespace WinNetSDK.Class
{
    public class SocketStyle
    {
        /// <summary>
        /// Обычный IP-логин
        /// </summary>
        public const Int32 TCPSOCKET = 0;
        public const Int32 UDPSOCKET = 1;
        /// <summary>
        /// Вход по серийному номеру
        /// </summary>
        public const Int32 NATOBJECT = 2;
    }
}