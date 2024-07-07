using insurance_tracking.Class;
using insurance_tracking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insurance_tracking.Forms
{
    public partial class FormCustomerList : Form
    {
        AppDbContext db = new AppDbContext();
        List<Customer> customers = new List<Customer>();
        public FormCustomerList()
        {
            InitializeComponent();
            dgvCustomerList.Columns["CustomerName"].DefaultCellStyle.Font = new Font("Calibri", 14);
            dgvCustomerList.Columns["CustomerLastName"].DefaultCellStyle.Font = new Font("Calibri", 14);
            // ayarla
        }

        private async void FormCustomerList_Load(object sender, EventArgs e)
        {
            customers = await db.GetCustomerList();
            foreach (Customer customer in customers)
            {
                dgvCustomerList.Rows.Add(customer.first_name, customer.last_name, customer.phone_number, customer.email, customer.identity_number, customer.birth_date);
            }

            lblCustomerCount.Text = "Müşteri Sayısı: " + customers.Count.ToString();
        }
    }
}
