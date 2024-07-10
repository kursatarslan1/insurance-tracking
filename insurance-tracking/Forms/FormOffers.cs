using insurance_tracking.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace insurance_tracking.Forms
{
    public partial class FormOffers : Form
    {
        AppDbContext db;
        List<Offer> offers = new List<Offer>();

        public FormOffers(AppDbContext dbContext)
        {
            InitializeComponent();
            pnlMid.AutoScroll = true;
            InitializeDataGridView();
            db = dbContext; 
        }

        private async void FormOffers_Load(object sender, EventArgs e)
        {
            // İlk olarak DataGridView sütunlarının tanımlandığından emin olun
            InitializeDataGridView();

            // Daha sonra verileri yükleyin
            offers = await db.GetOfferList();
            LoadDataGrid(offers);
            lblCustomerCount.Text = "Teklif Sayısı: " + offers.Count.ToString();
        }

        private void InitializeDataGridView()
        {
            // DataGridView'de sütunları temizleyin ve yeniden tanımlayın
            dgvCustomerList.Columns.Clear();
            dgvCustomerList.Columns.Add("customer_full_name", "Müşteri Adı");
            dgvCustomerList.Columns.Add("insurance_type", "Sigorta Türü");
            dgvCustomerList.Columns.Add("address", "Adres");
            dgvCustomerList.Columns.Add("document_no", "Belge No");
            dgvCustomerList.Columns.Add("serial_no", "Seri No");
            dgvCustomerList.Columns.Add("created_at", "Oluşturulma Tarihi");
            dgvCustomerList.Columns.Add("insure_amount", "Sigorta Miktarı");
            dgvCustomerList.Columns.Add("issue_date", "Düzenlenme Tarihi");
        }

        private void LoadDataGrid(List<Offer> offers)
        {
            
            dgvCustomerList.Rows.Clear();
            InitializeDataGridView();
            if (offers != null)
            {
                foreach (Offer offer in offers)
                {
                    dgvCustomerList.Rows.Add(
                        offer.customer_full_name,
                        offer.insurance_type,
                        offer.address,
                        offer.document_no,
                        offer.serial_no,
                        offer.created_at,
                        offer.insure_amount,
                        offer.issue_date);
                }
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            FilterOffers(txtSearchBox.Text);
        }

        private void FilterOffers(string searchText)
        {
            var filteredOffers = offers.Where(offer =>
                offer.customer_full_name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                offer.insurance_type.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                offer.address.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                offer.document_no.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                offer.serial_no.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                offer.insure_amount.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            LoadDataGrid(filteredOffers);
            lblCustomerCount.Text = "Teklif Sayısı: " + filteredOffers.Count.ToString();
        }
    }
}
