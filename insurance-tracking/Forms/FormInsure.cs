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
    public partial class FormInsure : Form
    {
        AppDbContext db;
        private Insure selectedInsure;
        private Customer selectedCustomer;
        List<Customer> customers = new List<Customer>();
        List<Insure> insures = new List<Insure>();

        public FormInsure(AppDbContext dbContext)
        {
            InitializeComponent();
            pnlLeftInsideBottom.AutoScroll = true;
            pnlInsuranceList.AutoScroll = true;
            db = dbContext;
        }

        private async void FormInsure_Load(object sender, EventArgs e)
        {
            pnlMid.Visible = false;
            flpInsure.Visible = false;
            await LoadCustomers();
        }

        private async Task LoadCustomers()
        {
            customers = await db.GetCustomerList();

            foreach (var customer in customers)
            {
                CustomerCard customerCard = new CustomerCard(customer)
                {
                    Dock = DockStyle.Top,
                };
                customerCard.PickCustomer += CustomerCard_PickCustomer;
                pnlLeftInsideBottom.Controls.Add(customerCard);
            }
        }

        private async void CustomerCard_PickCustomer(Customer customer)
        {
            selectedCustomer = customer;
            pnlMid.Visible = true;
            selectedInsure = null;
            ResetFields();
            FillCustomerTextBoxes();
            pnlInsuranceList.Controls.Clear();
            await LoadInsurances(customer.customer_id);
        }

        private async Task LoadInsurances(int customerId)
        {
            insures = await db.GetInsureList(customerId);

            if (insures != null)
            {
                foreach (var insure in insures)
                {
                    InsureCard insureCard = new InsureCard(insure)
                    {
                        Dock = DockStyle.Top,
                    };
                    insureCard.PickInsure += İnsureCard_PickInsure;
                    pnlInsuranceList.Controls.Add(insureCard);
                }
            }
        }

        private void İnsureCard_PickInsure(Insure insure)
        {
            selectedInsure = insure;
            cbInsuranceType.SelectedItem = insure.insurance_type;
            flpInsure.Visible = true;
            FillTextBoxes();
        }

        private void FillTextBoxes()
        {
            if (selectedCustomer != null)
            {
                txtFirstName.Text = selectedCustomer.first_name;
                txtLastName.Text = selectedCustomer.last_name;
                txtIdentityNumber.Text = selectedCustomer.identity_number;
            }

            if (selectedInsure != null)
            {
                switch (cbInsuranceType.SelectedItem.ToString())
                {
                    case "Trafik":
                        pnlAddress.Visible = false;
                        pnlUavt.Visible = false;
                        txtDocumentNo.Text = selectedInsure.document_no;
                        txtSerialNo.Text = selectedInsure.serial_no;
                        break;
                    case "Kasko":
                        break;
                    case "Konut":
                        pnlDocument.Visible = false;
                        pnlSerial.Visible = false;
                        txtAddress.Text = selectedInsure.address;
                        txtUavtCode.Text = selectedInsure.uavt_code;
                        break;
                    case "Dask":
                        pnlDocument.Visible = false;
                        pnlSerial.Visible = false;
                        txtAddress.Text = selectedInsure.address;
                        txtUavtCode.Text = selectedInsure.uavt_code;
                        break;
                    case "Tamamlayıcı Sağlık Sigortası (tss)":
                        pnlDocument.Visible = false;
                        pnlSerial.Visible = false;
                        pnlUavt.Visible = false;
                        txtAddress.Text = selectedInsure.address;
                        break;
                    case "Bireysel Emeklilik (bes)":
                        pnlDocument.Visible = false;
                        pnlSerial.Visible = false;
                        pnlUavt.Visible = false;
                        txtAddress.Text = selectedInsure.address;
                        break;
                }
            }
        }

        private void cbInsuranceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetFields();
            if (cbInsuranceType.SelectedItem != null)
            {
                switch (cbInsuranceType.SelectedItem.ToString())
                {
                    case "Trafik":
                        pnlAddress.Visible = false;
                        pnlUavt.Visible = false;
                        pnlInsureAmount.Visible = true;
                        pnlDocument.Visible = true;
                        pnlSerial.Visible = true;
                        pnlPlate.Visible = true;
                        break;
                    case "Kasko":
                        pnlAddress.Visible = false;
                        pnlUavt.Visible = false;
                        pnlInsureAmount.Visible = true;
                        pnlDocument.Visible = true;
                        pnlSerial.Visible = true;
                        pnlPlate.Visible = true;
                        break;
                    case "Konut":
                        pnlDocument.Visible = false;
                        pnlSerial.Visible = false;
                        pnlPlate.Visible = false;
                        pnlAddress.Visible = true;
                        pnlUavt.Visible = true;
                        pnlInsureAmount.Visible = true;
                        break;
                    case "Dask":
                        pnlDocument.Visible = false;
                        pnlSerial.Visible = false;
                        pnlPlate.Visible = false;
                        pnlAddress.Visible = true;
                        pnlUavt.Visible = true;
                        pnlInsureAmount.Visible = true;
                        break;
                    case "Tamamlayıcı Sağlık Sigortası (tss)":
                        pnlDocument.Visible = false;
                        pnlSerial.Visible = false;
                        pnlPlate.Visible = false;
                        pnlUavt.Visible = false;
                        pnlAddress.Visible = true;
                        pnlInsureAmount.Visible = true;
                        break;
                    case "Bireysel Emeklilik (bes)":
                        pnlDocument.Visible = false;
                        pnlSerial.Visible = false;
                        pnlPlate.Visible = false;
                        pnlUavt.Visible = false;
                        pnlAddress.Visible = true;
                        pnlInsureAmount.Visible = true;
                        break;
                }
            }
            FillTextBoxes();
        }

        private void FillCustomerTextBoxes()
        {
            if (selectedCustomer != null)
            {
                txtFirstName.Text = selectedCustomer.first_name;
                txtLastName.Text = selectedCustomer.last_name;
                txtIdentityNumber.Text = selectedCustomer.identity_number;
            }
        }

        private void ResetFields()
        {
            pnlName.Visible = true;
            pnlLastName.Visible = true;
            pnlAddress.Visible = true;
            pnlUavt.Visible = true;
            pnlIdentity.Visible = true;
            pnlDocument.Visible = true;
            pnlSerial.Visible = true;
            pnlInsureAmount.Visible = true;

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtUavtCode.Text = "";
            txtIdentityNumber.Text = "";
            txtDocumentNo.Text = "";
            txtSerialNo.Text = "";
        }

        private void btnNewInsure_Click(object sender, EventArgs e)
        {
            if(selectedCustomer != null)
            {
                flpInsure.Visible = true;
            }
        }

        private async void btnInsure_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.");
                return;
            }

            // Gerekli alanların doldurulduğunu kontrol et
            if (string.IsNullOrEmpty(cbInsuranceType.Text) ||
                string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtIdentityNumber.Text))
            {
                MessageBox.Show("Lütfen gerekli tüm alanları doldurunuz.");
                return;
            }

            // Yeni bir Insure nesnesi oluştur
            Insure newInsure = new Insure
            {
                customer_id = selectedCustomer.customer_id,
                insurance_type = cbInsuranceType.SelectedItem.ToString(),
                address = txtAddress.Text,
                document_no = txtDocumentNo.Text,
                serial_no = txtSerialNo.Text,
                created_at = DateTime.Now,
                end_date = DateTime.Now.AddYears(1),
                creator_staff = "Güncel Kullanıcı",
                insure_amount = Convert.ToDouble(txtInsuranceAmount.Text),
                is_active = true,
                issue_date = DateTime.Now,
                plate = txtPlate.Text,
                referance_code = txtReferance.Text,
                uavt_code = txtUavtCode.Text
            };

            try
            {
                bool result = await db.AddInsurance(newInsure);

                if (result)
                {
                    MessageBox.Show("Yeni sigorta başarıyla eklendi.");
                    // Yeni eklenen sigorta kaydını listeye ekleyelim
                    InsureCard insureCard = new InsureCard(newInsure)
                    {
                        Dock = DockStyle.Top,
                    };
                    insureCard.PickInsure += İnsureCard_PickInsure;
                    pnlInsuranceList.Controls.Add(insureCard);
                }
                else
                {
                    MessageBox.Show("Yeni sigorta eklenirken bir hata oluştu.");
                }

                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sigorta eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCustomer.Text.ToLower();

            var filteredCustomers = customers.Where(c =>
                c.first_name.ToLower().Contains(searchText) ||
                c.last_name.ToLower().Contains(searchText) ||
                c.identity_number.ToLower().Contains(searchText)
            ).ToList();

            pnlLeftInsideBottom.Controls.Clear();

            foreach (var customer in filteredCustomers)
            {
                CustomerCard customerCard = new CustomerCard(customer)
                {
                    Dock = DockStyle.Top,
                };
                customerCard.PickCustomer += CustomerCard_PickCustomer;
                pnlLeftInsideBottom.Controls.Add(customerCard);
            }
        }

        private void txtSearchInsure_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchInsure.Text.ToLower();

            var filteredInsures = insures.Where(i =>
                (i.insurance_type != null && i.insurance_type.ToLower().Contains(searchText)) ||
                (i.document_no != null && i.document_no.ToLower().Contains(searchText)) ||
                (i.serial_no != null && i.serial_no.ToLower().Contains(searchText)) ||
                (i.address != null && i.address.ToLower().Contains(searchText)) ||
                (i.uavt_code != null && i.uavt_code.ToLower().Contains(searchText)) ||
                (i.plate != null && i.plate.ToLower().Contains(searchText))
            ).ToList();

            pnlInsuranceList.Controls.Clear();

            foreach (var insure in filteredInsures)
            {
                InsureCard insureCard = new InsureCard(insure)
                {
                    Dock = DockStyle.Top,
                };
                insureCard.PickInsure += İnsureCard_PickInsure;
                pnlInsuranceList.Controls.Add(insureCard);
            }
        }
    }
}
