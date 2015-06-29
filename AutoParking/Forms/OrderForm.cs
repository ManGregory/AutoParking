using System.Windows.Forms;
using AutoParking.Models;

namespace AutoParking.Forms
{
    public partial class OrderForm : Form
    {
        private Order _order;

        public OrderForm()
        {
            InitializeComponent();
            edFactDate.Format = edFromDate.Format = edToDate.Format = DateTimePickerFormat.Custom;           
            edFactDate.CustomFormat = edFromDate.CustomFormat = edToDate.CustomFormat = "dd.MM.yyyy HH:mm";
        }

        public OrderForm(Order order) : this()
        {
            _order = order;
        }
    }
}
