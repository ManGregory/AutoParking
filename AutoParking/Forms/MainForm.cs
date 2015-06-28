using System.Windows.Forms;
using AutoParking.Helper;

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
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var parkingform = new ParkingForm())
            {
                parkingform.ShowDialog();
            }
        }

        private void miClients_Click(object sender, System.EventArgs e)
        {
            using (var clientsForm = new ClientForm())
            {
                clientsForm.ShowDialog();
            }
        }
    }
}
