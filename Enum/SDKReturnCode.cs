namespace WinNetSDK.Enum
{
    /// <summary>
    /// Коды возвращаемых ошибок
    /// </summary>
    public enum SDK_RET_CODE
    {
        /// <summary>
        /// Нет ошибок
        /// </summary>
        H264_DVR_NOERROR = 0,
        /// <summary>
        /// Успех
        /// </summary>
        H264_DVR_SUCCESS = 1,
        /// <summary>
        /// Недопустимый запрос
        /// </summary>
        H264_DVR_SDK_NOTVALID = -10000,
        /// <summary>
        /// SDK не инициализирован
        /// </summary>
        H264_DVR_NO_INIT = -10001,
        /// <summary>
        /// Параметр пользователя недействителен
        /// </summary>
        H264_DVR_ILLEGAL_PARAM = -10002,
        /// <summary>
        /// Недействительный дескриптор
        /// </summary>
        H264_DVR_INVALID_HANDLE = -10003,
        /// <summary>
        /// SDK cleanup error
        /// </summary>
        H264_DVR_SDK_UNINIT_ERROR = -10004,
        /// <summary>
        /// Тайм-аут ожидания
        /// </summary>
        H264_DVR_SDK_TIMEsOUT = -10005,
        /// <summary>
        /// Ошибка памяти. Не удалось выделить память
        /// </summary>
        H264_DVR_SDK_MEMORY_ERROR = -10006,
        /// <summary>
        /// Сетевая ошибка
        /// </summary>
        H264_DVR_SDK_NET_ERROR = -10007,
        /// <summary>
        /// не удалось открыть файл
        /// </summary>
        H264_DVR_SDK_OPEN_FILE_ERROR = -10008,
        /// <summary>
        /// Непредвиденная ошибка
        /// </summary>
        H264_DVR_SDK_UNKNOWNERROR = -10009,
        /// <summary>
        /// Полученные данные неверны, несовпадение версий
        /// </summary>
        H264_DVR_DEV_VER_NOMATCH = -11000,
        /// <summary>
        /// Версия не поддерживается
        /// </summary>
        H264_DVR_SDK_NOTSUPPORT = -11001,

        /// <summary>
        /// Не удалось открыть канал
        /// </summary>
        H264_DVR_OPEN_CHANNEL_ERROR = -11200,
        /// <summary>
        /// Не удалось закрыть канал
        /// </summary>
        H264_DVR_CLOSE_CHANNEL_ERROR = -11201,
        /// <summary>
        /// Не удалось установить дополнительное подключение к мультимедиа
        /// </summary>
        H264_DVR_SUB_CONNECT_ERROR = -11202,
        /// <summary>
        /// Ошибка подключения к мультимедиа
        /// </summary>
        H264_DVR_SUB_CONNECT_SEND_ERROR = -11203,
        /// <summary>
        /// Количество ссылок NAT видео достигло максимума. Создание новой ссылки запрещено
        /// </summary>
        H264_DVR_NATCONNET_REACHED_MAX = -11204,

        // Коды ошибок части управления пользователями
        /// <summary>
        /// Недостаточно прав
        /// </summary>
        H264_DVR_NOPOWER = -11300,
        /// <summary>
        /// Неверный пароль учетной записи
        /// </summary>
        H264_DVR_PASSWORD_NOT_VALID = -11301,
        /// <summary>
        /// Пользователь не существует
        /// </summary>
        H264_DVR_LOGIN_USER_NOEXIST = -11302,
        /// <summary>
        /// Пользователь заблокирован
        /// </summary>
        H264_DVR_USER_LOCKED = -11303,
        /// <summary>
        /// Пользователь не имеет доступа (в черном списке)
        /// </summary>
        H264_DVR_USER_IN_BLACKLIST = -11304,
        /// <summary>
        /// Вход уже выполнен
        /// </summary>
        H264_DVR_USER_HAS_USED = -11305,
        /// <summary>
        /// Пользователь не авторизован
        /// </summary>
        H264_DVR_USER_NOT_LOGIN = -11306,
        /// <summary>
        /// Ошибка соединения: Устройство существует?
        /// </summary>
        H264_DVR_CONNECT_DEVICE_ERROR = -11307,
        /// <summary>
        /// User management input is invalid
        /// </summary>
        H264_DVR_ACCOUNT_INPUT_NOT_VALID = -11308,
        /// <summary>
        /// Наложение индексов
        /// </summary>
        H264_DVR_ACCOUNT_OVERLAP = -11309,
        /// <summary>
        /// Объект не существует
        /// </summary>
        H264_DVR_ACCOUNT_OBJECT_NONE = -11310,
        /// <summary>
        /// Объект недействителен
        /// </summary>
        H264_DVR_ACCOUNT_OBJECT_NOT_VALID = -11311,
        /// <summary>
        /// Объект уже используется
        /// </summary>
        H264_DVR_ACCOUNT_OBJECT_IN_USE = -11312,
        /// <summary>
        /// Когфликт прав доступа (например, разрешения группы превышают разрешения таблицы, разрешения пользователя превышают разрешения группы и т. Д.)
        /// </summary>
        H264_DVR_ACCOUNT_SUBSET_OVERLAP = -11313,
        /// <summary>
        /// Пароль неверен
        /// </summary>
        H264_DVR_ACCOUNT_PWD_NOT_VALID = -11314,
        /// <summary>
        /// Пароли не совпадают
        /// </summary>
        H264_DVR_ACCOUNT_PWD_NOT_MATCH = -11315,
        /// <summary>
        /// 保留帐号
        /// </summary>
        H264_DVR_ACCOUNT_RESERVED = -11316,

        // Коды ошибок, связанных с управлением конфигурацией
        /// <summary>
        /// После сохранения конфигурации необходимо перезапустить приложение
        /// </summary>
        H264_DVR_OPT_RESTART = -11400,
        /// <summary>
        /// Необходима перезагрузка устройства
        /// </summary>
        H264_DVR_OPT_REBOOT = -11401,
        /// <summary>
        /// Ошибка записи файла
        /// </summary>
        H264_DVR_OPT_FILE_ERROR = -11402,
        /// <summary>
        /// Функция конфигурации не поддерживается
        /// </summary>
        H264_DVR_OPT_CAPS_ERROR = -11403,
        /// <summary>
        /// Ошибка проверки конфигурации
        /// </summary>
        H264_DVR_OPT_VALIDATE_ERROR = -11404,
        /// <summary>
        /// Запрашиваемая или заданная конфигурация не существует
        /// </summary>
        H264_DVR_OPT_CONFIG_NOT_EXIST = -11405,

        /// <summary>
        /// Пауза не удалась
        /// </summary>
        H264_DVR_CTRL_PAUSE_ERROR = -11500,
        /// <summary>
        /// Поиск не удался, соответствующий файл не найден
        /// </summary>
        H264_DVR_SDK_NOTFOUND = -11501,
        /// <summary>
        ///  Конфигурация недоступна
        /// </summary>
        H264_DVR_CFG_NOT_ENABLE = -11502,
        /// <summary>
        /// Ошибка записи видео
        /// </summary>
        H264_DVR_DECORD_FAIL = -11503,

        // Коды ошибок анализа протокола DNS
        /// <summary>
        /// Не удалось создать сокет
        /// </summary>
        H264_DVR_SOCKET_ERROR = -11600,
        /// <summary>
        /// Не удалось подключиться к сокету
        /// </summary>
        H264_DVR_SOCKET_CONNECT = -11601,
        /// <summary>
        /// Ошибка разрешения доменного имени
        /// </summary>
        H264_DVR_SOCKET_DOMAIN = -11602,
        /// <summary>
        /// Не удалось отправить данные
        /// </summary>
        H264_DVR_SOCKET_SEND = -11603
    }
}
