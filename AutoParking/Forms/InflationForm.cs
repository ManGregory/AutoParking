using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Windows.Forms;
using AutoParking.Helper;
using AutoParking.Models;

namespace AutoParking.Forms
{
    public partial class InflationForm : Form
    {
        // подключение к базе
        private readonly AutoContext _db = new AutoContext();
        // байндинг для таблицы
        private readonly BindingSource _gridBindingSource = new BindingSource();

        public InflationForm()
        {
            InitializeComponent();
            // загрзузка аудиторий из базы
            _db.Inflations.Load();
            // получение байндинга
            BindingList<Inflation> gridBindingList = _db.Inflations.Local.ToBindingList();
            // связываем таблицу с байндингом
            _gridBindingSource.DataSource = gridBindingList;
            dgv.DataSource = _gridBindingSource;
            dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
            bnClassrooms.BindingSource = _gridBindingSource;
            // выравнивание столбцов по содержимому
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
