using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Структура возвращаемого видеофайла
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct H264_DVR_FILE_DATA
    {
        /// <summary>
        /// Номер канала
        /// </summary>
        public Int32 ch;
        /// <summary>
        /// Размер файла
        /// </summary>
        public Int32 size;

        /// <summary>
        /// Имя файла
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 108)]
        public string sFileName;

        /// <summary>
        /// Время начала файла
        /// </summary>
        public SDK_SYSTEM_TIME stBeginTime;
        /// <summary>
        /// Время окончания файла
        /// </summary>
        public SDK_SYSTEM_TIME stEndTime;
        public IntPtr hWnd;
        /// <summary>
        /// Тип потока - основной или вспомогательный
        /// </summary>
        public Int32 StreamType;

        //         H264_DVR_FILE_DATA()
        //         {
        //             hWnd = NULL;
        //             StreamType = 0;
        //         }
    }
}
