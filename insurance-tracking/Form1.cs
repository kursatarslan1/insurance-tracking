using insurance_tracking.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insurance_tracking
{
    public partial class FormLogin : Form
    {
        AppDbContext db = new AppDbContext();
        private string email = string.Empty;
        private string password = string.Empty;
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtUsername.Text) || !String.IsNullOrEmpty(txtPassword.Text)) 
            {
                email = txtUsername.Text;
                password = txtPassword.Text;

                var result = await db.Login(email, password);

                if(result != null)
                {
                    FormHome formHome = new FormHome(result);
                    formHome.Show();
                    this.Hide();
                    formHome.FormClosed += (s, args) => this.Close();
                } else { 
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Uyarı",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
