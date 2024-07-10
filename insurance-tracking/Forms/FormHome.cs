using Guna.UI2.WinForms;
using insurance_tracking.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insurance_tracking.Forms
{
    public partial class FormHome : Form
    {
        public static AppDbContext db = new AppDbContext();
        private Guna2Button currentButton;
        private Form activeForm;
        private User user = new User();
        public FormHome(User incoming_user)
        {
            InitializeComponent();
            user = incoming_user;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void FormHome_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            btnCloseChildForm.Visible = false;

            lblName.Text = user.first_name + " " + user.last_name;
            lblCompany.Text = user.company_name;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Guna2Button)btnSender)
                {
                    currentButton = (Guna2Button)btnSender;
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMid.Controls.Add(childForm);
            this.pnlMid.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void pnlTopMid_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)  
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            btnHome.PerformClick();
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMain(db), sender);
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCustomerList(db), sender);
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCustomerEdit(db), sender);
        }

        private void btnInsuranceTrack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInsuranceTrack(db), sender);
        }

        private void btnInsure_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInsure(db), sender);
        }

        private void btnOffers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOffers(db), sender);
        }

        private void btnAddOffer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddOffer(db), sender);
        }
    }
}
