using insurance_tracking.Cards;
using insurance_tracking.Class;
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
    public partial class FormCustomerEdit : Form
    {
        AppDbContext db = new AppDbContext();
        Customer customer = new Customer();
        Customer selectedCustomer; // Seçilen müşteriyi saklamak için field
        public FormCustomerEdit()
        {
            InitializeComponent();
            pnlRightCustomers.AutoScroll = true;
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

            customer.first_name = txtFirstName.Text;
            customer.last_name = txtLastName.Text;
            customer.phone_number = txtPhoneNumber.Text;
            customer.identity_number = txtIdentity.Text;
            customer.email = txtMailAddress.Text;
            customer.birth_date = dtpBirthDate.Value;

            bool result = await AddCustomer(customer);

            if (result)
            {
                MessageBox.Show("Müşteri eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            else
                MessageBox.Show("Müşteri eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async Task<bool> AddCustomer(Customer customer)
        {
            bool result = await db.AddCustomer(customer);
            return result;
        }

        private void Reset()
        {
            // customer listesini yeniden al
            customer = new Customer();
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
            var customerList = await db.GetCustomerList();

            foreach (var customer in customerList)
            {
                CustomerCard customerCard = new CustomerCard(customer)
                {
                    Dock = DockStyle.Top,
                };
                customerCard.PickCustomer += CustomerCard_PickCustomer;
                pnlRightCustomers.Controls.Add(customerCard);
            }

            btnUpdate.Enabled = false;
            btnDeleteCustomer.Enabled = false;
        }

        private void CustomerCard_PickCustomer(Customer customer)
        {
            // burada customer id var
            selectedCustomer = customer; // Seçilen müşteriyi sakla
            FillCustomer(customer);
            btnUpdate.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            btnAdd.Enabled = false;
            txtIdentity.Enabled = false;
        }

        private void FillCustomer(Customer customer)
        {
            // burada customer id var
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

            // burada customer id var
            selectedCustomer.first_name = txtFirstName.Text;
            selectedCustomer.last_name = txtLastName.Text;
            selectedCustomer.email = txtMailAddress.Text;
            selectedCustomer.phone_number = txtPhoneNumber.Text; 
            selectedCustomer.birth_date = dtpBirthDate.Value;

            await UpdateCustomer(selectedCustomer);
        }

        private async Task<bool> UpdateCustomer(Customer customer)
        {
            bool updateCustomer = await db.UpdateCustomer(customer);

            if (updateCustomer)
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
            bool deleteCustomer = await db.DeleteCustomer(customer_id);

            if (deleteCustomer)
            {
                MessageBox.Show("Silme başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
