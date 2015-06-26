using System.Windows.Forms;

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
        }
    }
}
