using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
	public struct PACKET_INFO_EX
	{
		/// <summary>
		/// Тип пакета см. MEDIA_PACK_TYPE
		/// </summary>
		public int nPacketType;
		/// <summary>
		/// Cache address
		/// </summary>
		public string pPacketBuffer;
		/// <summary>
		/// Размер пакета
		/// </summary>
		public uint dwPacketSize;

		// Абсолютная шкала времени
		/// <summary>
		/// Шкала времени: год	
		/// </summary>
		public int nYear;
		/// <summary>
		/// Шкала времени: месяц
		/// </summary>
		public int nMonth;
		/// <summary>
		/// Шкала времени: день
		/// </summary>
		public int nDay;
		/// <summary>
		/// Шкала времени: час
		/// </summary>
		public int nHour;
		/// <summary>
		/// Шкала времени: минута
		/// </summary>
		public int nMinute;
		/// <summary>
		/// Шкала времени: секунда
		/// </summary>
		public int nSecond;
		/// <summary>
		/// Младший бит относительной шкалы времени, в миллисекундах
		/// </summary>
		public uint dwTimeStamp;
		/// <summary>
		/// Старший бит относительной шкалы времени, в миллисекундах
		/// </summary>
		public uint dwTimeStampHigh;
		/// <summary>
		/// Номер кадра
		/// </summary>
		public uint dwFrameNum;
		/// <summary>
		/// Частота кадров
		/// </summary>
		public uint dwFrameRate;
		/// <summary>
		/// Ширина изображения
		/// </summary>
		public ushort uWidth;
		/// <summary>
		/// Высота изображения
		/// </summary>
		public ushort uHeight;

		/// <summary>
		/// retain
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public ushort[] Reserved;
	}
}
