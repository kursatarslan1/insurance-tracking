using insurance_tracking.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace insurance_tracking.Forms
{
    public partial class FormInsuranceTrack : Form
    {
        AppDbContext db;
        List<Insure> insures = new List<Insure>();
        Customer customer = new Customer();
        public FormInsuranceTrack(AppDbContext dbContext)
        {
            InitializeComponent();
            InitializeDataGridView();
            db = dbContext;
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
                    dgvCustomerList.Rows.Add(insure.insurance_type, insure.address, insure.document_no, insure.serial_no, insure.created_at, insure.end_date, insure.insure_amount, insure.is_active, insure.issue_date, insure.plate, insure.referance_code, insure.uavt_code, insure.customer_id, insure.insure_id);
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

            // CancelInsurance adında bir buton kolonu ekleyin
            DataGridViewButtonColumn cancelColumn = new DataGridViewButtonColumn();
            cancelColumn.Name = "CancelInsurance";
            cancelColumn.HeaderText = "Poliçe İptal";
            cancelColumn.Text = "Poliçe İptal";
            cancelColumn.UseColumnTextForButtonValue = true;
            dgvCustomerList.Columns.Add(cancelColumn);

            dgvCustomerList.CellPainting += dgvCustomerList_CellPainting;
            dgvCustomerList.CellContentClick += dgvCustomerList_CellContentClick;
        }

        private async void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCustomerList.Columns["CancelInsurance"].Index && e.RowIndex >= 0)
            {
                int insureId = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells["InsureId"].Value);
                DialogResult result = MessageBox.Show("Poliçe iptaline emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool cancelResult = await db.CancelInsurance(insureId);

                    if (cancelResult)
                    {
                        MessageBox.Show("Poliçe başarıyla iptal edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insures = await db.GetInsureList(); // Güncel listeyi al
                        LoadDataGrid(insures); // DataGridView'i güncelle
                    }
                    else
                    {
                        MessageBox.Show("Poliçe iptali başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvCustomerList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvCustomerList.Columns["CancelInsurance"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var cellButton = e.CellBounds;
                var buttonRectangle = new Rectangle(cellButton.Location.X + 5, cellButton.Location.Y + 5, cellButton.Width - 10, cellButton.Height - 10);

                ButtonRenderer.DrawButton(e.Graphics, buttonRectangle, PushButtonState.Normal);
                TextRenderer.DrawText(e.Graphics, "Poliçe İptal", e.CellStyle.Font, buttonRectangle, Color.Red, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
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
