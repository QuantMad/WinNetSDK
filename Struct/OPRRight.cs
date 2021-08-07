using WinNetSDK.Class;
using System.Runtime.InteropServices;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Структура, связанная с управлением учетными записями пользователей
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct OPR_RIGHT
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SDK_TYPE_LEN.NET_MAX_USER_LENGTH)]
        public string name;
    }
}
