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
    public delegate void PickInsureHandler(Insure insure);
    public partial class InsureCard : UserControl
    {
        public event PickInsureHandler PickInsure;
        Insure insure = new Insure();
        public InsureCard(Insure insure)
        {
            InitializeComponent();
            this.insure = insure;
        }

        private void btnPickInsure_Click(object sender, EventArgs e)
        {
            PickInsure?.Invoke(insure);
        }

        private void InsureCard_Load(object sender, EventArgs e)
        {
            lblInsureType.Text = "Sigorta tipi: " + insure.insurance_type;
            lblPlate.Text = "Plaka: " + insure.plate;
            lblAddress.Text = insure.address;
            lblIsActive.Text = insure.is_active == true ? "\"Sigorta durumu: \"Aktif" : "\"Sigorta durumu: \"Pasif";
        }
    }
}
