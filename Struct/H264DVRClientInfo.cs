using System;

namespace WinNetSDK.Struct
{
    public struct H264_DVR_CLIENTINFO
    {
        /// <summary>
        /// Номер канала
        /// </summary>
        public Int32 nChannel;
        /// <summary>
        /// 0 - основной поток, 1 - дополнительный поток
        /// </summary>
        public Int32 nStream;
        /// <summary>
        /// 0 - Режим TCP, 
        /// 1 - Режим UDP, 
        /// 2 - режим многоадресной рассылки, 
        /// 3 - режим RTP, 
        /// 4 - разделеные аудио и видео (TCP)
        /// </summary>
        public Int32 nMode;
        /// <summary>
        /// Only the combination coding channel is effective, and the jigsaw patterns of combinatorial coding channels are combined
        /// </summary>
        public Int32 nComType;
        /// <summary>
        /// Preview the output window handle (for NULL, network data and decoding playback separately)
        /// </summary>
        public IntPtr hWnd;
    }
}
