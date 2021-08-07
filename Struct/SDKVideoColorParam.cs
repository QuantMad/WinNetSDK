using System;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Цвет видео
    /// </summary>
    public struct SDK_VIDEOCOLOR_PARAM
    {
        /// <summary>
        /// Яркость 0-100
        /// </summary>
        public Int32 nBrightness;
        /// <summary>
        /// Контраст 0-100
        /// </summary>
        public Int32 nContrast;
        /// <summary>
        /// Насыщенность 0-100
        /// </summary>
        public Int32 nSaturation;
        /// <summary>
        /// Цветность 0-100
        /// </summary>
        public Int32 nHue;
        /// <summary>
        /// Усиление 0-100. 1 седьмого бита - автоматическое усиление
        /// </summary>
        public Int32 mGain;
        /// <summary>
        /// Автоматический контроль уровня белого (бит 7 установлен, чтобы указать, что автоматическое управление включено). 
        /// 0x0, 0x1,0x2 представляют низкий, средний и высокий уровни соответственно
        /// </summary>
        public Int32 mWhitebalance;
        /// <summary>
        ///  Острота 0-15
        /// </summary>
        public Int32 nAcutance;
    }
}
