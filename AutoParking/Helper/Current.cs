using AutoParking.Models;

namespace AutoParking.Helper
{
    /// <summary>
    /// Класс для хранения информации по текущему пользователю
    /// </summary>
    static class Current
    {
        public static User CurrentUser { get; set; }
    }
}
