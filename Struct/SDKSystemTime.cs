using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Структура системного времени
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SDK_SYSTEM_TIME
    {
        /// <summary>
        /// Год
        /// </summary>
        public Int32 year;
        /// <summary>
        /// Месяц: январь = 1, февраль = 2 и т.Д.
        /// </summary>
        public Int32 month;
        /// <summary>
        /// День
        /// </summary>
        public Int32 day;
        /// <summary>
        /// Неделя: Воскресенье = 0, понедельник = 1 и так далее
        /// </summary>
        public Int32 wday;
        /// <summary>
        /// Час
        /// </summary>
        public Int32 hour;
        /// <summary>
        /// Минута
        /// </summary>
        public Int32 minute;
        /// <summary>
        /// Секунда
        /// </summary>
        public Int32 second;
        /// <summary>
        /// Индикатор перехода на летнее время
        /// </summary>
        public Int32 isdst;
    }
}