using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoParking.Helper;
using AutoParking.Models;
using AutoParking.Properties;

namespace AutoParking.Forms
{
    public partial class ClientForm : Form
    {
        // подключение к базе
        private readonly AutoContext _db = new AutoContext();
        // байндинг для таблицы
        private readonly BindingSource _gridBindingSource = new BindingSource();

        public ClientForm()
        {
            InitializeComponent();
            // загрзузка аудиторий из базы
            _db.Clients.Load();
            // получение байндинга
            BindingList<Client> gridBindingList = _db.Clients.Local.ToBindingList();
            // связываем таблицу с байндингом
            _gridBindingSource.DataSource = gridBindingList;
            dgv.DataSource = _gridBindingSource;
            dgv.Columns[0].Width = dgv.Width - 50;
            bnClassrooms.BindingSource = _gridBindingSource;
            // выравнивание столбцов по содержимому
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void gridClassrooms_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Произошла ошибка при редактировании. Проверьте корректность введенных данных");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DbHelper.Save(_db);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
