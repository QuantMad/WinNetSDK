using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    public struct DDNS_INFO
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string ID;    // Идентификация оборудования

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string IP;               //内网IP

        public Int32 WebPort;           // Веб-порт (по умолчанию 80)
        public Int32 MediaPort;         // Медиа-порт (по умолчанию 34567)
        public Int32 MobilePort;        // Порт мониторинга мобильного телефона (по умолчанию - 34599)
        public Int32 UPNPWebPort;       //UPNP启动下Web端口,UPNP不开启为0
        public Int32 UPNPMediaPort;     //UPNP启动下媒体端口,UPNP不开启为0
        public Int32 UPNPMobilePort;    //UPNP启动下手机监控端口,UPNP不开启为0

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        string Username;    // Имя пользователя

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        string Password;    // Пароль
    }
}
