using System;
using System.Linq;
using System.Windows.Forms;
using AutoParking.Helper;
using AutoParking.Models;

namespace AutoParking.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // проверка прав пользователя
            var user = GetUser(txtLogin.Text, txtPassword.Text);
            if (user != null)
            {
                Current.CurrentUser = user;
                Visible = false;
                var mainForm = new MainForm(this);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль");
            }
        }

        /// <summary>
        /// Поиск пользователя в базе
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Пользователь</returns>
        private User GetUser(string login, string password)
        {
            using (var db = new AutoContext())
            {
                return db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            }
        }
    }
}
