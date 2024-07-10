using insurance_tracking.Cards;
using insurance_tracking.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insurance_tracking.Forms
{
    public partial class FormCustomerEdit : Form
    {
        AppDbContext db;
        List<Customer> customers = new List<Customer>();
        Customer selectedCustomer; // Seçilen müşteriyi saklamak için field

        public FormCustomerEdit(AppDbContext dbContext)
        {
            InitializeComponent();
            pnlRightCustomers.AutoScroll = true;
            db = dbContext;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtIdentity.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer customer = new Customer
            {
                first_name = txtFirstName.Text,
                last_name = txtLastName.Text,
                phone_number = txtPhoneNumber.Text,
                identity_number = txtIdentity.Text,
                email = txtMailAddress.Text,
                birth_date = dtpBirthDate.Value
            };

            bool result = await AddCustomer(customer);

            if (result)
            {
                MessageBox.Show("Müşteri eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            else
            {
                MessageBox.Show("Müşteri eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> AddCustomer(Customer customer)
        {
            bool result = await db.AddCustomer(customer);
            if (result)
            {
                customers.Add(customer);
                UpdateCustomerList(customers);
            }
            return result;
        }

        private void Reset()
        {
            //customer = new Customer();
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            txtIdentity.Text = "";
            txtMailAddress.Text = "";
            dtpBirthDate.Value = DateTime.Today;
            btnUpdate.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            btnAdd.Enabled = true;
            txtIdentity.Enabled = true;
            selectedCustomer = null; // Seçili müşteriyi sıfırla
        }

        private async void FormCustomerEdit_Load(object sender, EventArgs e)
        {
            customers = await db.GetCustomerList();
            UpdateCustomerList(customers);

            btnUpdate.Enabled = false;
            btnDeleteCustomer.Enabled = false;
        }

        private void CustomerCard_PickCustomer(Customer customer)
        {
            selectedCustomer = customer; // Seçilen müşteriyi sakla
            FillCustomer(customer);
            btnUpdate.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            btnAdd.Enabled = false;
            txtIdentity.Enabled = false;
        }

        private void FillCustomer(Customer customer)
        {
            txtFirstName.Text = customer.first_name;
            txtLastName.Text = customer.last_name;
            txtMailAddress.Text = customer.email;
            txtIdentity.Text = customer.identity_number;
            txtPhoneNumber.Text = customer.phone_number;
            dtpBirthDate.Value = customer.birth_date;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Güncelleme işlemi için müşteri seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedCustomer.first_name = txtFirstName.Text;
            selectedCustomer.last_name = txtLastName.Text;
            selectedCustomer.email = txtMailAddress.Text;
            selectedCustomer.phone_number = txtPhoneNumber.Text;
            selectedCustomer.birth_date = dtpBirthDate.Value;

            bool result = await UpdateCustomer(selectedCustomer);
            if (result)
            {
                UpdateCustomerList(customers);
            }
        }

        private async Task<bool> UpdateCustomer(Customer customer)
        {
            bool result = await db.UpdateCustomer(customer);

            if (result)
            {
                MessageBox.Show("Güncelleme başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async Task<bool> DeleteCustomer(int customer_id)
        {
            bool result = await db.DeleteCustomer(customer_id);

            if (result)
            {
                MessageBox.Show("Silme başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customers.RemoveAll(c => c.customer_id == customer_id);
                UpdateCustomerList(customers);
                return true;
            }
            else
            {
                MessageBox.Show("Silme sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Silme işlemi için müşteri seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialog = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bool result = await DeleteCustomer(selectedCustomer.customer_id);

                if (result)
                {
                    Reset(); // UI'yi güncelle
                }
            }
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
            pnlRightCustomers.Controls.Clear();
            foreach (var customer in customerList)
            {
                CustomerCard customerCard = new CustomerCard(customer)
                {
                    Dock = DockStyle.Top,
                };
                customerCard.PickCustomer += CustomerCard_PickCustomer;
                pnlRightCustomers.Controls.Add(customerCard);
            }
        }
    }
}
