using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Общая структура страницы конфигурации
    /// </summary>
    public struct SDK_CONFIG_NORMAL
    {
        /// <summary>
        /// Системное время
        /// </summary>
        public SDK_SYSTEM_TIME sysTime;
        /// <summary>
        /// Local number:[0, 998]
        /// </summary>
        public Int32 iLocalNo;
        /// <summary>
        /// Обработка «OverWrite», «StopRecord» при заполнении жесткого диска
        /// </summary>
        public Int32 iOverWrite;
        /// <summary>
        /// Интервал времени захвата по времени, в секундах
        /// </summary>
        public Int32 iSnapInterval;

        /// <summary>
        /// machine name
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sMachineName;

        /// <summary>
        /// Режим вывода
        /// </summary>
        public Int32 iVideoStartOutPut;
        /// <summary>
        /// Автоматический выход из локального меню (минуты) [0, 120]
        /// </summary>
        public Int32 iAutoLogout;
        /// <summary>
        /// Формат видео: «PAL», «NTSC», «SECAM»
        /// </summary>
        public Int32 iVideoFormat;
        /// <summary>
        /// Выбор языка:“English”, “SimpChinese”, “TradChinese”, “Italian”, “Spanish”, “Japanese”, “Russian”, “French”, “German” */
        /// </summary>
        public Int32 iLanguage;
        /// <summary>
        /// Формат даты:“YYMMDD”, “MMDDYY”, “DDMMYY”
        /// </summary>
        public Int32 iDateFormat;
        /// <summary>
        /// Разделитель даты:“.”, “-”, “/”
        /// </summary>
        public Int32 iDateSeparator;
        /// <summary>
        /// Формат времени:“12”, “24”
        /// </summary>
        public Int32 iTimeFormat;
        /// <summary>
        /// Правила перехода на летнее время 
        /// </summary>
        public Int32 iDSTRule;
        /// <summary>
        /// Рабочий день
        /// </summary>
        public Int32 iWorkDay;
        public DSTPoint dDSTStart;
        public DSTPoint dDSTEnd;
    }
}