using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Конфигурация DHCP для всех сетевых карт
    /// </summary>
    public struct SDK_NetDHCPConfigAll
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public SDK_NetDHCPConfig[] vNetDHCPConfig;
    }
}
