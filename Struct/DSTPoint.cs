using System;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Структура перехода на летнее время
    /// </summary>
    public struct DSTPoint
    {
        /// <summary>
        /// Год
        /// </summary>
        public Int32 iYear;
        /// <summary>
        /// Месяц
        /// </summary>
        public Int32 iMonth;
        /// <summary>
        /// 周1:first to2 3 4 -1:last one 0:represents a method of daily calculation[-1,4]
        /// </summary>
        public Int32 iWeek;
        /// <summary>
        /// weekday from sunday=0	[0, 6]
        /// </summary>
        public Int32 iWeekDay;
        /// <summary>
        /// Час
        /// </summary>
        public Int32 Hour;
        /// <summary>
        /// Минута
        /// </summary>
        public Int32 Minute;
    }
}