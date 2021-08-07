using System;

namespace WinNetSDK.Struct
{
	/// <summary>
	/// Конфигурация сетевой камеры
	/// </summary>
	public struct SDK_CameraParam
	{
		/// <summary>
		/// Баланс белого
		/// </summary>
		public uint whiteBalance;
		/// <summary>
		/// Дневной и ночной режим, значения - цветной, автоматическое переключение и черно-белый.
		/// </summary>
		public uint dayNightColor;
		/// <summary>
		/// Опорное значение
		/// </summary>
		public Int32 elecLevel;
		/// <summary>
		/// Режим автоматической диафрагмы
		/// </summary>
		public uint apertureMode;
		/// <summary>
		/// Режим компенсации фоновой подсветки
		/// </summary>
		public uint BLCMode;
		/// <summary>
		/// Конфигурация экспозиции
		/// </summary>
		public SDK_ExposureCfg exposureConfig;
		/// <summary>
		/// Конфигурация усиления
		/// </summary>
		public SDK_GainCfg gainConfig;

		/// <summary>
		/// Переворот картинки
		/// </summary>
		public uint PictureFlip;
		/// <summary>
		/// Отзеркаливание картинки
		/// </summary>
		public uint PictureMirror;
		/// <summary>
		/// Функция защиты от вспышки люминесцентной лампы
		/// </summary>
		public uint RejectFlicker;
		/// <summary>
		/// Электронная функция медленного затвора
		/// </summary>
		public uint EsShutter;

		/// <summary>
		/// Переключатель IR-CUT:
		/// 0 - переключатель синхронизации инфракрасной лампы,
		/// 1 - автоматический переключатель
		/// </summary>
		public Int32 ircut_mode;

		/// <summary>
		/// Порог перехода в дневной/ночной режим
		/// </summary>
		public Int32 dnc_thr;
		/// <summary>
		/// Конфигурация чувствительности AE
		/// </summary>
		public Int32 ae_sensitivity;
		/// <summary>
		/// Уровень дневного шумоподавления (0-5, где 0 не фильтруется, а 5 - максимально фидбтруется)
		/// </summary>
		public Int32 Day_nfLevel;
		/// <summary>
		/// Уровень ночного шумоподавления (0-5, где 0 не фильтруется, а 5 - максимально фидбтруется)
		/// </summary>
		public Int32 Night_nfLevel;
		/// <summary>
		/// ircut Normal order = 0,
		/// Reverse order = 1
		/// </summary>
		public Int32 Ircut_swap;
	}
}