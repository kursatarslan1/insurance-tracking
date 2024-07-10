using insurance_tracking.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace insurance_tracking.Forms
{
    public partial class FormOffers : Form
    {
        AppDbContext db = new AppDbContext();
        List<Offer> offers = new List<Offer>();
        public FormOffers()
        {
            InitializeComponent();
            pnlMid.AutoScroll = true;
        }

        private async void FormOffers_Load(object sender, EventArgs e)
        {
            offers = await db.GetOfferList();
            LoadDataGrid(offers);
            lblCustomerCount.Text = "Teklif Sayısı: " + offers.Count.ToString();
        }

        private void LoadDataGrid(List<Offer> offers)
        {
            dgvCustomerList.Rows.Clear();
            if (offers != null)
            {
                foreach (Offer offer in offers)
                {
                    dgvCustomerList.Rows.Add(offer.customer_full_name, offer.insurance_type, offer.address, offer.document_no, offer.serial_no, offer.created_at, offer.insure_amount, offer.issue_date);
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
