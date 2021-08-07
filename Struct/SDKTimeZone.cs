using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Изменить часовой пояс устройства
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SDK_TimeZone
    {
        /// <summary>
        /// Разница со временем UTC в минутах (может быть отрицательной)
        /// </summary>
        public Int32 minuteswest;
        /// <summary>
        /// Используется для того, чтобы время не изменилось при первом использовании
        /// </summary>
        public Int32 FistFlag;
    }
}
