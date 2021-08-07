namespace WinNetSDK.Enum
{
	/// <summary>
	/// Типы функций сигнализации
	/// </summary>
	public enum SDK_AlarmFucntionTypes
	{
		/// <summary>
		/// Динамическое обнаружение
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_MOTION_DETECT,
		/// <summary>
		/// Видео окклюзия
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_BLIND_DETECT,
		/// <summary>
		/// Потеря видео
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_LOSS_DETECT,
		/// <summary>
		/// Локальная сигнализация
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_LOCAL_ALARM,
		/// <summary>
		/// Сетевая сигнализация
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_NET_ALARM,
		/// <summary>
		/// Конфликт IP-адресов
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_IP_CONFLICT,
		/// <summary>
		/// 网络异常
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_NET_ABORT,
		/// <summary>
		/// Устройство хранения не существует
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_STORAGE_NOTEXIST,
		/// <summary>
		/// Недостаточная емкость хранилища
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_STORAGE_LOWSPACE,
		/// <summary>
		/// Не удалось получить доступ к запоминающему устройству
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_STORAGE_FAILURE,
		/// <summary>
		/// Видеоанализ
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_VIDEOANALYSE,
		/// <summary>
		/// 网络异常扩展
		/// </summary>
		SDK_ALARM_FUNCTION_TYPE_NET_ABORT_EXTEND,
		SDK_ALARM_FUNCTION_TYPE_NR
	}
}