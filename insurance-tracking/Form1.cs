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
            InitData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitData()
        {
            if(Properties.Settings.Default.username != string.Empty)
            {
                if (Properties.Settings.Default.remember_me)
                {
                    txtUsername.Text = Properties.Settings.Default.username;
                    txtPassword.Text = Properties.Settings.Default.password;
                    cbRememberMe.Checked = true;
                } else
                    txtUsername.Text= Properties.Settings.Default.username;
            }
        }

        private void SaveData()
        {
            if(cbRememberMe.Checked)
            {
                Properties.Settings.Default.username = txtUsername.Text;
                Properties.Settings.Default.password = txtPassword.Text;
                Properties.Settings.Default.remember_me = true;
                Properties.Settings.Default.Save();
            } else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.remember_me = false;
                Properties.Settings.Default.Save();
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtUsername.Text) || !String.IsNullOrEmpty(txtPassword.Text)) 
            {
                btnLogin.Enabled = false;
                var result = await db.Login(txtUsername.Text, txtPassword.Text);
                btnLogin.Enabled= true;

                if(result != null)
                {
                    SaveData();
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
