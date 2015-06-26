using System;
using System.Data.Entity;
using System.Windows.Forms;
using AutoParking.Forms;
using AutoParking.Models;

namespace AutoParking
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database.SetInitializer(new AutoInitializer());
            Application.Run(new LoginForm());
        }
    }
}
