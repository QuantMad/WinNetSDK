namespace WinNetSDK.Class
{
    public static class SDK_TYPE_LEN
    {
        /// <summary>
        /// Максимальная длина пароля
        /// </summary>
        public const int NET_NAME_PASSWORD_LEN = 64;
        /// <summary>
        /// Максимальное количество пользователей
        /// </summary>
        public const int NET_MAX_USER_NUM = 60;
        /// <summary>
        /// Максимальное количество разрешений
        /// </summary>
        public const int NET_MAX_RIGTH_NUM = 200;
        /// <summary>
        /// Максимальное количество групп
        /// </summary>
        public const int NET_MAX_GROUP_NUM = 50;
        /// <summary>
        /// Максимальная длина имени пользователя
        /// </summary>
        public const int NET_MAX_USER_LENGTH = 32;
        /// <summary>
        /// Максимальное количество разделов на диске
        /// </summary>
        public const int SDK_MAX_DRIVER_PER_DISK = 4;
        /// <summary>
        /// Максимальное количество жёстких дисков
        /// </summary>
        public const int SDK_MAX_DISK_PER_MACHINE = 8;
        /// <summary>
        /// Максимальное количество каналов
        /// </summary>
        public const int NET_MAX_CHANNUM = 64;
    }
}