using WinNetSDK.Enum;
using WinNetSDK.Struct;
using System;
using System.Runtime.InteropServices;
using System.Text;
using SDK_HANDLE = System.Int32;

namespace WinNetSDK.Class
{
    public static class CppLibWrapper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lLoginID">Значение, возвращаемое из H264_DVR_Login</param>
        /// <param name="pchDVRIP">IP/ID устройства</param>
        /// <param name="nDVRPort">Порт управления устройством</param>
        /// <param name="dwUser">Данные пользователя</param>
        public delegate void fDisConnect(SDK_HANDLE lLoginID, string pchDVRIP, int nDVRPort, IntPtr dwUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lLoginID">Значение, возвращаемое из H264_DVR_Login</param>
        /// <param name="pAlarm">Callback data - H264_DVR_ACTIVEREG_INFO</param>
        /// <param name="dwBufLen">Callback data length</param>
        /// <param name="dwUser">User parameter</param>
        /// <param name="nType">Data type - ALARM_TYPE</param>
        /// <returns></returns>
        public delegate bool fMessCallBack(SDK_HANDLE lLoginID, IntPtr pAlarm, uint dwBufLen, IntPtr dwUser, Int32 nType);
        public delegate void fTransComCallBack(SDK_HANDLE lLoginID, int lTransComType, StringBuilder pBuffer, uint dwBufSize, uint dwUser);
        public delegate void fDownLoadPosCallBack(SDK_HANDLE lPlayHandle, int lTotalSize, int lDownLoadSize, int dwUser);
        public delegate void fPlayDrawCallBack(SDK_HANDLE lPlayHand, IntPtr hDc, uint nUser);
        public delegate void fLocalPlayFileCallBack(SDK_HANDLE lPlayHand, uint nUser);
        public delegate void InfoFramCallBack(SDK_HANDLE lPlayHand, uint nType, string pBuf, uint nSize, uint nUser);
        public delegate int fRealDataCallBack_V2(SDK_HANDLE lRealHandle, ref PACKET_INFO_EX pFrame, int dwUser);
        public delegate int fRealDataCallBack(SDK_HANDLE lRealHandle, int dwDataType, string strBuf, int lbufsize, int dwUser);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int OnFoundDevCB(SDK_UUID uuid, int state, IntPtr userData);

        public static SDK_Config g_config = new SDK_Config();

        public struct SDK_Config
        {
            public Int32 nSDKType;
        }

        public static int SDK_Init(SDK_Config config, fDisConnect cbDisConnect, IntPtr dwUser)
        {
            g_config = config;
            return H264_DVR_Init(cbDisConnect, dwUser); ;
        }

        /// <summary>
        /// Set the device message callback function, used to get the current status information of the device.
        /// Regardless of the calling sequence, the SDK does not callback by default. 
        /// This callback function must first call the alarm callback upload channel interface H264_DVR_SetupAlarmChan to be effective, and it needs to explain the current defined alarm.
        /// Is the callback device's current alarm message per second. 
        /// </summary>
        /// <param name="cbAlarmcallback">The message callback function can call back the status of the device. For example, the alarm status can be obtained through this callback; when set to 0, the callback is prohibited. </param>
        /// <param name="lUser">User info</param>
        [DllImport("NetSdk.dll")]
        public static extern void H264_DVR_SetDVRMessCallBack(fMessCallBack cbAlarmcallback, IntPtr lUser);

        /// <summary>
        /// Инициализация SDK, прежде чем любая из функций SDK has been called back
        /// </summary>
        /// <param name="cbDisConnect">Off line callback function, callback current off line devices, and not callback devices active switch off for calling SDK H264_DVR_Logout function, and forbid calling back when set as NULL</param>
        /// <param name="dwUser">Users data</param>
        /// <returns>TRUE refers to be successful, FALSE refers to be disabled</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_Init(fDisConnect cbDisConnect, IntPtr dwUser);

        /// <summary>
        /// Время ожидания по умолчанию - 5000 мс. Количество попыток - 3
        /// </summary>
        /// <param name="nWaitTime">Время ожидания (unit в милисекундах, значение по умолчанию - 5000ms)</param>
        /// <param name="nTryTimes">Количество попыток (Значение по умолчанию - 3 попытки)</param>
        /// <returns>Возвращает true в случае успеха</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_SetConnectTime(int nWaitTime, int nTryTimes);

        /// <summary>
        /// Освобождение занятых SDK ресурсов, before every SDK function has been called back.
        /// If return failed, please call H264_DVR_GetLastError function to get error code, and find reason of error by code.
        /// </summary>
        /// <returns>TRUE refers to success, FALSE refers to failure</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_Cleanup();

        /// <summary>
        /// Register user to device, when set user as reuse through authenticator system 
        /// (The default device user, such as admin, and reuse cannot be set),
        /// user can register device several times with this account.
        /// </summary>
        /// <param name="sDVRIP">Device IP address</param>
        /// <param name="wDVRPort">Device port</param>
        /// <param name="sUserName">User name</param>
        /// <param name="sPassword">User password</param>
        /// <param name="lpDeviceInfo">Device information, belong to output parameter</param>
        /// <param name="error">Return to login error code</param>
        /// <param name="socketstyle">Login style refers to SocketStyle (Default is TCPSOCKET, and could be set NULL)</param>
        /// <returns> Returned failure 0, return device ID successfully. 
        /// After login, users can operate device through the value (device handle) referring to related  devices.  
        /// Obtain specific error code by calling H264_DVR_GetLastError of port</returns>
        [DllImport("NetSdk.dll")]
        public static extern SDK_HANDLE H264_DVR_Login(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword,
                              ref H264_DVR_DEVICEINFO lpDeviceInfo, out int error, Int32 socketstyle);

        [DllImport("NetSdk.dll")]
        public static extern Int32 H264_DVR_LoginEx_V2(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, 
                            ref H264_DVR_DEVICEINFO lpDeviceInfo, int nType, out int error, SocketStyle socketstyle);

        /// <summary>
        /// Интерфейс облачной регистрации использует технологию P2P и не гарантирует постоянного успешного входа.
        /// В соответствии с результатом ошибки облачного входа, если возврат ошибки составляет -10005 (тайм-аут),
        /// используйте интерфейс H264_DVR_SetConnectTime для увеличения тайм-аута.
        /// После успешного входа в систему количество ссылок на предварительный просмотр облака ограничено.
        /// Если предварительный просмотр возвращает -11204, максимальное количество ссылок было достигнуто.
        /// </summary>
        /// <param name="sDVRID">ID (Серийный номер) регистратора</param>
        /// <param name="wDVRPort">Порт устройства</param>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sPassword">Пароль</param>
        /// <param name="lpDeviceInfo">out информация об устройстве</param>
        /// <param name="error">Код ошибки</param>
        /// <param name="strUserData">Обычно устанавливается в null</param>
        /// <returns> Больше 0 - успех, меньше или равно 0 - неудача</returns>
        [DllImport("NetSdk.dll")]
        public static extern Int32 H264_DVR_Login_Cloud(string sDVRID, ushort wDVRPort, string sUserName, string sPassword, 
                            ref H264_DVR_DEVICEINFO lpDeviceInfo, out int error, string strUserData);

        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_Check_Device_Exist_V2(ref IntPtr pStates, int nTimeout, OnFoundDevCB decCb, IntPtr userData);

        /// <summary>
        /// The returned value is the error code of device returned
        /// </summary>
        /// <returns>Return to error code of the final operation. Details refer to Error Code Enumeration</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_GetLastError();

        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_ClickKey(SDK_HANDLE lLoginID, ref SDK_NetKeyBoardData pKeyBoardData);

        /// <summary>
        /// Send network alarm information
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="pAlarmInfo">Network alarm parameters - SDK_NetAlarmInfo</param>
        /// <returns>Returns TRUE on success and FALSE on failure. The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_SendNetAlarmMsg(SDK_HANDLE lLoginID, ref SDK_NetAlarmInfo pAlarmInfo);

        /// <summary>
        /// Different acquisition functions correspond to different structures and command numbers.
        /// Specific commands in the configuration information structure H264_SDK_CONFIG_TYPE
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="dwCommand">The configuration type is specifically defined in the SDK_CONFIG_TYPE the data structure definition</param>
        /// <param name="nChannelNO">Configure the channel number, -1 means all channels</param>
        /// <param name="bufptr">Store buffers for output parameters. 
        /// According to different types, output different configuration structures. 
        /// For details, see the configuration structure the data structure definition</param>
        /// <param name="dwOutBufferSize">The size of the input buffer, in bytes</param>
        /// <param name="lpBytesReturned">The actual returned buffer size corresponds to the size of the configuration structure (in bytes)</param>
        /// <param name="waittime">Waiting time</param>
        /// <returns>Greater than 0 success, less than 0 failure (can be found based on the type of error).
        /// The specific error code can be obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_GetDevConfig(SDK_HANDLE lLoginID, uint dwCommand, int nChannelNO, IntPtr bufptr, uint dwOutBufferSize, out uint lpBytesReturned, int waittime);

        /// <summary>
        /// Different setup functions correspond to different structures and command numbers. Specific commands in the configuration information structure _SDK_CONFIG_TYPE
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="dwCommand">Configuration type, as defined in the SDK_CONFIG_TYPE in the data structure definition</param>
        /// <param name="nChannelNO">Configure the channel number, -1 means all channels</param>
        /// <param name="bufptr">Store buffers for input parameters, input different configuration structures according to different types.
        /// For details, see the configuration structures in the data structure definition</param>
        /// <param name="dwInBufferSize">The size of the input buffer (in bytes)</param>
        /// <param name="waittime">Waiting time</param>
        /// <returns>Greater than 0 success, less than 0 failure (can be found based on the type of error). 
        /// The specific error code can be obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_SetDevConfig(SDK_HANDLE lLoginID, uint dwCommand, int nChannelNO, IntPtr bufptr, uint dwInBufferSize, int waittime);

        /// <summary>
        /// Stop the PC video
        /// </summary>
        /// <param name="lRealHandle">Play handle（H264_DVR_RealPlay return value</param>
        /// <returns>Returns TRUE on success and FALSE on failure. 
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_StopLocalRecord(SDK_HANDLE lRealHandle);

        /// <summary>
        /// PC end video for preview
        /// </summary>
        /// <param name="lRealHandle">Play handle（H264_DVR_RealPlay return value</param>
        /// <param name="szSaveFileName">Save route</param>
        /// <param name="type">Recording type: (0: file name suffix is .h264; 2: file name suffix.avi), the default is 0;</param>
        /// <returns>Returns TRUE on success and FALSE on failure. The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_StartLocalRecord(SDK_HANDLE lRealHandle, string szSaveFileName, int type);

        /// <summary>
        /// Turn on the audio of the video channel
        /// </summary>
        /// <param name="lHandle">H264_DVR_RealPlay or H264_DVR_StartLocalPlay or H264_DVR_PlayBackByName or H264_DVR_PlayBackByTimeEx return value</param>
        /// <returns>Returns TRUE on success and FALSE on failure. 
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_OpenSound(SDK_HANDLE lHandle);

        /// <summary>
        /// Set playback video color information
        /// </summary>
        /// <param name="lHandle">H264_DVR_RealPlay or H264_DVR_StartLocalPlay or H264_DVR_PlayBackByName or H264_DVR_PlayBackByTimeEx return value</param>
        /// <param name="nRegionNum">Area (temporary: can be set to 0)</param>
        /// <param name="nBrightness">Яркость</param>
        /// <param name="nContrast">Контраст</param>
        /// <param name="nSaturation">Saturation</param>
        /// <param name="nHue">Chroma</param>
        /// <returns>Returns TRUE on success and FALSE on failure.
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_LocalSetColor(SDK_HANDLE lHandle, UInt32 nRegionNum, int nBrightness, int nContrast, int nSaturation, int nHue);

        /// <summary>
        /// Get playback video color information
        /// </summary>
        /// <param name="lHandle">H264_DVR_RealPlay or H264_DVR_StartLocalPlay or H264_DVR_PlayBackByName or H264_DVR_PlayBackByTimeEx return value</param>
        /// <param name="nRegionNum">Area (temporary: can be set to 0)</param>
        /// <param name="pBrightness">Яркость</param>
        /// <param name="pContrast">Контраст</param>
        /// <param name="pSaturation">Saturation</param>
        /// <param name="pHue">Saturation</param>
        /// <returns>Returns TRUE on success and FALSE on failure. 
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_LocalGetColor(SDK_HANDLE lHandle, UInt32 nRegionNum, out int pBrightness, out int pContrast, out int pSaturation, out int pHue);

        /// <summary>
        /// Support forced I frame
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="nChannel">Channel number</param>
        /// <param name="nStream">Type of code stream – 0 refers to main code stream, 1 refers to sub-code stream</param>
        /// <returns>TRUE refers to success, FALSE refers to failure. 
        /// Detailed error code can be obtained from H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_MakeKeyFrame(SDK_HANDLE lLoginID, int nChannel, int nStream);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lLoginID">Returned value of H264_DVR_RealPlay</param>
        /// <param name="dwUser">Used to stop corresponding window decoding play; 
        /// In adopting default value NULL, stop every windows decoding play</param>
        /// <returns>1 refers to success, 0 refers to failure</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_StopRealPlay(SDK_HANDLE lLoginID, uint dwUser);

        /// <summary>
        /// Turn off the audio of the video channel
        /// </summary>
        /// <param name="lHandle">H264_DVR_RealPlay or H264_DVR_StartLocalPlay or H264_DVR_PlayBackByName or H264_DVR_PlayBackByTimeEx return value</param>
        /// <returns>Returns TRUE on success and FALSE on failure.
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_CloseSound(SDK_HANDLE lHandle);

        /// <summary>
        /// Call this interface, according to the obtained device information when login, and then you can turn on any effective real-time monitoring in one channel, and obtain raw data by H264_DVR_SetRealDataCallBack of device callback (note: if playing can be completed by assigning value to hWnd in lpClientInfo, assignment can be completed, without the need for decoding broadcast to the callback data). Successfully return to real-time monitoring  ID, in order to monitor the following video channels
        /// </summary>
        /// <param name="lLoginID">Returned value of H264_DVR_Login</param>
        /// <param name="lpClientInfo">Play handle</param>
        /// <returns>
        /// Return failure less than or equal to 0, when less than 0, H264_DVR_GetLastError function can be used to acquire error type.
        /// If returned successfully, real-time monitor ID(real-time handle) will be taken as parameters of related function.
        /// Analysis of some error code:
        ///     (1)H264_DVR_SUB_CONNECT_ERROR = -11202: Failed to establish video sub-connection, device may not be online or in rebooting.
        ///         Handling method: login after receiving disconnected callback. 
        ///     (2)H264_DVR_SUB_CONNECT_SEND_ERROR = -11203: a.LAN access: Sub-connection communication failed, that is the sub-connection was established successfully, but the communication failed, and the device was disconnected after sub-connection was established successfully.
        ///         Handling method: the return value of (1) will appear when H264_DVR_RealPlay is called again.b.Active registeration access: Main connection  communication failed, the device was disconnected, and interior SDK has received disconnected callback.Handling method: Logout after receiving the disconnected callback. 
        ///     (3)H264_DVR_NOTVALID=-11206: Illegal error, main connection disconnected, the device has been disconnected, and the reboot succeed, but no disconnected callback has been received, and the previous login handle is still in use.How to deal with it: logout after receiving the wire break callback</returns>
        [DllImport("NetSdk.dll")]
        public static extern SDK_HANDLE H264_DVR_RealPlay(SDK_HANDLE lLoginID, ref H264_DVR_CLIENTINFO lpClientInfo);

        /// <summary>
        /// Register user to device, when set user as reuse through authenticator system (The default device user, such as admin, and reuse cannot be set), user can register device several times with this account
        /// </summary>
        /// <param name="sDVRIP">Device IP address</param>
        /// <param name="wDVRPort">Device port</param>
        /// <param name="sUserName">User name</param>
        /// <param name="sPassword">User password</param>
        /// <param name="lpDeviceInfo">Device information, belong to output parameter</param>
        /// <param name="error">Return to login error code</param>
        /// <param name="socketstyle">Login style refers to SocketStyle (Default is TCPSOCKET, and could be set NULL)</param>
        /// <returns> Returned failure 0, return device ID successfully. After login, users can operate device through the value (device handle) referring to related devices. Obtain specific error code by calling H264_DVR_GetLastError of port</returns>
        [DllImport("NetSdk.dll")]
        public static extern SDK_HANDLE H264_DVR_Login(StringBuilder sDVRIP, ushort wDVRPort, StringBuilder sUserName, StringBuilder sPassword,
                              out H264_DVR_DEVICEINFO lpDeviceInfo, out short error, Int32 socketstyle);
        /// <summary>
        /// Разлогиниться в устройстве
        /// </summary>
        /// <param name="lLoginID">Дескриптор логина</param>
        /// <returns>1 в случае успеха, 0 при неудаче</returns>
        [DllImport("NetSdk.dll")]
        public static extern Int32 H264_DVR_Logout(SDK_HANDLE lLoginID); // Выйти из устройства

        [DllImport("NetSdk.dll")]
        public static extern void DisConnectBackCallFunc(SDK_HANDLE lLoginID, IntPtr pchDVRIP, ushort nDVRPort, uint dwUser);

        /// <summary>
        /// Create a transparent serial channel
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="TransInfo">Serial port parameters, refer to TransComChannel</param>
        /// <param name="cbTransCom">Callback</param>
        /// <param name="dwUser">User data</param>
        /// <returns>Returns TRUE on success and FALSE on failure.
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_OpenTransComChannel(SDK_HANDLE lLoginID, ref TransComChannel TransInfo, fTransComCallBack cbTransCom, IntPtr dwUser);

        /// <summary>
        /// Close the transparent serial port channel
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="nType">See SERIAL_TYPE for details</param>
        /// <returns>Returns TRUE on success and FALSE on failure. 
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_CloseTransComChannel(SDK_HANDLE lLoginID, SERIAL_TYPE nType);

        /// <summary>
        /// Write data to the device through the serial port
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="nType">See SERIAL_TYPE for details</param>
        /// <param name="Buffer">Data buffer</param>
        /// <param name="nBufLen">The length of the data buffer</param>
        /// <returns>Returns TRUE on success and FALSE on failure. 
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_SerialWrite(SDK_HANDLE lLoginID, SERIAL_TYPE nType, string Buffer, int nBufLen);

        [DllImport("NetSdk.dll")]
        public static extern SDK_HANDLE H264_DVR_StartLocalVoiceCom(SDK_HANDLE lLoginID);

        /// <summary>
        /// Stop the intercom
        /// </summary>
        /// <param name="lVoiceHandle">Intercom handle</param>
        /// <returns>Returns TRUE on success and FALSE on failure. 
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_StopVoiceCom(long lVoiceHandle);

        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_GetDDNSInfo(ref SearchMode searchmode, out DDNS_INFO[] pDevicInfo, int maxDeviceNum, out int nretNum);

        /// <summary>
        /// Begin to subscribe to a device message, used to set whether the device message callback, the message obtained from the H264_DVR_SetDVRMessCallBack set callback
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <returns>1 means success, 0 means failure. 
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_SetupAlarmChan(SDK_HANDLE lLoginID);

        /// <summary>
        /// Stop listening for messages on a device
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <returns>1 indicates success, less than or equal to 0 indicates failure. 
        /// The specific error code is obtained by H264_DVR_GetLastError </returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_CloseAlarmChan(SDK_HANDLE lLoginID);

        // Воспроизвести локальные файлы
        /// <summary>
        /// Play the local .h264 video file
        /// </summary>
        /// <param name="pFileName">Play file name</param>
        /// <param name="hWnd">Play window handle</param>
        /// <param name="drawCallBack">Callback function (can not be set to NULL)</param>
        /// <param name="user">User-defined data</param>
        /// <returns>Failed to return 0, successfully returned to the playback ID (local playback handle), will be used as a parameter of the relevant function</returns>
        [DllImport("NetSdk.dll")]
        public static extern SDK_HANDLE H264_DVR_StartLocalPlay(string pFileName, IntPtr hWnd, fPlayDrawCallBack drawCallBack, uint user);

        // Остановить локальное воспроизведение
        /// <summary>
        /// Stop the PC video
        /// </summary>
        /// <param name="lPlayHandle">Play handle（H264_DVR_RealPlay return value)</param>
        /// <returns>Returns TRUE on success and FALSE on failure. 
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_StopLocalPlay(SDK_HANDLE lPlayHandle);

        //获取播放位置用于回放，和本地播放
        /// <summary>
        /// Get the playback progress of playback or local playback. The interface handle is valid when playback
        /// </summary>
        /// <param name="lPlayHandle">H264_DVR_StartLocalPlay or H264_DVR_PlayBackByName or H264_DVR_PlayBackByTimeEx return value</param>
        /// <returns>Play percentage</returns>
        [DllImport("NetSdk.dll")]
        public static extern float H264_DVR_GetPlayPos(SDK_HANDLE lPlayHandle);

        //设置播放位置（百分比）用于回放，和本地播放
        /// <summary>
        /// Sets the playback progress of playback or local playback. 
        /// This interface is valid only when transmitting the window handle during playback
        /// </summary>
        /// <param name="lPlayHandle">H264_DVR_StartLocalPlay or H264_DVR_PlayBackByName or H264_DVR_PlayBackByTimeEx return value</param>
        /// <param name="fRelativPos">Play percentage</param>
        /// <returns>Returns TRUE on success and FALSE on failure.
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_SetPlayPos(SDK_HANDLE lPlayHandle, float fRelativPos);

        // Управление воспроизведением (воспроизведение, остановка, возобновление, быстрая перемотка вперед, медленное воспроизведение)
        /// <summary>
        /// Play control (play, stop, resume, fast send, slow release)
        /// </summary>
        /// <param name="lPlayHandle">H264_DVR_StartLocalPlay return value</param>
        /// <param name="action">See the reference：SDK_LoalPlayAction</param>
        /// <param name="lCtrlValue">Quick release (1, 2, 3, 4 levels), and slow playback (1, 2, 3, 4 levels)</param>
        /// <returns>Returns TRUE on success and FALSE on failure.
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_LocalPlayCtrl(SDK_HANDLE lPlayHandle, SDK_LoalPlayAction action, uint lCtrlValue);

        //设置播放结束回调
        /// <summary>
        /// The end of the local file playback callback
        /// </summary>
        /// <param name="lPlayHandle">H264_DVR_StartLocalPlay return value</param>
        /// <param name="callBack">End callback</param>
        /// <param name="user">User-defined data</param>
        /// <returns>Returns TRUE on success and FALSE on failure.
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_SetFileEndCallBack(SDK_HANDLE lPlayHandle, fLocalPlayFileCallBack callBack, IntPtr user);

        //设置信息帧回调
        /// <summary>
        /// Set information frame callbacks
        /// </summary>
        /// <param name="lPlayHandle">H264_DVR_RealPlay or H264_DVR_StartLocalPlay or H264_DVR_PlayBackByName or H264_DVR_PlayBackByTimeEx return value</param>
        /// <param name="callback">Callback</param>
        /// <param name="user">User-defined data</param>
        /// <returns>Returns TRUE on success and FALSE on failure.
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_SetInfoFrameCallBack(SDK_HANDLE lPlayHandle, InfoFramCallBack callback, uint user);

        //录像查询
        //lLoginID		Дескриптор сессии
        //lpFindInfo	查询条件
        //lpFileData	查找到的录像数据，外部开内存
        //lMaxCount		Максимальное количество записей
        //findcount		Количество найденных видео
        //waittime		Тайм-аут запроса
        /// <summary>
        /// Before playback, you should call the interface to search video record on ahead,
        /// when finded video record information according to the period of inputing is larger than the defined buffer size,
        /// it only return video record buffer can stored, and further search can be done according to needs
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="lpFindInfo">Find information -- H264_DVR_FINDINFO</param>
        /// <param name="ptr">Find result-- H264_DVR_FILE_DATA</param>
        /// <param name="lMaxCount">Maximum video number for searching</param>
        /// <param name="findcount">Video number of searching</param>
        /// <param name="waittime">Wait time</param>
        /// <returns>1 refers to success, 0 refers to failure. 
        /// Detailed error code can be obtained from H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_FindFile(SDK_HANDLE lLoginID, ref H264_DVR_FINDINFO lpFindInfo, IntPtr ptr, int lMaxCount, out int findcount, int waittime);

        /// <summary>
        /// Download the video file according to the file and download the file information through the query.
        /// According to the above query records, you can save the video to the specified file.
        /// The download progress callback is similar to the playback progress
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="sPlayBackFile">Downloaded video information - H264_DVR_FILE_DATA</param>
        /// <param name="sSavedFileName">Saved file path</param>
        /// <param name="cbDownLoadPos">Download progress callback (can be empty, download progress via H264_DVR_GetDownloadPos)</param>
        /// <param name="dwDataUser">Callback function parameters</param>
        /// <param name="fDownLoadDataCallBack">Data callback</param>
        /// <returns>Non-zero indicates success, 0 indicates failure. 
        /// The specific error code can be obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_GetFileByName(SDK_HANDLE lLoginID, ref H264_DVR_FILE_DATA sPlayBackFile, string sSavedFileName,
                                            fDownLoadPosCallBack cbDownLoadPos, int dwDataUser, fRealDataCallBack fDownLoadDataCallBack);

        /// <summary>
        /// Downloads video files by time and downloads them by querying the file information
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="lpFindInfo">Video search conditions - H264_DVR_FINDINFO</param>
        /// <param name="sSavedFileDIR">Video file save path</param>
        /// <param name="bMerge">Does the file merge</param>
        /// <param name="cbDownLoadPos">Download progress callback</param>
        /// <param name="dwDataUser">Callback function parameters</param>
        /// <param name="fDownLoadDataCallBack">Data callback</param>
        /// <returns>Non-zero indicates success, 0 indicates failure. 
        /// The specific error code can be obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_GetFileByTime(SDK_HANDLE lLoginID, ref H264_DVR_FINDINFO lpFindInfo, string sSavedFileDIR, bool bMerge,
                                            fDownLoadPosCallBack cbDownLoadPos, int dwDataUser, fRealDataCallBack fDownLoadDataCallBack);
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_PlayBackByName_V2(SDK_HANDLE lLoginID, ref H264_DVR_FILE_DATA sPlayBackFile, fDownLoadPosCallBack cbDownLoadPos, fRealDataCallBack_V2 fDownLoadDataCallBack, int dwDataUser);
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_PlayBackByTimeEx(SDK_HANDLE lLoginID, ref H264_DVR_FINDINFO lpFindInfo, fRealDataCallBack fDownLoadDataCallBack, int dwDataUser,
                                            fDownLoadPosCallBack cbDownLoadPos, int dwPosUser);

        /// <summary>
        /// Playback control is only valid for smart playback positioning
        /// </summary>
        /// <param name="lPlayHandle">Login handle</param>
        /// <param name="lControlCode">Control commands, see enum SDK_PlayBackAction</param>
        /// <param name="lCtrlValue">Control value</param>
        /// <returns>true for success, false for failure.
        /// The specific error code can be obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_PlayBackControl(SDK_HANDLE lPlayHandle, int lControlCode, int lCtrlValue);

        /// <summary>
        /// According to need, you can wait for the files to be downloaded and closed, or you can download them to stop downloading
        /// </summary>
        /// <param name="lFileHandle">Download file handle</param>
        /// <returns>true for success, false for failure.
        /// The specific error code can be obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_StopGetFile(SDK_HANDLE lFileHandle);

        /// <summary>
        /// Enter the playback ID returned by the previous interface.
        /// Call this interface to stop the control
        /// </summary>
        /// <param name="lPlayHandle">Playback handle</param>
        /// <returns>true for success, false for failure.
        /// The specific error code can be obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_StopPlayBack(SDK_HANDLE lPlayHandle);

        /// <summary>
        /// Obtaining the current position of the downloaded video can be used for an interface that does not need to display download progress in real time,
        /// similar to the function of downloading a callback function. 
        /// It is not intended to calculate progress through callbacks.
        /// It can be called periodically to obtain the current progress
        /// </summary>
        /// <param name="lFileHandle">Download handle</param>
        /// <returns>Greater than or equal to 0 for download progress, less than 0 for failure.
        /// The specific error code can be obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_GetDownloadPos(SDK_HANDLE lFileHandle);

        [DllImport("NetSdk.dll")]
        // Захватит локального изображения
        // Предварительный просмотр, воспроизведение, локальное воспроизведение функция
        public static extern bool H264_DVR_LocalCatchPic(SDK_HANDLE lHandle, string strPath);

        /// <summary>
        /// Controls the PTZ, but it must be used with the current channel open
        /// </summary>
        /// <param name="lLoginID">Login handle</param>
        /// <param name="nChannelNo">Controlled device channel number</param>
        /// <param name="lPTZCommand">Control type :PTZ_ControlType</param>
        /// <param name="bStop">Is it stop</param>
        /// <param name="lSpeed">Speed, default 4</param>
        /// <returns>Return TRUE on success and FALSE on failure.
        /// The specific error code is obtained by H264_DVR_GetLastError</returns>
        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_PTZControl(SDK_HANDLE lLoginID, int nChannelNo, int lPTZCommand, bool bStop, long lSpeed);

        [DllImport("NetSdk.dll")]
        public static extern int H264_DVR_SearchDevice(IntPtr ptr, int nBufLen, ref int nRetLength, int nSearchTime);

        [DllImport("NetSdk.dll")]
        public static extern bool H264_DVR_DelRealDataCallBack_V2(long lRealHandle, fRealDataCallBack_V2 cbRealData, long dwUser);

        public static int ToInt(string text, int nDef)
        {
            try
            {
                return int.Parse(text);
            }
            catch (Exception)
            {
                return nDef;
            }
        }
        public static int ToInt(string text)
        {
            return ToInt(text, 0);
        }
    }
}