using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Информация о текущем состоянии устройства
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct H264_DVR_DEVICEINFO
    {
        /// <summary>
        ///  Информация о версии программного обеспечения
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sSoftWareVersion;

        /// <summary>
        /// Информация о версии оборудования
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sHardWareVersion;

        /// <summary>
        /// Зашифрованная информация о версии
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sEncryptVersion;

        /// <summary>
        /// Время создания программного обеспечения
        /// </summary>
        public SDK_SYSTEM_TIME tmBuildTime;

        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sSerialNumber;

        /// <summary>
        /// Количество каналов видеовхода
        /// </summary>
        public Int32 byChanNum;
        /// <summary>
        /// Количество каналов видеовыхода
        /// </summary>
        public Int32 iVideoOutChannel;
        /// <summary>
        /// Количество входных каналов сигнала оповещения
        /// </summary>
        public Int32 byAlarmInPortNum;
        /// <summary>
        /// Количество выходных каналов сигнала оповещения
        /// </summary>
        public Int32 byAlarmOutPortNum;
        /// <summary>
        /// Количество входных каналов домофона
        /// </summary>
        public Int32 iTalkInChannel;
        /// <summary>
        /// Количество выходных каналов домофона
        /// </summary>
        public Int32 iTalkOutChannel;
        /// <summary>
        /// Количество дополнительных каналов
        /// </summary>
        public Int32 iExtraChannel;
        /// <summary>
        /// Количество входных аудиоканалов
        /// </summary>
        public Int32 iAudioInChannel;
        /// <summary>
        /// Does the combination coding channel partition mode support switching?
        /// </summary>
        public Int32 iCombineSwitch;
        /// <summary>
        /// Количество цифровых каналов
        /// </summary>
        public Int32 iDigChannel;
        /// <summary>
        /// Продолжительность работы системы
        /// </summary>
        public Int32 uiDeviceRunTime;
        /// <summary>
        /// Тип устройства
        /// </summary>
        public Int32 deviceTye;

        /// <summary>
        /// Идентификатор оборудования
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sHardWare;

        /// <summary>
        /// Дата обновления, например: 2013-09-03 14:15:13
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string uUpdataTime;

        /// <summary>
        /// Update content
        /// </summary>
        public Int32 uUpdataType;

        /// <summary>
        /// 设备型号(底层库从加密里获得，sHardWare针对多个设备用同一个程序这种情况区分不了) 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string sDeviceModel;
        /// <summary>
        /// ID языка страны: 
        /// 0-Английский,
        /// 1-Китайский, 
        /// 2-Традиционный китайский,
        /// 3-Корейский, 
        /// 4-Немецкий, 
        /// 5-Португальский, 
        /// 6-Русский
        /// </summary>
        public Int32 nLanguage;

        /// <summary>
        /// Содержимое ошибки входа в облако
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string sCloudErrCode;

        /// <summary>
        /// Статус устройства
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public Int32[] status;

        public void Init()
        {
            status = new Int32[32];
            status[31] = Class.CppLibWrapper.g_config.nSDKType;
        }
    }
}