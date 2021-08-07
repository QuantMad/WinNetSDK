using System;

namespace WinNetSDK.Struct
{
    public struct SDK_NetAlarmInfo
    {
        /// <summary>
        /// В настоящее время не используется
        /// </summary>
        public Int32 iEvent;
        /// <summary>
        /// Каждый бит представляет канал, бит 0: первый канал, 0 - нет сигнала тревоги, 1 - с тревогой и т. Д.
        /// </summary>
        public Int32 iState;
    }
}