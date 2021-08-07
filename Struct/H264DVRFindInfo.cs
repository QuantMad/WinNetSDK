using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// 查询录像条件
    /// </summary>
    public struct H264_DVR_FINDINFO
    {
        /// <summary>
        /// Номер канала
        /// </summary>
        public Int32 nChannelN0;
        /// <summary>
        /// Тип файла, см. SDK_File_Type
        /// </summary>
        public Int32 nFileType;
        /// <summary>
        /// Время начала
        /// </summary>
        public H264_DVR_TIME startTime;
        /// <summary>
        /// Время окончания
        /// </summary>
        public H264_DVR_TIME endTime;

        /// <summary>
        /// 卡号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szCard;

        /// <summary>
        /// Дескриптор окна
        /// </summary>
        public uint hWnd;
    }
}
