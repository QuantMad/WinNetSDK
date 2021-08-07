namespace WinNetSDK.Enum
{
    /// <summary>
    /// Тип действия PTZ
    /// </summary>
    public enum PTZ_ControlType
    {
        /// <summary>
        /// Вверх
        /// </summary>
        TILT_UP = 0,
        /// <summary>
        /// Вниз
        /// </summary>
        TILT_DOWN,
        /// <summary>
        /// Влево
        /// </summary>
        PAN_LEFT,
        /// <summary>
        /// Вправо
        /// </summary>
        PAN_RIGHT,
        /// <summary>
        /// Влево и вверх
        /// </summary>
        PAN_LEFTTOP,
        /// <summary>
        /// Влево и вниз
        /// </summary>
        PAN_LEFTDOWN,
        /// <summary>
        /// Вправо и вверх
        /// </summary>
        PAN_RIGTHTOP,
        /// <summary>
        /// Вправо и вниз
        /// </summary>
        PAN_RIGTHDOWN,
        /// <summary>
        /// Увеличить масштаб
        /// </summary>
        ZOOM_OUT,
        /// <summary>
        /// Уменьшить масштаб
        /// </summary>
        ZOOM_IN,
        /// <summary>
        /// Сфокусироваться на отдалённых объектах
        /// </summary>
        FOCUS_FAR,
        /// <summary>
        /// Сфокусироваться на ближних объектах
        /// </summary>
        FOCUS_NEAR,
        /// <summary>
        /// Открыть диафрагму
        /// </summary>
        IRIS_OPEN,
        /// <summary>
        /// Закрыть диафрагму
        /// </summary>
        IRIS_CLOSE,

        /// <summary>
        /// Функция тревоги
        /// </summary>
        EXTPTZ_OPERATION_ALARM,
        /// <summary>
        /// Включить подсветку
        /// </summary>
        EXTPTZ_LAMP_ON,
        /// <summary>
        /// Отключить подсветку
        /// </summary>
        EXTPTZ_LAMP_OFF,
        EXTPTZ_POINT_SET_CONTROL,			//设置预置点 
        EXTPTZ_POINT_DEL_CONTROL,			//清除预置点 
        EXTPTZ_POINT_MOVE_CONTROL,			//转预置点
        /// <summary>
        /// Начать горизонтальное вращение
        /// </summary>
        EXTPTZ_STARTPANCRUISE,
        /// <summary>
        /// Остановить горизонтальное вращение
        /// </summary>
        EXTPTZ_STOPPANCRUISE,
        EXTPTZ_SETLEFTBORDER,			//设置左边界		
        EXTPTZ_SETRIGHTBORDER,			//设置右边界	
        /// <summary>
        /// Начать автоматическое сканирование
        /// </summary>
        EXTPTZ_STARTLINESCAN,
        /// <summary>
        /// Остановить автоматическое сканирование
        /// </summary>
        EXTPTZ_CLOSELINESCAN,
        /// <summary>
        /// Добавить заданную точку к круизной линии. p1-круизная линия, p2-значение заданной точки
        /// </summary>
        EXTPTZ_ADDTOLOOP,
        /// <summary>
        /// Удалить заданную точку из круизной линии. p1-круизная линия, p2-значение заданной точки
        /// </summary>
        EXTPTZ_DELFROMLOOP,
        /// <summary>
        /// Начать патрулирование
        /// </summary>
        EXTPTZ_POINT_LOOP_CONTROL,
        /// <summary>
        /// Остановить патрулирование
        /// </summary>
        EXTPTZ_POINT_STOP_LOOP_CONTROL,
        EXTPTZ_CLOSELOOP,
        /// <summary>
        /// Быстрое позиционирование
        /// </summary>
        EXTPTZ_FASTGOTO,
        /// <summary>
        /// Auxiliary switch, off is in the sub command. See SDK_PtzAuxStatus, param2 incoming specific values
        /// </summary>
        EXTPTZ_AUXIOPEN,
        /// <summary>
        /// Работа с меню купольной камеры, включая открытие, закрытие, подтверждение и т. Д.
        /// </summary>
        EXTPTZ_OPERATION_MENU,
        /// <summary>
        /// Переворот объектива
        /// </summary>
        EXTPTZ_REVERSECOMM,
        /// <summary>
        /// Сброс PTZ
        /// </summary>
        EXTPTZ_OPERATION_RESET,

        EXTPTZ_TOTAL
    }
}
