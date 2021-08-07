namespace WinNetSDK.Enum
{
    /// <summary>
    /// Коды аварийных событий
    /// </summary>
    public enum SDK_EventCodeTypes
    {
        SDK_EVENT_CODE_INIT = 0,
        /// <summary>
        /// Local alarm (external alarm) 
        /// </summary>
        SDK_EVENT_CODE_LOCAL_ALARM = 1,
        /// <summary>
        /// Сетевое оповещение
        /// </summary>
        SDK_EVENT_CODE_NET_ALARM,
        /// <summary>
        /// Ручное оповещение
        /// </summary>
        SDK_EVENT_CODE_MANUAL_ALARM,
        /// <summary>
        /// Динамическое обнаружение
        /// </summary>
        SDK_EVENT_CODE_VIDEO_MOTION,
        /// <summary>
        /// Потеря видео
        /// </summary>
        SDK_EVENT_CODE_VIDEO_LOSS,
        /// <summary>
        /// Загромождение объектива
        /// </summary>
        SDK_EVENT_CODE_VIDEO_BLIND,
        SDK_EVENT_CODE_VIDEO_TITLE,
        SDK_EVENT_CODE_VIDEO_SPLIT,
        SDK_EVENT_CODE_VIDEO_TOUR,
        /// <summary>
        /// Устройство хранения не существует
        /// </summary>
        SDK_EVENT_CODE_STORAGE_NOT_EXIST,
        /// <summary>
        /// Не удалось получить доступ к устройству хранения
        /// </summary>
        SDK_EVENT_CODE_STORAGE_FAILURE,
        /// <summary>
        /// Недостаточно места на устройстве хранения
        /// </summary>
        SDK_EVENT_CODE_LOW_SPACE,
        SDK_EVENT_CODE_NET_ABORT,
        SDK_EVENT_CODE_COMM,
        /// <summary>
        /// Ошибка чтения устройства хранения
        /// </summary>
        SDK_EVENT_CODE_STORAGE_READ_ERROR,
        /// <summary>
        /// Ошибка записи устройства хранения
        /// </summary>
        SDK_EVENT_CODE_STORAGE_WRITE_ERROR,
        /// <summary>
        /// Конфликт IP адресов
        /// </summary>
        SDK_EVENT_CODE_NET_IPCONFLICT,
        SDK_EVENT_CODE_ALARM_EMERGENCY,
        SDK_EVENT_CODE_DEC_CONNECT,
        SDK_EVENT_CODE_UPGRADE,
        SDK_EVENT_CODE_BACK_UP,
        SDK_EVENT_CODE_SHUT_DOWN,
        SDK_EVENT_CODE_REBOOT,
        SDK_EVENT_CODE_NEWFILE,
        SDK_EVENT_CODE_VideoAnalyze,
        SDK_EVENT_CODE_IPC_ALARM,
        SDK_EVENT_CODE_SPEED_ALARM,
        SDK_EVENT_CODE_GSENSOR_AlARM,
        /// <summary>
        /// Ошибка входа
        /// </summary>
        SDK_EVENT_CODE_LOGIN_FAILED,
        SDK_EVENT_CODE_SERIAL_ALARM,
        /// <summary>
        /// Индивидуальная сигнализация PIR
        /// </summary>
        SDK_EVENT_CODE_PIR_ALARM,
        /// <summary>
        /// 消费类产品绑定的外部设备报警
        /// </summary>
        SDK_EVENT_CODE_CONSSENSOR_ALARM,
        /// <summary>
        /// 家用产品，语音识别敏感词报警
        /// </summary>
        SDK_EVENT_CODE_WORDDETECT,
        /// <summary>
        /// Оповещение нечеткого обнаружения
        /// </summary>
        SDK_EVENT_CODE_BLURCHECK_ALARM,
        /// <summary>
        /// Оповещение обнаружения номерного знака
        /// </summary>
        SDK_EVENT_CODE_PLATEDETECT,
        /// <summary>
        /// Оповещение обнаружения лица
        /// </summary>
        SDK_EVENT_CODE_FACEDETECT,
        /// <summary>
        /// Индивидуальное оповещение 433
        /// </summary>
        SDK_EVENT_CODE_433ALARM,
        /// <summary>
        /// Обнаружение PIR
        /// </summary>
        SDK_EVENT_CODE_PIRDetect = 38,
        SDK_EVENT_CODE_NR,
    }
}
