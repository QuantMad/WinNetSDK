using System;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Конфигурация усиления
    /// </summary>
    public struct SDK_GainCfg
    {
        /// <summary>
        /// Верхний предел автоматического усиления (автоматическое усиление включено) или фиксированное значение усиления
        /// </summary>
        public Int32 gain;
        /// <summary>
        /// Включено ли автоматическое усиление, 0: не включено 1: включено
        /// </summary>
        public Int32 autoGain;
    }
}