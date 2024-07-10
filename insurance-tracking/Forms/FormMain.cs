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
    public partial class FormMain : Form
    {
        AppDbContext dbContext;
        public FormMain(AppDbContext db)
        {
            InitializeComponent();
            dbContext = db;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // FormInsuranceTrack'i panel1'e ekleme
            FormInsuranceTrack formInsuranceTrack = new FormInsuranceTrack(dbContext);
            formInsuranceTrack.TopLevel = false;
            formInsuranceTrack.AutoScroll = true;
            formInsuranceTrack.FormBorderStyle = FormBorderStyle.None;
            formInsuranceTrack.Dock = DockStyle.Fill;
            panel1.Controls.Add(formInsuranceTrack);
            formInsuranceTrack.Show();

            // FormOffers'ı panel2'ye ekleme
            FormOffers formOffers = new FormOffers(dbContext);
            formOffers.TopLevel = false;
            formOffers.AutoScroll = true;
            formOffers.FormBorderStyle = FormBorderStyle.None;
            formOffers.Dock = DockStyle.Fill;
            panel2.Controls.Add(formOffers);
            formOffers.Show();
        }
    }
}
