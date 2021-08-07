using WinNetSDK.Enum;

namespace WinNetSDK.Struct
{
    /// <summary>
    /// Transparent window
    /// </summary>
    public struct TransComChannel
    {
        public SERIAL_TYPE TransComType;
        public ushort baudrate;
        public ushort databits;
        public ushort stopbits;
        public ushort parity;
    }
}