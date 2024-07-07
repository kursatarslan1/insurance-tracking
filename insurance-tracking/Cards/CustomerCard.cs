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

namespace insurance_tracking.Cards
{
    public delegate void PickCustomerHandler(Customer customer);
    public partial class CustomerCard : UserControl
    {
        public event PickCustomerHandler PickCustomer;
        Customer customer = new Customer();
        public CustomerCard(Customer incoming_customer)
        {
            InitializeComponent();
            customer = incoming_customer;
        }

        public int CustomerId {  get; set; }

        public string Name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string PhoneNumber
        {
            get { return lblPhone.Text; }
            set { lblPhone.Text = value; }
        }

        public string IdentityNumber
        {
            get { return lblIdentity.Text; }
            set { lblIdentity.Text = value; }
        }

        private void btnPickCustomer_Click(object sender, EventArgs e)
        {
            PickCustomer?.Invoke(customer);
        }

        private void CustomerCard_Load(object sender, EventArgs e)
        {
            lblName.Text = "Ad-soyad: " + customer.first_name + " " + customer.last_name;
            lblPhone.Text = "Telefon Numarası: " + customer.phone_number;
            lblIdentity.Text = "Kimlik Numarası: " + customer.identity_number;
        }
    }
}
