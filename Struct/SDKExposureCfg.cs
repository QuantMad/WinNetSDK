using System;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Конфигурация экспозиции
    /// </summary>
    public struct SDK_ExposureCfg
    {
        /// <summary>
        /// Уровень экспозиции
        /// </summary>
        public Int32 level;
        /// <summary>
        /// Нижний предел времени автоматической или ручной выдержки в микросекундах
        /// </summary>
        public uint leastTime;
        /// <summary>
        /// Верхний предел времени автоэкспозиции в микросекундах
        /// </summary>
        public uint mostTime;
    }
}