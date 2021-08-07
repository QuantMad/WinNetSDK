using WinNetSDK.Enum;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Поддерживаемые системные функции
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SDK_SystemFunction
    {
        /// <summary>
        /// Функция кодирования SDK_EncodeFunctionTypes
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)SDK_EncodeFunctionTypes.SDK_ENCODE_FUNCTION_TYPE_NR)]
        public byte[] vEncodeFunction;

        /// <summary>
        /// Функция оповещения AlarmFucntionTypes
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)SDK_AlarmFucntionTypes.SDK_ALARM_FUNCTION_TYPE_NR)]
        public byte[] vAlarmFunction;

        /// <summary>
        /// Функция сетевой службы NetServerTypes
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)SDK_NetServerTypes.SDK_NET_SERVER_TYPES_NR)]
        public byte[] vNetServerFunction;

        /// <summary>
        /// Типы предварительного просмотра
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)SDK_PreviewTypes.SDK_PREVIEW_TYPES_NR)]
        public byte[] vPreviewFunction;

        /// <summary>
        /// Тип последовательного порта SDK_CommTypes
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)SDK_CommTypes.SDK_COMM_TYPES_NR)]
        public byte[] vCommFunction;

        /// <summary>
        /// Ограничение метода ввода SDK_InPutMethod>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)SDK_InPutMethod.SDK_NO_SUPPORT_NR)]
        public byte[] vInputMethodFunction;

        /// <summary>
        /// Отображение метки оповещения SDK_TipShow>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)SDK_TipShow.SDK_NO_TIP_SHOW_NR)]
        public byte[] vTipShowFunction;

        /// <summary>
        /// Функция автомобиля
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)SDK_MobileCar.SDK_MOBILEDVR_NR)]
        public byte[] vMobileCarFunction;

        /// <summary>
        /// Прочие функции
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)SDK_OtherFunction.SDK_OTHER_NR)]
        public byte[] vOtherFunction;
    }
}
