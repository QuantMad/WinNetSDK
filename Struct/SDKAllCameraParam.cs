using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Все конфигурации камеры
    /// </summary>
    public struct SDK_AllCameraParam
    {
        /// <summary>
        /// Все каналы
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public SDK_CameraParam[] vCameraParamAll;
    }
}