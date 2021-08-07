using System;

namespace WinNetSDK.Struct
{
    public struct SDK_TIMESECTION
    {
        /// <summary>
        /// Активировать
        /// </summary>
        public Int32 enable;
        /// <summary>
        /// Время начала: часы
        /// </summary>
        public Int32 startHour;
        /// <summary>
        /// Время начала: минуты
        /// </summary>
        public Int32 startMinute;
        /// <summary>
        /// Время начала: секунды
        /// </summary>
        public Int32 startSecond;
        /// <summary>
        /// Время окончания: часы
        /// </summary>
        public Int32 endHour;
        /// <summary>
        /// Время окончания: минуты
        /// </summary>
        public Int32 endMinute;
        /// <summary>
        /// Время окончания: секунды
        /// </summary>
        public Int32 endSecond;
    }
}