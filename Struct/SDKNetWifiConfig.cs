using System;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
	/// <summary>
	/// Параметры Wi-Fi
	/// </summary>
	public struct SDK_NetWifiConfig
	{
		public byte bEnable;

		/// <summary>
		/// SSID Number
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public string sSSID;

		/// <summary>
		/// Канал
		/// </summary>
		public Int32 nChannel;

		/// <summary>
		/// Infra, Adhoc
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string sNetType;

		/// <summary>
		/// NONE, WEP, TKIP, AES
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string sEncrypType;

		/// <summary>
		/// OPEN, SHARED, WEPAUTO, WPAPSK, WPA2PSK, WPANONE, WPA, WPA2
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string sAuth;

		/// <summary>
		/// 0:Hex 1:ASCII
		/// </summary>
		public Int32 nKeyType;

		/// <summary>
		/// NET_IW_ENCODING_TOKEN_MAX = 128
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string sKeys;

		/// <summary>
		/// host ip
		/// </summary>
		public CONFIG_IPAddress HostIP;
		/// <summary>
		/// Маска сети
		/// </summary>
		public CONFIG_IPAddress Submask;
		/// <summary>
		/// Шлюз
		/// </summary>
		public CONFIG_IPAddress Gateway;
	}
}
