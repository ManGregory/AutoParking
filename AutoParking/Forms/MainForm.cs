using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using AutoParking.Helper;
using AutoParking.Models;

namespace AutoParking.Forms
{
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            Closed += (o, e) => _loginForm.Close();
            Text += string.Format(", {0}", Current.CurrentUser.Name);
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new AutoContext())
            {
                db.Orders.Load();
                dgwOrders.DataSource = db.Orders.Local.ToBindingList();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var parkingform = new ParkingForm())
            {
                parkingform.ShowDialog(this);
            }
        }

        private void miClients_Click(object sender, System.EventArgs e)
        {
            using (var clientsForm = new ClientForm())
            {
                clientsForm.ShowDialog(this);
            }
        }

        private void miInflations_Click(object sender, System.EventArgs e)
        {
            using (var inflationForm = new InflationForm())
            {
                inflationForm.ShowDialog(this);
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            using (var orderForm = new OrderForm())
            {
                orderForm.ShowDialog(this);
            }
        }
    }
}
