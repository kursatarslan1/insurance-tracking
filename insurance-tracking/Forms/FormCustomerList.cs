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
        AppDbContext db;
        List<Customer> customers = new List<Customer>();
        public FormCustomerList(AppDbContext dbContext)
        {
            InitializeComponent();
            db = dbContext;
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

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBox.Text.ToLower();
            var filteredCustomers = customers.Where(c =>
                c.first_name.ToLower().Contains(searchText) ||
                c.last_name.ToLower().Contains(searchText) ||
                c.phone_number.ToLower().Contains(searchText) ||
                c.email.ToLower().Contains(searchText) ||
                c.identity_number.ToLower().Contains(searchText) ||
                c.birth_date.ToString("yyyy-MM-dd").ToLower().Contains(searchText)).ToList();

            UpdateCustomerList(filteredCustomers);
        }

        private void UpdateCustomerList(List<Customer> customerList)
        {
            dgvCustomerList.Rows.Clear();
            foreach (Customer customer in customerList)
            {
                dgvCustomerList.Rows.Add(customer.first_name, customer.last_name, customer.phone_number, customer.email, customer.identity_number, customer.birth_date);
            }
        }
    }
}
