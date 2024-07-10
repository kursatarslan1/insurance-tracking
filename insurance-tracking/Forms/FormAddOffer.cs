using insurance_tracking.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace insurance_tracking.Forms
{
    public partial class FormAddOffer : Form
    {
        AppDbContext db;
        public FormAddOffer(AppDbContext dbContext)
        {
            InitializeComponent();
            db = dbContext;
        }

        private async void btnCreateOffer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Müşteri adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbInsureType.SelectedItem == null || string.IsNullOrWhiteSpace(cbInsureType.SelectedItem.ToString()))
            {
                MessageBox.Show("Sigorta türü boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnCreateOffer.Enabled = false;

            Offer offer = new Offer
            {
                customer_full_name = txtName.Text,
                insurance_type = cbInsureType.SelectedItem.ToString(), // Burada SelectedText yerine SelectedItem kullanıyoruz
                address = txtAddress.Text,
                document_no = txtDocumentNo.Text,
                serial_no = txtSerialNo.Text,
                insure_amount = Convert.ToInt32(txtInsureAmount.Text),
                created_at = DateTime.Now,
                issue_date = dtpIssueDate.Value,
                plate = txtPlate.Text,
                referance_code = txtReferanceCode.Text,
                uavt_code = txtUavtCode.Text,
            };

            bool result = await db.AddOffer(offer);

            if (result)
            {
                MessageBox.Show("Teklif başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Teklif eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnCreateOffer.Enabled = true;
        }
    }
}
