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
        AppDbContext db = new AppDbContext();
        public FormInsure()
        {
            InitializeComponent();
            pnlLeftInsideBottom.AutoScroll = true;
            pnlInsuranceList.AutoScroll = true;
        }

        private async void FormInsure_Load(object sender, EventArgs e)
        {
            var customerList = await db.GetCustomerList();

            if(customerList != null )
            {
                foreach (var customer in customerList)
                {
                    CustomerCard customerCard = new CustomerCard(customer)
                    {
                        Dock = DockStyle.Top,
                    };
                    customerCard.PickCustomer += CustomerCard_PickCustomer;
                    pnlLeftInsideBottom.Controls.Add(customerCard);
                }
            }
        }

        private async void CustomerCard_PickCustomer(Customer customer)
        {
            pnlInsuranceList.Controls.Clear();
            var insureList = await db.GetInsureList(customer.customer_id);

            if(insureList != null )
            {
                foreach (var insure in insureList)
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
            
        }
    }
}
