using System;

namespace WinNetSDK.Enum
{
    public enum SDK_CONFIG_TYPE
    {
        E_SDK_CONFIG_NOTHING = 0,
        /// <summary>
        /// Информация о пользователях, включая список разрешений, список пользователей и т.д., в соответствии со структурой USER_MANAGE_INFO
        /// </summary>
        E_SDK_CONFIG_USER,
        /// <summary>
        /// Добавить пользователей - соответствующая структура USER_INFO
        /// </summary>
        E_SDK_CONFIG_ADD_USER,
        /// <summary>
        /// Изменить пользователя - соответствующая структура CONF_MODIFYUSER
        /// </summary>
        E_SDK_CONFIG_MODIFY_USER,
        /// <summary>
        /// Удалить пользователя - соответствующая структура USER_INFO
        /// </summary>
        E_SDK_CONFIG_DELETE_USER,
        /// <summary>
        /// Добавить группу - соответствующая структура USER_GROUP_INFO
        /// </summary>
        E_SDK_CONFIG_ADD_GROUP,
        /// <summary>
        /// Изменить группу - соответствующая структура CONF_MODIFYGROUP
        /// </summary>
        E_SDK_CONFIG_MODIFY_GROUP,
        /// <summary>
        /// Удалить грумму - соответствующая структура - USER_GROUP_INFO
        /// </summary>
        E_SDK_COFIG_DELETE_GROUP,
        /// <summary>
        /// Изменить пароль - соответствующая структура CONF_MODIFY_PSW
        /// </summary>
        E_SDK_CONFIG_MODIFY_PSW,
        /// <summary>
        /// Поддерживаемая сетевая функция - соответствующая структура SDK_SystemFunction
        /// </summary>
        E_SDK_CONFIG_ABILITY_SYSFUNC = 9,
        /// <summary>
        /// Прежде чем получить возможность кодирования - соответствующая структура CONFIG_EncodeAbility
        /// </summary>
        E_SDK_CONFIG_ABILTY_ENCODE = 10,
        /// <summary>
        /// Протокол PTZ --- соответствующая структура SDK_PTZPROTOCOLFUNC
        /// </summary>
        E_SDK_CONFIG_ABILITY_PTZPRO,
        /// <summary>
        /// Протокол последовательного порта - соответствующая структура SDK_COMMFUNC
        /// </summary>
        E_SDK_COMFIG_ABILITY_COMMPRO,
        /// <summary>
        /// Функция динамического обнаружения
        /// </summary>
        E_SDK_CONFIG_ABILITY_MOTION_FUNC,
        /// <summary>
        /// Функция обнаружения "слепоты" камеры - соответствующая структура SDK_BlindDetectFunction
        /// </summary>
        E_SDK_CONFIG_ABILITY_BLIND_FUNC,
        /// <summary>
        /// Поддерживаемый тип DDNS сервиса - соответствующая структура SDK_DDNSServiceFunction
        /// </summary>
        E_SDK_CONFIG_ABILITY_DDNS_SERVER,
        /// <summary>
        /// Тип кодирования домофона - соответствующая структура SDK_DDNSServiceFunction
        /// </summary>
        E_SDK_CONFIG_ABILITY_TALK,
        /// <summary>
        /// Системная информация - соответствующая структура H264_DVR_DEVICEINFO
        /// </summary>
        E_SDK_CONFIG_SYSINFO = 17,
        /// <summary>
        /// Общая конфигурация - соответствующая структура SDK_CONFIG_NORMAL
        /// </summary>
        E_SDK_CONFIG_SYSNORMAL,
        /// <summary>
        /// Конфигурация кодировки - соответствующая структура SDK_EncodeConfigAll
        /// </summary>
        E_SDK_CONFIG_SYSENCODE,
        /// <summary>
        /// Сетевые настройки - соответствующая структура SDK_CONFIG_NET_COMMON
        /// </summary>
        E_SDK_CONFIG_SYSNET = 20,
        /// <summary>
        /// Страница PTZ - соответствующая структура SDK_STR_PTZCONFIG_ALL
        /// </summary>
        E_SDK_CONFIG_PTZ,
        /// <summary>
        /// Страница серийного порта - соответствующая структура SDK_CommConfigAll
        /// </summary>
        E_SDK_CONFIG_COMM,
        /// <summary>
        /// Интерфейс настройки записи - соответствующая структура SDK_RECORDCONFIG
        /// </summary>
        E_SDK_CONFIG_RECORD,
        /// <summary>
        /// Страница динамического обнаружения движения - соответствующая структура SDK_MOTIONCONFIG
        /// </summary>
        E_SDK_CONFIG_MOTION,
        /// <summary>
        /// Видео окклюзия - соответствующая структура SDK_BLINDDETECTCONFIG
        /// </summary>
        E_SDK_CONFIG_SHELTER,
        /// <summary>
        /// Потеря видеосигнала - соответствующая структура SDK_VIDEOLOSSCONFIG
        /// </summary>
        E_SDK_CONFIG_VIDEO_LOSS,
        /// <summary>
        /// Вход сигнала оповещения - соответствующая структура SDK_ALARM_INPUTCONFIG
        /// </summary>
        E_SDK_CONFIG_ALARM_IN,
        /// <summary>
        /// Выход сигнала оповещения - соответствующая структура SDK_AlarmOutConfigAll
        /// </summary>
        E_SDK_CONFIG_ALARM_OUT,
        /// <summary>
        /// Интерфейс управления жестким диском - соответствующая структура SDK_StorageDeviceControl
        /// </summary>
        E_SDK_CONFIG_DISK_MANAGER,
        /// <summary>
        /// Интерфейс режима вывода - соответствующая структура SDK_VideoWidgetConfigAll
        /// </summary>
        E_SDK_CONFIG_OUT_MODE = 30,
        /// <summary>
        /// Название канала - соответствующая структура SDK_ChannelNameConfigAll
        /// </summary>
        E_SDK_CONFIG_CHANNEL_NAME,
        /// <summary>
        /// Настройка интерфейса автоматического обслуживания - соответствующая структура SDK_AutoMaintainConfig
        /// </summary>
        E_SDK_CONFIG_AUTO,
        /// <summary>
        /// Восстановить конфигурацию интерфейса по умолчанию - соответствующую структуру SDK_SetDefaultConfigTypes
        /// </summary>
        E_SDK_CONFIG_DEFAULT,
        /// <summary>
        /// Информация о жестком диске - соответствующая структура SDK_StorageDeviceInformationAll
        /// </summary>
        E_SDK_CONFIG_DISK_INFO,
        /// <summary>
        /// Журнал запросов - соответствующая структура SDK_LogList
        /// </summary>
        E_SDK_CONFIG_LOG_INFO,
        /// <summary>
        /// Конфигурация черного списка IP адресов - соответствующая структура SDK_NetIPFilterConfig
        /// </summary>
        E_SDK_CONFIG_NET_IPFILTER,
        /// <summary>
        /// Конфигурация DHCP - соответствующая структура SDK_NetDHCPConfigAll
        /// </summary>
        E_SDK_CONFIG_NET_DHCP,
        /// <summary>
        /// Информация о DDNS - соответствующая структура SDK_NetDDNSConfigALL
        /// </summary>
        E_SDK_CONFIG_NET_DDNS,
        /// <summary>
        /// EMAIL - соответствующая структура SDK_NetEmailConfig
        /// </summary>
        E_SDK_CONFIG_NET_EMAIL,
        /// <summary>
        /// Multicast - соответствующая структура SDK_NetMultiCastConfig
        /// </summary>
        E_SDK_CONFIG_NET_MULTICAST = 40,
        /// <summary>
        /// NTP - соответствующая структура SDK_NetNTPConfig
        /// </summary>
        E_SDK_CONFIG_NET_NTP,
        /// <summary>
        /// PPPOE - соответствующая структура SDK_NetPPPoEConfig
        /// </summary>
        E_SDK_CONFIG_NET_PPPOE,
        /// <summary>
        /// DNS - соответствующая структура SDK_NetDNSConfig
        /// </summary>
        E_SDK_CONFIG_NET_DNS,
        /// <summary>
        /// FTP - соответствующая структура SDK_FtpServerConfig
        /// </summary>
        E_SDK_CONFIG_NET_FTPSERVER,
        /// <summary>
        /// Системное время - соответствующая структура SDK_SYSTEM_TIME (также может быть реализован в H264_DVR_SetSystemDateTime)
        /// </summary>
        E_SDK_CONFIG_SYS_TIME,
        /// <summary>
        /// Очистить журнал - соответствующая структура H264_DVR_ControlDVR
        /// </summary>
        E_SDK_CONFIG_CLEAR_LOG,
        /// <summary>
        /// Сброс устройства - соответствующая структура H264_DVR_ControlDVR
        /// </summary>
        E_SDK_REBOOT_DEV,
        /// <summary>
        /// Поддерживаемые языки - соответствующая структура SDK_MultiLangFunction
        /// </summary>
        E_SDK_CONFIG_ABILITY_LANG,
        E_SDK_CONFIG_VIDEO_FORMAT,
        /// <summary>
        /// Комбинированное кодирование - соответствующая структура SDK_CombineEncodeConfigAll
        /// </summary>
        E_SDK_CONFIG_COMBINEENCODE = 50,
        /// <summary>
        /// Экспорт конфигурации
        /// </summary>
        E_SDK_CONFIG_EXPORT,
        /// <summary>
        /// Импорт конфигурации
        /// </summary>
        E_SDK_CONFIG_IMPORT,
        /// <summary>
        /// Экспорт журнала
        /// </summary>
        E_SDK_LOG_EXPORT,
        /// <summary>
        /// Режим комбинированного кодирования - соответствующая структура SDK_CombEncodeModeAll
        /// </summary>
        E_SDK_CONFIG_COMBINEENCODEMODE,
        /// <summary>
        /// Состояние выполнения - соответствующая структура SDK_DVR_WORKSTATE (так же H264_DVR_GetDVRWorkState)
        /// </summary>
        E_SDK_WORK_STATE,
        /// <summary>
        /// Фактический набор поддерживаемых языков - соответствующая структура SDK_MultiLangFunction
        /// </summary>
        E_SDK_ABILITY_LANGLIST,
        /// <summary>
        /// ARSP - соответствующая структура SDK_NetARSPConfigAll
        /// </summary>
        E_SDK_CONFIG_NET_ARSP,
        /// <summary>
        /// Настройки захвата - соответствующая структура SDK_SnapshotConfig
        /// </summary>
        E_SDK_CONFIG_SNAP_STORAGE,
        /// <summary>
        /// Настройка 3G - соответствующая структура SDK_Net3GConfig
        /// </summary>
        E_SDK_CONFIG_NET_3G,
        /// <summary>
        /// Мониторинг мобильного телефона - соответствующая структура SDK_NetMoblieConfig
        /// </summary>
        E_SDK_CONFIG_NET_MOBILE = 60,
        /// <summary>
        /// Получить информацию об обновлении/параметры/имя файла - соответствующая структура SDK_UpgradeInfo
        /// </summary>
        E_SDK_CONFIG_UPGRADEINFO,
        /// <summary>
        /// Настройка адреса декодера (V1) (Depracted) - соответствующая структура SDK_NetDecoderConfigAll
        /// </summary>
        [Obsolete("Depracted")]
        E_SDK_CONFIG_NET_DECODER,
        /// <summary>
        /// Фактический поддерживаемый формат видео - соответствующая структура SDK_MultiVstd
        /// </summary>
        E_SDK_ABILITY_VSTD,
        /// <summary>
        /// Фактический поддерживаемый формат видео - соответствующая структура SDK_MultiVstd
        /// </summary>
        E_SDK_CONFIG_ABILITY_VSTD,
        /// <summary>
        /// Настройки UPNP - соответствующая структура SDK_NetUPNPConfig
        /// </summary>
        E_SDK_CONFIG_NET_UPNP,
        /// <summary>
        /// Настройка WIFI - соответствующая структура SDK_NetWifiConfig
        /// </summary>
        E_SDK_CONFIG_NET_WIFI,
        /// <summary>
        /// Список найденных Wi-Fi точен доступа - соответствующая структура SDK_NetWifiDeviceAll
        /// </summary>
        E_SDK_CONFIG_NET_WIFI_AP_LIST,
        /// <summary>
        /// 简化的编码配置 - соответствующая структура SDK_EncodeConfigAll_SIMPLIIFY
        /// </summary>
        E_SDK_CONFIG_SYSENCODE_SIMPLIIFY,
        /// <summary>
        /// Центр оповещений - соответствующая структура SDK_NetAlarmServerConfigAll
        /// </summary>
        E_SDK_CONFIG_ALARM_CENTER,
        /// <summary>
        /// Сетеваое оповещение - соответствующая структура SDK_NETALARMCONFIG_ALL
        /// </summary>
        E_SDK_CONFIG_NET_ALARM = 70,
        /// <summary>
        /// 互信互通 - соответствующая структура SDK_CONFIG_NET_MEGA
        /// </summary>
        E_SDK_CONFIG_NET_MEGA,
        /// <summary>
        /// Xingwang - соответствующая структура SDK_CONFIG_NET_XINGWANG
        /// </summary>
        E_SDK_CONFIG_NET_XINGWANG,
        /// <summary>
        /// Seesou - соответствующая структура SDK_CONFIG_NET_SHISOU
        /// </summary>
        E_SDK_CONFIG_NET_SHISOU,
        /// <summary>
        /// VVEYE - соответствующая структура SDK_CONFIG_NET_VVEYE
        /// </summary>
        E_SDK_CONFIG_NET_VVEYE,
        /// <summary>
        /// SMS - соответствующая структура SDK_NetShortMsgCfg
        /// </summary>
        E_SDK_CONFIG_NET_PHONEMSG,
        /// <summary>
        /// MMS - соответствующая структура SDK_NetMultimediaMsgCfg
        /// </summary>
        E_SDK_CONFIG_NET_PHONEMEDIAMSG,
        E_SDK_VIDEO_PREVIEW,
        /// <summary>
        /// Set V2 to decoder address
        /// </summary>
        [Obsolete("Depracted")]
        E_SDK_CONFIG_NET_DECODER_V2,
        /// <summary>
        /// Set V3 to decoder address - соответствующая структура SDK_NetDecorderConfigAll_V3
        /// </summary>
        E_SDK_CONFIG_NET_DECODER_V3,
        /// <summary>
        /// Серийный номер - соответствующая структура SDK_AbilitySerialNo
        /// </summary>
        [Obsolete("работает некорректно (временно отказаться), серийный номер можно получить из интерфейса входа в систему")]
        E_SDK_CONFIG_ABILITY_SERIALNO = 80,
        /// <summary>
        /// RTSP - соответствующая структура SDK_NetRTSPConfig
        /// </summary>
        E_SDK_CONFIG_NET_RTSP,
        /// <summary>
        /// Настройка вывода локального графического интерфейса - соответствующая структура SDK_GUISetConfig
        /// </summary>
        E_SDK_GUISET,
        /// <summary>
        /// Снимок
        /// </summary>
        E_SDK_CATCHPIC,
        /// <summary>
        /// Настройка цвета видео - соответствующая структура SDK_VideoColorConfigAll
        /// </summary>
        E_SDK_VIDEOCOLOR,
        /// <summary>
        /// Конфигурация протокола последовательного порта 485 - соответствующая структура SDK_STR_RS485CONFIG_ALL
        /// </summary>
        E_SDK_CONFIG_COMM485,
        /// <summary>
        /// Протокол последовательного порта 485 - соответствующая структура SDK_COMMFUNC
        /// </summary>
        E_SDK_COMFIG_ABILITY_COMMPRO485,
        /// <summary>
        /// Установить системное время noRtc - соответствующая структура SDK_SYSTEM_TIME
        /// </summary>
        E_SDK_CONFIG_SYS_TIME_NORTC,
        /// <summary>
        /// Удаленный канал
        /// </summary>
        [Obsolete("Не рекоммендуется")]
        E_SDK_CONFIG_REMOTECHANNEL,
        /// <summary>
        /// Открыть канал "прозрачного" серичного порта - соответствующая структура TransComChannel
        /// </summary>
        E_SDK_CONFIG_OPENTRANSCOMCHANNEL,
        /// <summary>
        /// Закрыть канал "прозрачного" серичного порта - соответствующая структура TransComChannel
        /// </summary>
        E_SDK_CONFIG_CLOSETRANSCOMCHANNEL = 90,
        /// <summary>
        /// Отправить информацию в канал "прозрачного" серийного порта
        /// </summary>
        E_SDK_CONFIG_SERIALWIRTE,
        /// <summary>
        /// Считать информацию из канала "прозрачного" серийного порта
        /// </summary>
        E_SDK_CONFIG_SERIALREAD,
        /// <summary>
        /// Информация о lattice(?). для изменения имени канала IPC требуется информация о lattice(?) - соответствующая структура SDK_TitleDot
        /// </summary>
        E_SDK_CONFIG_CHANNELTILE_DOT,
        /// <summary>
        /// Параметры камеры - соответствующая структура SDK_CameraParam
        /// </summary>
        E_SDK_CONFIG_CAMERA,
        /// <summary>
        /// Уровень экспозиционной способности - соответствующая структура SDK_CameraAbility
        /// </summary>
        E_SDK_CONFIG_ABILITY_CAMERA,
        /// <summary>
        /// Отладка команд
        /// </summary>
        E_SDK_CONFIG_BUGINFO,
        /// <summary>
        /// Жесткий диск не существует - соответствующая структура SDK_VIDEOLOSSCONFIG
        /// </summary>
        E_SDK_CONFIG_STORAGENOTEXIST,
        /// <summary>
        /// Недостаточно места на жестком диске - соответствующая структура SDK_StorageLowSpaceConfig
        /// </summary>
        E_SDK_CONFIG_STORAGELOWSPACE,
        /// <summary>
        /// Ошибка жесткого диска - соответствующая структура SDK_StorageFailConfig
        /// </summary>
        E_SDK_CONFIG_STORAGEFAILURE,
        /// <summary>
        /// Конфликт IP адресов - соответствующая структура SDK_VIDEOLOSSCONFIG
        /// </summary>
        E_SDK_CFG_NETIPCONFLICT = 100,
        /// <summary>
        /// Network abnormal - соответствующая структура SDK_VIDEOLOSSCONFIG 
        /// </summary>
        E_SDK_CFG_NETABORT,
        /// <summary>
        /// Статус канала - соответствующая структура SDK_NetDecorderChnStatusAll
        /// </summary>
        E_SDK_CONFIG_CHNSTATUS,
        /// <summary>
        /// Режим канала - соответствующая структура SDK_NetDecorderChnModeConfig
        /// </summary>
        E_SDK_CONFIG_CHNMODE,
        /// <summary>
        /// Active registration - соответствующая структура SDK_DASSerInfo
        /// </summary>
        E_SDK_CONFIG_NET_DAS,
        /// <summary>
        /// Соответствие между поступающей внешней информацией и состоянием транспортного средства - соответствующая структура SDK_CarStatusExchangeAll
        /// </summary>
        E_SDK_CONFIG_CAR_INPUT_EXCHANGE,
        /// <summary>
        /// Vehicle system delay allocation - соответствующая структура SDK_CarDelayTimeConfig
        /// </summary>
        E_SDK_CONFIG_DELAY_TIME,
        /// <summary>
        /// Сетевой приоритет - соответствующая структура SDK_NetOrderConfig
        /// </summary>
        E_SDK_CONFIG_NET_ORDER,
        /// <summary>
        /// Возможность установки сетевого приоритета - соответствующая структура SDK_NetOrderFunction
        /// </summary>
        E_SDK_CONFIG_ABILITY_NETORDER,
        /// <summary>
        /// Конфигурация автомобильного номера - соответствующая структура SDK_CarPlates
        /// </summary>
        E_SDK_CONFIG_CARPLATE,
        /// <summary>
        /// Настройка информации о сетевой платформе - соответствующая структура SDK_LocalSdkNetPlatformConfig
        /// </summary>
        E_SDK_CONFIG_LOCALSDK_NET_PLATFORM = 110,
        /// <summary>
        /// GPS time correlation configuration - соответствующая структура SDK_GPSTimingConfig
        /// </summary>
        E_SDK_CONFIG_GPS_TIMING,
        /// <summary>
        /// Анализ видео (функционал smart DVR) - соответствующая структура SDK_ANALYSECONFIG
        /// </summary>
        E_SDK_CONFIG_VIDEO_ANALYZE,
        /// <summary>
        /// Система центра оповещений God Eye - соответствующая структура SDK_GodEyeConfig
        /// </summary>
        E_SDK_CONFIG_GODEYE_ALARM,
        /// <summary>
        /// Информация о состоянии NAT - соответствующая структура SDK_NatStatusInfo
        /// </summary>
        E_SDK_CONFIG_NAT_STATUS_INFO,
        /// <summary>
        /// Команда отладка (сохранить)
        /// </summary>
        E_SDK_CONFIG_BUGINFOSAVE,
        /// <summary>
        /// Настройки водяного знака - соответствующая структура SDK_WaterMarkConfigAll
        /// </summary>
        E_SDK_CONFIG_MEDIA_WATERMARK,
        /// <summary>
        /// Статические параметры кодировки - соответствующая структура SDK_EncodeStaticParamAll
        /// </summary>
        E_SDK_CONFIG_ENCODE_STATICPARAM,
        /// <summary>
        /// Строка отображения потери видео
        /// </summary>
        E_SDK_CONFIG_LOSS_SHOW_STR,
        /// <summary>
        /// Настройка дисплея управления каналами - соответствующая структура SDK_DigManagerShowStatus
        /// </summary>
        E_SDK_CONFIG_DIGMANAGER_SHOW,
        /// <summary>
        /// Возможность интеллектуального анализа - соответствующая структура SDK_ANALYZEABILITY
        /// </summary>
        E_SDK_CONFIG_ABILITY_ANALYZEABILITY = 120,
        /// <summary>
        /// Конфигурация приоритета вывода дисплея (HDMI/VGA)
        /// </summary>
        E_SDK_CONFIG_VIDEOOUT_PRIORITY,
        /// <summary>
        /// Функция NAT, настройка значения MTU - соответствующая структура SDK_NatConfig
        /// </summary>
        E_SDK_CONFIG_NAT,
        /// <summary>
        /// Интеллектуальная информация о данных подсчета CPC - соответствующая структура SDK_CPCDataAll
        /// </summary>
        E_SDK_CONFIG_CPCINFO,
        /// <summary>
        /// Тип устройства хранения видео - соответствующая структура SDK_RecordStorageType
        /// </summary>
        E_SDK_CONFIG_STORAGE_POSITION,
        /// <summary>
        /// Номер статуса транспортного средства - соответствующая структура SDK_CarStatusNum
        /// </summary>
        E_SDK_CONFIG_ABILITY_CARSTATUSNUM,
        /// <summary>
        /// VPN - соответствующая структура SDK_VPNConfig
        /// </summary>
        E_SDK_CFG_VPN,
        /// <summary>
        /// Разрешение видео VGA - соответствующая структура SDK_VGAresolution
        /// </summary>
        E_SDK_CFG_VIDEOOUT,
        /// <summary>
        /// Список поддерживаемых разрешений VGA - соответствующая структура SDK_VGAResolutionAbility
        /// </summary>
        E_SDK_CFG_ABILITY_VGARESOLUTION,
        /// <summary>
        /// Поиск устройства в локальной сети - соответствующая структура SDK_NetDevList
        /// </summary>
        E_SDK_CFG_NET_LOCALSEARCH,
        /// <summary>
        /// Конфигурация клиента (что бы это не значило) - соответствующая структура SDK_CONFIG_KAINENG_INFO
        /// </summary>
        E_SDK_CFG_NETPLAT_KAINENG = 130,
        /// <summary>
        /// Статические параметры DVR енкодера - соответствующая структура SDK_EncodeStaticParamV2
        /// </summary>
        E_SDK_CFG_ENCODE_STATICPARAM_V2,
        /// <summary>
        /// Набор возможностей статического кода - соответствующая структура SDK_EncStaticParamAbility
        /// </summary>
        E_SDK_ABILITY_ENC_STATICPARAM,
        /// <summary>
        /// Конфигурация платформы C7 - соответствующая структура SDK_C7PlatformConfig
        /// </summary>
        E_SDK_CFG_C7_PLATFORM,
        /// <summary>
        /// Проверка электронной почты - соответствующая структура SDK_NetEmailConfig
        /// </summary>
        E_SDK_CFG_MAIL_TEST,
        /// <summary>
        /// Сервис сетевой клавиатуры - соответствующая структура SDK_NetKeyboardConfig
        /// </summary>
        E_SDK_CFG_NET_KEYBOARD,
        /// <summary>
        /// Протокол сетевой клавиатуры - соответствующая структура SDK_NetKeyboardAbility
        /// </summary>
        E_SDK_ABILITY_NET_KEYBOARD,
        /// <summary>
        /// Конфигурация протокола 28181 - соответствующая структура SDK_ASB_NET_VSP_CONFIG
        /// </summary>
        E_SDK_CFG_SPVMN_PLATFORM,
        /// <summary>
        /// Услуга мобильной связи - соответствующая структура SDK_PMSConfig
        /// </summary>
        E_SDK_CFG_PMS,
        /// <summary>
        /// Информация об экранной подсказке - соответствующая структура SDK_OSDInfoConfigAll
        /// </summary>
        E_SDK_CFG_OSD_INFO,
        /// <summary>
        /// Конфигурация потребителя (что?) - соответствующая структура SDK_KaiCongAlarmConfig
        /// </summary>
        E_SDK_CFG_KAICONG = 140,
        /// <summary>
        /// Фактически поддерживаемый режим канала - соответствующая структура SDK_VideoChannelManage
        /// </summary>
        E_SDK_CFG_DIGITAL_REAL,
        /// <summary>
        /// Набор возможностей управления PTZ - соответствующая структура SDK_PTZControlAbility
        /// </summary>
        E_SDK_ABILITY_PTZCONTROL,
        /// <summary>
        /// Соответствующая структура SDK_XMHeartbeatConfig
        /// </summary>
        E_SDK_CFG_XMHEARTBEAT,
        /// <summary>
        /// Конфигурация платформы - соответствующая структура SDK_MonitorPlatformConfig
        /// </summary>
        E_SDK_CFG_MONITOR_PLATFORM,
        /// <summary>
        /// Расширенные параметры камеры - соответствующая структура SDK_CameraParamEx
        /// </summary>
        E_SDK_CFG_PARAM_EX,
        /// <summary>
        /// 安巨 (?) P2P - the corresponding structure SDK_NetPlatformCommonCfg 
        /// </summary>
        E_SDK_CFG_NETPLAT_ANJU_P2P,
        /// <summary>
        /// Информация о подключении GPS - соответствующая структура SDK_GPSStatusInfo
        /// </summary>
        E_SDK_GPS_STATUS,
        /// <summary>
        /// Информация о подключении Wi-Fi - соответствующая структура SDK_WifiStatusInfo
        /// </summary>
        E_SDK_WIFI_STATUS,
        /// <summary>
        /// Информация о 3G-соединении - соответствующая структура SDK_WirelessStatusInfo
        /// </summary>
        E_SDK_3G_STATUS,
        /// <summary>
        /// Active registration status - соответствующая структура SDK_DASStatusInfo
        /// </summary>
        E_SDK_DAS_STATUS = 150,
        /// <summary>
        /// Decoding strategy capability - соответствующая структура SDK_DecodeDeleyTimePrame
        /// </summary>
        E_SDK_ABILITY_DECODE_DELEY,
        /// <summary>
        /// Максимальная задержка декодирования - соответствующая структура SDK_DecodeParam
        /// </summary>
        E_SDK_CFG_DECODE_PARAM,
        /// <summary>
        /// SDK_VIDEOCOLOR_PARAM_CUSTOM
        /// </summary>
        E_SDK_CFG_VIDEOCOLOR_CUSTOM,
        /// <summary>
        /// Подпротокол onvif - соответствующая структура SDK_AbilityMask
        /// </summary>
        E_SDK_ABILITY_ONVIF_SUB_PROTOCOL,
        /// <summary>
        /// Экспортируйт конфигурации устройства по умолчанию (заводскую конфигурацию)
        /// </summary>
        E_SDK_CONFIG_EXPORT_V2,
        /// <summary>
        /// Модуль включения/выключения автомобиля - соответствующая структура SDK_CarBootTypeConfig
        /// </summary>
        E_SDK_CFG_CAR_BOOT_TYPE,
        /// <summary>
        /// Сетевое оповещение IPC - соответствующая структура SDK_IPCAlarmConfigAll
        /// </summary>
        E_SDK_CFG_IPC_ALARM,
        /// <summary>
        /// Конфигурация платформы TUTK IOTC - соответствующая структура SDK_NetPlatformCommonCfg
        /// </summary>
        E_SDK_CFG_NETPLAT_TUTK_IOTC,
        /// <summary>
        /// Baidu Cloud - соответствующая структура SDK_BaiduCloudCfg
        /// </summary>
        E_SDK_CFG_BAIDU_CLOUD,
        /// <summary>
        /// Подписки мобильного телефона - соответствующая структура SDK_PhoneInfoNum
        /// </summary>
        E_SDK_CFG_PMS_MSGNUM = 160,
        /// <summary>
        /// Управление видеорегистратором для изменения IP-адреса устройства - соответствующая структура SDK_IPSetCfg
        /// </summary>
        E_SDK_CFG_IPC_IP,
        /// <summary>
        /// Two-dimensional code lattice - соответствующая структура SDK_DimenCodeAll
        /// </summary>
        E_SDK_ABILITY_DIMEN_CODE,
        /// <summary>
        /// China Telecom mobile phone shop platform configuration - соответствующая структура SDK_MobileWatchCfg
        /// </summary>
        E_SDK_CFG_MOBILE_WATCH,
        /// <summary>
        /// Язык, используемый при использовании браузера - соответствующая структура SDK_BrowserLanguageType
        /// </summary>
        E_SDK_CFG_BROWSER_LANGUAGE,
        /// <summary>
        /// Конфигурация часового пояса - соответствующая структура SDK_TimeZone
        /// </summary>
        E_SDK_CFG_TIME_ZONE,
        /// <summary>
        /// Customer configuration - соответствующая структура SDK_MonitorPlatformConfig
        /// </summary>
        E_SDK_CFG_NETBJTHY,
        /// <summary>
        /// Максимальное время предварительной записи (1-30) - соответствующая структура SDK_AbilityMask
        /// </summary>
        E_SDK_ABILITY_MAX_PRE_RECORD,
        /// <summary>
        /// Конфигурация синхронизации времени цифрового канала - соответствующая структура SDK_TimeSynParam
        /// </summary>
        E_SDK_CFG_DIG_TIME_SYN,
        /// <summary>
        /// Three lines OSD
        /// </summary>
        E_SDK_CONFIG_OSDINFO_DOT,
        /// <summary>
        /// Конфигурация POS-машины - соответствующая структура SDK_NetPosConfigAll
        /// </summary>
        E_SDK_CFG_NET_POS = 170,
        /// <summary>
        /// Custom OEM client version information - соответствующая структура SDK_CustomizeOEMInfo
        /// </summary>
        E_SDK_CFG_CUSTOMIZE_OEMINFO,
        /// <summary>
        /// Конфигурация кодирования вторичного цифрового канала - соответствующая структура SDK_EncodeConfigAll_SIMPLIIFY
        /// </summary>
        E_SDK_CFG_DIGITAL_ENCODE,
        /// <summary>
        /// Возможность кодирования цифрового канала - соответствующая структура SDK_DigitDevInfo
        /// </summary>
        E_SDK_CFG_DIGITAL_ABILITY,
        /// <summary>а
        /// Номер внешнего канала, отображаемый конфигурацией кода IE - соответствующая структура SDK_DigitDevInfo
        /// </summary>
        E_SDK_CFG_ENCODECH_DISPLAY,
        /// <summary>
        /// Статус загрузки PTZ - соответствующая структура SDK_ResumePtzState
        /// </summary>
        E_SDK_CFG_RESUME_PTZ_STATE,
        /// <summary>
        /// Последний режим разделения экрана (используется для восстановления предыдущего режима разделения после перезапуска)
        /// </summary>
        E_SDK_CFG_LAST_SPLIT_STATE,
        /// <summary>
        /// Настройка времени включения и выключения устройства. 
        /// Скрыто на странице автоматического обслуживания, и для просмотра интерфейса необходимо использовать учетную запись суперпользователя
        /// </summary>
        E_SDK_CFG_SYSTEM_TIMING_WORK,
        /// <summary>
        /// конфигурация платформы мониторинга окружения - соответствующая структура SDK_NetPlatformCommonCfg
        /// </summary>
        E_SDK_CFG_GBEYESENV,
        /// <summary>
        /// Набор возможностей AHDL - соответствующая структура SDK_AHDEncodeLMask
        /// </summary>
        E_SDK_ABILITY_AHD_ENCODE_L,
        /// <summary>
        /// Сигнализация скорости - соответствующая структура SDK_SpeedAlarmConfigAll
        /// </summary>
        E_SDK_CFG_SPEEDALARM = 180,
        /// <summary>
        /// Пользовательская конфигурация - соответствующая структура SDK_CorrespondentOwnInfo
        /// </summary>
        E_SDK_CFG_CORRESPONDENT_INFO,
        /// <summary>
        /// Настройка информации OSD - соответствующая структура SDK_OSDInfo (только для аналоговых каналов)
        /// </summary>
        E_SDK_SET_OSDINFO,
        /// <summary>
        /// Наложение информации экранного меню (конфигурация не сохраняется) - соответствующая структура SDK_OSDInfoConfigAll
        /// </summary>
        E_SDK_SET_OSDINFO_V2,
        /// <summary>
        /// Поддержка записи вторичного потока - соответствующая структура SDK_AbilityMask
        /// </summary>
        E_SDK_ABILITY_SUPPORT_EXTSTREAM,
        /// <summary>
        /// Конфигурация вторичного потока - соответствующая структура SDK_RECORDCONFIG_ALL / SDK_RECORDCONFIG
        /// </summary>
        E_SDK_CFG_EXT_RECORD,
        /// <summary>
        /// Used to user customize download link - соответствующая структура SDK_AppDownloadLink
        /// </summary>
        E_SDK_CFG_APP_DOWN_LINK,
        /// <summary>
        /// Used to save the clear text data - соответствующая структура SDK_UserMap
        /// </summary>
        E_SDK_CFG_EX_USER_MAP,
        /// <summary>
        /// Данные последовательного порта активно загружаются на сервер UDP или TCP. 
        /// Сервер TCP может поддерживать двустороннюю связь
        /// </summary>
        E_SDK_CFG_TRANS_COMM_DATA,
        /// <summary>
        /// Экспорт языка
        /// </summary>
        E_SDK_EXPORT_LANGUAGE,
        /// <summary>
        /// Импорт языка
        /// </summary>
        E_SDK_IMPORT_LANGUAGE = 190,
        /// <summary>
        /// Удаление языка
        /// </summary>
        E_SDK_DELETE_LANGUAGE,
        /// <summary>
        /// Список файлов облачного обновления - соответствующая структура SDK_CloudUpgradeList
        /// </summary>
        E_SDK_CFG_UPGRADE_VERSION_LIST,
        /// <summary>
        /// GSENSOR оповещение
        /// </summary>
        E_SDK_CFG_GSENSORALARM,
        /// <summary>
        /// Запустить клиентский апплет - соответствующая структура SDK_NetUseProgram
        /// </summary>
        E_SDK_CFG_USE_PROGRAM,
        /// <summary>
        /// Тест FTP - соответствующая структура SDK_FtpServerConfig
        /// </summary>
        E_SDK_CFG_FTP_TEST,
        /// <summary>
        /// The status of the video light of consumer products - соответствующая структура SDK_FbExtraStateCtrl
        /// </summary>
        E_SDK_CFG_FbExtraStateCtrl,
        /// <summary>
        /// Использование мобильного телефона
        /// </summary>
        E_SDK_CFG_PHONE,
        /// <summary>
        /// Захват изображения с мобильного телефона
        /// </summary>
        [Obsolete("abandon")]
        E_SDK_PicInBuffer,
        /// <summary>
        /// Guard
        /// </summary>
        [Obsolete("abandon")]
        E_SDK_GUARD,
        /// <summary>
        /// Unguard 
        /// </summary>
        [Obsolete("abandon")]
        E_SDK_UNGUARD = 200,
        /// <summary>
        /// Начать обновление
        /// </summary>
        [Obsolete("устарело")]
        E_SDK_CFG_START_UPGRADE,
        /// <summary>
        /// Socket timing switch - use H264_DVR_GetDevConfig_Json to get configuration,
        /// configuration useH264_DVR_SetDevConfig_Json 
        /// (the format in configuration see the using command of smart socket .Doc)
        /// (two interface referred to as the Json interface, hereinafter referred to as)
        /// “Name”:"PowerSocket.AutoSwitch"
        /// </summary>
        E_SDK_CFG_AUTO_SWITCH,
        /// <summary>
        /// Control socket switch - Json interface “Name”:"OPPowerSocketGet"
        /// </summary>
        E_SDK_CFG_POWER_SOCKET_SET,
        /// <summary>
        /// Socket timing removal - Json interface “Name”:"PowerSocket.AutoArm"
        /// </summary>
        E_SDK_CFG_AUTO_ARM,
        /// <summary>
        /// Конфигурация режима Wi-Fi, используемая для переключения режима AP ведущего рекордера - соответствующая структура SDK_NetWifiMode
        /// </summary>
        E_SDK_CFG_WIFI_MODE,
        /// <summary>
        /// Передача информации о мобильном клиенте - интерфейс Json "Name": "PowerSocket.ClientInfo"
        /// </summary>
        E_SDK_CFG_CIENT_INFO,
        /// <summary>
        /// SDK_Authority - Json interface "Name":"PowerSocket.Authority"
        /// </summary>
        E_SDK_CFG_ATHORITY,
        /// <summary>
        /// SDK_Arm - Json interface "Name":"PowerSocket.Arm"
        /// </summary>
        E_SDK_CFG_ARM,
        /// <summary>
        /// Set the timing switch function of night light - Json interface "Name" : "PowerSocket.AutoLight"
        /// </summary>
        E_SDK_CFG_AUTOLIGHT,
        /// <summary>
        /// Enable and prohibit the dynamic response function of the night lights - Json interface "Name" : "PowerSocket.Light"
        /// </summary>
        E_SDK_CFG_LIGHT = 210,
        /// <summary>
        /// Статистика энергопотребления - Json interface "Name" : "PowerSocket.WorkRecord"
        /// </summary>
        E_SDK_CFG_WORKRECORD,
        /// <summary>
        /// Set the time order, when LAN connection, send proofreading time command - Json interface “Name”:"System.Time"
        /// </summary>
        E_SDK_CFG_SYSTEMTIME,
        /// <summary>
        /// функция управления интерфейсом usb - интерфейс Json "Name": "PowerSocket.Usb"
        /// </summary>
        E_SDK_CFG_USB,
        /// <summary>
        /// Платформа Beijing Hongtaiheng - соответствующая структура SDK_CONFIG_NET_BJHONGTAIHENG
        /// </summary>
        E_SDK_CFG_NETPLAT_BJHONGTAIHENG,
        /// <summary>
        /// Конфигурация, связанная с облачным хранилищем - соответствующая структура SDK_CloudRecordConfigAll
        /// </summary>
        E_SDK_CFG_CLOUD_STORAGE,
        /// <summary>
        /// Конфигурация PTZ, связанная с действиями в режиме ожидания - соответствующая структура SDK_PtzIdleStateAll
        /// </summary>
        E_SDK_CFG_IDLE_PTZ_STATE,
        /// <summary>
        /// Конфигурация функции защиты от запотевания - соответствующая структура SDK_CameraClearFogAll
        /// </summary>
        E_SDK_CFG_CAMERA_CLEAR_FOG,
        /// <summary>
        /// Corresponding json “Name”:"PowerSocket.WechatAccount"
        /// </summary>
        E_SDK_CFG_WECHATACCOUNT,
        /// <summary>
        /// Corresponding json “Name”:“PowerSocket.WechatRenew”
        /// </summary>
        E_SDK_CFG_WECHATRENEW,
        /// <summary>
        /// Corresponding json “Name”:"PowerSocket.WiFi"
        /// </summary>
        E_SDK_CFG_POWERSOCKET_WIFI = 220,
        /// <summary>
        /// Управление двигателем камеры - соответствующая структура SDK_CameraMotorCtrl
        /// </summary>
        E_SDK_CFG_CAMERA_MOTOR_CONTROL,
        /// <summary>
        /// Set to add the code into beep sound every 30 seconds - the corresponding structure SDK_EncodeAddBeep
        /// </summary>
        E_SDK_CFG_ENCODE_ADD_BEEP,
        /// <summary>
        /// datalink customer execution program enable configuration in the network service - the corresponding structure SDK_DataLinkConfig
        /// </summary>
        E_SDK_CFG_DATALINK,
        /// <summary>
        /// Конфигурация функции "рыбий глаз" - соответствующая структура SDK_FishEyeParam
        /// </summary>
        E_SDK_CFG_FISH_EYE_PARAM,
        /// <summary>
        /// Superimpose Xiongmai and other manufacturers’ LOGO on the video - соответствующая структура SDK_SetLogo
        /// </summary>
        E_SDK_OPERATION_SET_LOGO,
        /// <summary>
        /// Конфигурация функции Sparsh Customer Heartbeat - соответствующая структура SDK_SparshHeartbeat
        /// </summary>
        E_SDK_CFG_SPARSH_HEARTBEAT,
        /// <summary>
        /// Отправлять электронное письмо при неудачной попытке входа в систему - соответствующая структура SDK_VIDEOLOSSCONFIG
        /// </summary>
        E_SDK_CFG_LOGIN_FAILED,
        /// <summary>
        /// Конфигурация NAS-сервера для клиентов Anhui Chaoqing - соответствующая структура SDK_SPVMN_NAS_SERVER
        /// </summary>
        E_SDK_CFG_NETPLAT_SPVMN_NAS,
        /// <summary>
        /// DDNS key function test - соответствующая структура SDK_NetDDNSConfigALL
        /// </summary>
        E_SDK_CFG_DDNS_APPLY,
        /// <summary>
        /// Запрос новой версии обновления облака - соответствующая структура SDK_CloudUpgradeVersionRep
        /// </summary>
        E_SDK_OPERATION_NEW_UPGRADE_VERSION_REQ = 230,
        /// <summary>
        /// ipv6 - соответствующая структура SDK_IPAddressV6
        /// </summary>
        E_SDK_CFG_IPV6_ADDRESS,
        /// <summary>
        /// IP-адрес внешней сети DDNS
        /// </summary>
        E_SDK_CFG_DDNS_IPMSG,
        /// <summary>
        /// Конфигурация, связанная с онлайн-обновлением - соответствующая структура SDK_OnlineUpgradeCfg
        /// </summary>
        E_SDK_CFG_ONLINE_UPGRADE,
        /// <summary>
        /// Household products 433 alarm linkage configuration - the corresponding structure SDK_ConsSensorAlarmCfg
        /// </summary>
        E_SDK_CFG_CONS_SENSOR_ALARM,
        /// <summary>
        /// Режим разделения экрана - соответствующая структура SDK_SplitControl
        /// </summary>
        E_SDK_OPEARTION_SPLIT_CONTROL,
        /// <summary>
        /// Клиент netinfo_cctv добавляет данные последовательного порта в указанную конфигурацию сервера - соответствующая структура SDK_NetinfoNetTransComm
        /// </summary>
        E_SDK_CFG_Netinfo_TRANS_COMM,
        /// <summary>
        /// Is ready to record and capture image, now for the Japanese customers through the serial port to control the opening and closing video function
        /// </summary>
        E_SDK_CFG_RECORD_ENABLE,
        /// <summary>
        /// Конфигурация nas - соответствующая структура SDK_NAS_LIST
        /// </summary>
        E_SDK_CFG_NAS,
        /// <summary>
        /// Список цепочек устройств с сетевой клавиатурой
        /// </summary>
        E_SDK_CFG_NKB_DEVICE_LIST,
        /// <summary>
        /// Parking system port configuration SDK_PortService - соответствующая структура SDK_PortService
        /// </summary>
        E_SDK_CFG_PARKING_PORT = 240,
        /// <summary>
        /// SDK для платформы ICT Global Eye Platform_GbEyesCfg
        /// </summary>
        E_SDK_CFG_NET_GBEYES,
        /// <summary>
        /// MEGA EYES configuration - соответствующая структура SDK_DefaultResponse
        /// </summary>
        E_SDK_CFG_GLOBALEYE,
        /// <summary>
        /// Коррекция центра "рыбий глаз" SDK_Point
        /// </summary>
        E_SDK_OPERATION_FISHEYE_MODIFY_CENTER,
        /// <summary>
        /// Установка времени UTC - соответствующая структура SDK_SYSTEM_TIME
        /// </summary>
        E_SDK_OPERATION_UTC_TIME_SETTING = 244,
        /// <summary>
        /// Специальный номер порта tcp interbras - соответствующая структура SDK_IntelBrasSpecialInfo
        /// </summary>
        E_SDK_CFG_INTELBRAS_SPECIAL_INFO,
        /// <summary>
        /// Конфигурация протокола 28181 sip board ip - соответствующая структура SDK_SIP_NET_IP_CONFIG
        /// </summary>
        E_SDK_CFG_SPVMN_PLATFORM_SIP,
        /// <summary>
        /// Параметры линз "рыбий глаз" - соответствующая структура SDK_FishLensParam
        /// </summary>
        E_SDK_CFG_FISH_LENS_PARAM,
        /// <summary>
        /// Select the control mode of the analog channel PTZ control - соответствующая структура SDK_PTZControlModeAll
        /// </summary>
        E_SDK_CFG_PTZCTRLMODE,
        /// <summary>
        /// Конфигурация SmartH264+ - соответствующая структура SDK_SmartH264ParamAll
        /// </summary>
        E_SDK_CFG_ENCODE_SmartH264,
        /// <summary>
        /// Информация о WIFI - соответствующая структура SDK_WifiInfo
        /// </summary>
        E_SDK_CFG_WIFI_INFO,
        /// <summary>
        /// Протокол RTMP - соответствующая структура SDK_NetRTMPConfig
        /// </summary>
        E_SDK_CFG_NET_RTMP,
        /// <summary>
        /// Конфигурация графика захвата - соответствующая структура SDK_SnapConfigAll
        /// </summary>
        E_SDK_CFG_SNAP_SCHEDULE,
        /// <summary>
        /// Установка языка
        /// </summary>
        E_SDK_OPERATION_SET_LANGUAGE,
        /// <summary>
        /// Предустановленная конфигурация PTZ - соответствующая структура SDK_PtzPreset
        /// </summary>
        E_SDK_CFG_PTZPRESET,
        /// <summary>
        /// Rонфигурация обхода - соответствующая структура SDK_PtzTour
        /// </summary>
        E_SDK_CFG_PTZTOUR,
        /// <summary>
        /// Конфигурация, связанная с безопасностью (используется для сброса пароля) - соответствующая структура SDK_PasswordSafety
        /// </summary>
        E_SDK_CFG_PWD_SAFETY,
        /// <summary>
        /// 获取密码找回问题 - соответствующая структура SDK_QuestionDelivery
        /// </summary>
        E_SDK_ABILITY_QUESTION_DELIVERY,
        /// <summary>
        /// Информация о настроенной версии TUTK - соответствующая структура SDK_TutkVersion
        /// </summary>
        E_SDK_CFG_TUTK_VERSION,
        /// <summary>
        /// Конфигурация миниатюр
        /// </summary>
        E_SDK_CFG_BREVIARY,
        /// <summary>
        /// Конфигурация оповещений последовательного порта - соответствующая структура SDK_SerialPortAlarm
        /// </summary>
        E_SDK_CFG_SERIALPORT_ALARM,
        /// <summary>
        /// 支持串口报警设置才能设置学码 - соответствующая структура SDK_AMIRLearnCode
        /// </summary>
        E_SDK_OPEARTION_SET_LEARN_CODE,
        /// <summary>
        /// Индивидуальная конфигурация оповещения PIR - соответствующая структура SDK_PIRConfigAll
        /// </summary>
        E_SDK_CFG_PIR_ALARM,
        /// <summary>
        /// Модификация соглашения Yi Jia и Visca, установка и получение увеличения, фокусного расстояния и т. Д. - соответствующая структура SDK_CameraViscaControl
        /// </summary>
        E_SDK_OPEARTION_CAMERA_VISCA,
        /// <summary>
        /// 设置系统时间（想关掉时间同步的程序可以用这个命令，并禁用之前的时间设置命令）
        /// </summary>
        E_SDK_OPERATION_TIME_SETTING_NEW_WAY,
        /// <summary>
        /// 设置UTC时间（用于其他协议设置UTC时间）
        /// </summary>
        E_SDK_OPERATION_UTC_TIME_SETTING_NEW_WAY,
        /// <summary>
        /// Информация о статусе DDNS
        /// </summary>
        E_SDK_CFG_DDNSADDRINFO,
        /// <summary>
        /// Информация о настроенной версии Tianhong Xuying - соответствующая структура SDK_THXY_VersionInfo
        /// </summary>
        E_SDK_CFG_THXY_VERION_INFO,
        /// <summary>
        /// Обнаружение размытия изображения - соответствующая структура SDK_BlurCheckAlarmAll
        /// </summary>
        E_SDK_CFG_ALARM_BLUR_CHECK,
        /// <summary>
        /// Умное кодирование - соответствующая структура SDK_IntelEnCodeCfgAll
        /// </summary>
        E_SDK_CFG_INTEL_ENCODE,
        /// <summary>
        /// Белый список распознавания автомобильных номеров - соответствующая структура SDK_PlateDetectWhiteList
        /// </summary>
        E_SDK_CFG_PLATE_DETECT_WHITE_LIST,
        /// <summary>
        /// 车牌侦测抬杆 - соответствующая структура SDK_PlateDetectLiftBar
        /// </summary>
        E_SDK_OPERATION_PLATE_DETECT_LIFT,
        /// <summary>
        /// Оповещение обнаружения номерного знака - соответствующая структура SDK_PlateDetectAll
        /// </summary>
        E_SDK_CFG_ALARM_PLATE_DETECT,
        /// <summary>
        /// Оповещение обнаружения лица - соответствующая структура SDK_FaceDetectAll
        /// </summary>
        E_SDK_CFG_ALARM_FACE_DETECT,
        /// <summary>
        /// ip自适应网关功能使能配置 - соответствующая структура SDK_IPAdaptiveCfg
        /// </summary>
        E_SDK_CFG_NET_IPADAPTIVE,
        /// <summary>
        /// 客户定制获取系统信息 - соответствующая структура SDK_OemGetInfo
        /// </summary>
        E_SDK_CFG_OEM_GETINFO,
        /// <summary>
        /// 客户定制433报警配置 - соответствующая структура SDK_ConsumerAlarm433DevList
        /// </summary>
        E_SDK_CFG_433_ALARM_DEV,
        /// <summary>
        /// Проверка пароля ONVIF - соответствующая структура SDK_IpcOnvifPwdCheckout
        /// </summary>
        E_SDK_CFG_NET_ONVIF_PWD_CHECKOUT,
        /// <summary>
        /// 球机跟踪识别配置 - соответствующая структура SDK_BallCameraTrackDetectParamAll
        /// </summary>
        E_SDK_CFG_BALL_CAMERA_TRACK_DETECT,
        /// <summary>
        /// 夜晚情景特殊模式 - соответствующая структура SDK_CameraSpecialNightCtrl
        /// </summary>
        E_SDK_CFG_CAMERA_SPECIAL_NIGHT,
        /// <summary>
        /// 车牌识别白光灯控制 - соответствующая структура SDK_LPRLigthControl
        /// </summary>
        E_SDK_CFG_LPR_LIGHT_CONTROL,
        /// <summary>
        /// 车牌识别触发方式 - соответствующая структура SDK_LPRRecognizeTriggerMode
        /// </summary>
        E_SDK_CFG_LPR_RECOGNIZE_TRIGGERMODE,
        /// <summary>
        /// 临时车收费规则 - соответствующая структура SDK_LPRTempCarChargeRule
        /// </summary>
        E_SDK_CFG_LPR_TEMP_CAR_CHARGE_RULE,
        /// <summary>
        /// 强制开始识别车牌 - соответствующая структура SDK_LprForceTrigRecognize
        /// </summary>
        E_SDK_OPERATION_LPR_FORCE_RECOGNIZE,
        /// <summary>
        /// 车牌识别 LED显示屏配置 - соответствующая структура SDK_LprLedSet
        /// </summary>
        E_SDK_CFG_LPR_DISPLAY,
        /// <summary>
        /// 车牌收费系统黑白名单工作模式 - соответствующая структура SDK_LprBlackWhiteListModeAll
        /// </summary>
        E_SDK_CFG_LPR_BLACK_WHITE_LIST_WORK_MODE,
        /// <summary>
        /// 显示屏显示收费金额,空余车位 - соответствующая структура SDK_LprLedShow
        /// </summary>
        E_SDK_OPERATION_LPR_LED_SHOW,
        /// <summary>
        /// 车牌收费系统针对临时车收费自动抬杆配置 - соответствующая структура SDK_LprAutoContrlGate
        /// </summary>
        E_SDK_CFG_LPR_AUTO_CONTRL_GATE,
        /// <summary>
        /// Экспорт записей о въезде и выезде из зоны платных парковок
        /// </summary>
        E_SDK_LPR_ENTRY_EXIT_EXPORT,
        /// <summary>
        /// 车牌收费系统出入场配置 - соответствующая структура SDK_LprEntryExitSet
        /// </summary>
        E_SDK_CFG_LPR_ENTRY_EXIT,
        /// <summary>
        /// 车牌收费系统停车场信息 - соответствующая структура SDK_LprParkingLotInfo
        /// </summary>
        E_SDK_CFG_LPR_PARKING_LOT_INFO,
        /// <summary>
        /// 发送数据
        /// </summary>
        E_SDK_CFG_HARDWARE_ABILITY,
        /// <summary>
        /// 上海熠知二次开发获取上传路径 - соответствующая структура SDK_CustomURLCfg
        /// </summary>
        E_SDK_CFG_URL_LOAD,
        /// <summary>
        /// 车牌识别结果通过http协议推送配置 - соответствующая структура SDK_LprHttpCommunication
        /// </summary>
        E_SDK_CFG_LPR_HTTP_COMMUNICATION,
        /// <summary>
        /// Обнаружение PIR - соответствующая структура SDK_PIRDetectV2Config
        /// </summary>
        E_SDK_CFG_PIRDETECT,
        /// <summary>
        /// 杭州庄贤串口透传获取web 端的配置 - соответствующая структура SDK_SerialTransConfig
        /// </summary>
        E_SDK_CFG_SERIAL_TRANS,
        /// <summary>
        /// 西安知象定制白平衡 - соответствующая структура SDK_AWB_ATTR
        /// </summary>
        E_SDK_CFG_CAMERA_SET_AWB,
        /// <summary>
        /// Управление PTZ
        /// </summary>
        E_SDK_CFG_ControlPTZ,
        /// <summary>
        /// 设置合封模组sensor等级信息
        /// </summary>
        E_SDK_OPERATION_SET_SENSOR_ABILITY,
        /// <summary>
        /// 获取合封模组sensor等级信息
        /// </summary>
        E_SDK_OPERATION_GET_SENSOR_ABILITY,
        /// <summary>
        /// Переключить режим AP - соответствующая структура SDK_SWITCH_WIFI_MODE
        /// </summary>
        E_SDK_OPERATION_SWITCH_WIFI_MODE,
        /// <summary>
        /// Информация о версии распознавания автомобильных номеров - соответствующая структура SDK_LPR_VERSION
        /// </summary>
        E_SDK_DEVICE_INFO_LPR_VERSION
    }
}