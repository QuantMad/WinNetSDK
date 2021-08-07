using System;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Настройки цветности видео
    /// </summary>
    public struct SDK_VIDEOCOLOR
    {
        /// <summary>
        /// Time segment
        /// </summary>
        public SDK_TIMESECTION tsTimeSection;
        /// <summary>
        /// Color definition
        /// </summary>
        public SDK_VIDEOCOLOR_PARAM dstColor;
        public Int32 iEnable;
    }
}