using insurance_tracking.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace insurance_tracking.Forms
{
    public partial class FormInsuranceTrack : Form
    {
        AppDbContext db = new AppDbContext();
        List<Insure> insures = new List<Insure>();
        Customer customer = new Customer();
        public FormInsuranceTrack()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private async void FormInsuranceTrack_Load(object sender, EventArgs e)
        {
            insures = await db.GetInsureList();
            LoadDataGrid(insures);
        }

        private void LoadDataGrid(List<Insure> insures)
        {
            dgvCustomerList.Rows.Clear();
            if (insures != null)
            {
                foreach (Insure insure in insures)
                {
                    dgvCustomerList.Rows.Add(insure.insurance_type, insure.address, insure.document_no, insure.serial_no, insure.created_at, insure.end_date, insure.insure_amount, insure.is_active, insure.issue_date, insure.plate, insure.referance_code, insure.uavt_code, insure.customer_id);
                }
                lblCustomerCount.Text = "Poliçe Sayısı: " + insures.Count.ToString();
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            FilterInsures();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            FilterInsures();
        }

        private void FilterInsures()
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            var filteredInsures = insures.Where(insure => insure.issue_date >= startDate && insure.issue_date <= endDate).ToList();

            LoadDataGrid(filteredInsures);
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDay.SelectedItem != null)
            {
                if (cbDay.SelectedItem.ToString() == "Temizle")
                {
                    LoadDataGrid(insures);
                }
                else
                {
                    int selectedDays = int.Parse(cbDay.SelectedItem.ToString());
                    FilterByDaysRemaining(selectedDays);
                }
            }
        }

        private void FilterByDaysRemaining(int days)
        {
            DateTime now = DateTime.Now;
            var filteredInsures = insures.Where(insure => (insure.end_date - now).TotalDays <= days).ToList();
            LoadDataGrid(filteredInsures);
        }

        private void InitializeDataGridView()
        {
            dgvCustomerList.ReadOnly = true;
            dgvCustomerList.CellDoubleClick += dgvCustomerList_CellDoubleClick;
        }

        private async void dgvCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomerList.Rows[e.RowIndex];
                string customerId = row.Cells["CustomerId"].Value.ToString();
                customer = await db.GetCustomer(Convert.ToInt32(customerId));
                MessageBox.Show($"Müşteri Adı: {customer.first_name} {customer.last_name}\nTelefon Numarası: {customer.phone_number}\nKimlik Numarası: {customer.identity_number}", "Müşteri Bİlgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBox.Text.Trim();

            var filteredInsures = insures.Where(insure =>
                insure.insurance_type.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                insure.address.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                insure.document_no.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                insure.serial_no.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                insure.insure_amount.ToString().Contains(searchText) ||
                insure.plate.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                insure.referance_code.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                insure.uavt_code.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            LoadDataGrid(filteredInsures);
        }
    }
}
