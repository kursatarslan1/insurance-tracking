namespace insurance_tracking.Forms
{
    partial class FormCustomerEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flpCustomer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlLastName = new System.Windows.Forms.Panel();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.pnlIdentity = new System.Windows.Forms.Panel();
            this.txtIdentity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.pnlPhone = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.pnlMail = new System.Windows.Forms.Panel();
            this.txtMailAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMailAddress = new System.Windows.Forms.Label();
            this.pnlBirthDate = new System.Windows.Forms.Panel();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRightTop = new System.Windows.Forms.Panel();
            this.lblPickCustomer = new System.Windows.Forms.Label();
            this.pnlRightSearchBar = new System.Windows.Forms.Panel();
            this.pnlRightCustomers = new System.Windows.Forms.Panel();
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLeft.SuspendLayout();
            this.flpCustomer.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlLastName.SuspendLayout();
            this.pnlIdentity.SuspendLayout();
            this.pnlPhone.SuspendLayout();
            this.pnlMail.SuspendLayout();
            this.pnlBirthDate.SuspendLayout();
            this.pnlRightTop.SuspendLayout();
            this.pnlRightSearchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.flpCustomer);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(554, 571);
            this.pnlLeft.TabIndex = 0;
            // 
            // flpCustomer
            // 
            this.flpCustomer.Controls.Add(this.pnlName);
            this.flpCustomer.Controls.Add(this.pnlLastName);
            this.flpCustomer.Controls.Add(this.pnlIdentity);
            this.flpCustomer.Controls.Add(this.pnlPhone);
            this.flpCustomer.Controls.Add(this.pnlMail);
            this.flpCustomer.Controls.Add(this.pnlBirthDate);
            this.flpCustomer.Controls.Add(this.btnAdd);
            this.flpCustomer.Controls.Add(this.btnUpdate);
            this.flpCustomer.Controls.Add(this.btnClear);
            this.flpCustomer.Controls.Add(this.btnDeleteCustomer);
            this.flpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCustomer.Location = new System.Drawing.Point(0, 0);
            this.flpCustomer.Name = "flpCustomer";
            this.flpCustomer.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.flpCustomer.Size = new System.Drawing.Size(554, 571);
            this.flpCustomer.TabIndex = 0;
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.txtFirstName);
            this.pnlName.Controls.Add(this.lblFirstName);
            this.pnlName.Location = new System.Drawing.Point(3, 48);
            this.pnlName.Name = "pnlName";
            this.pnlName.Padding = new System.Windows.Forms.Padding(5);
            this.pnlName.Size = new System.Drawing.Size(265, 80);
            this.pnlName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderRadius = 6;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(5, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.PlaceholderText = "Kürşat";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(255, 42);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.Location = new System.Drawing.Point(5, 5);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(255, 33);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Adı:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLastName
            // 
            this.pnlLastName.Controls.Add(this.txtLastName);
            this.pnlLastName.Controls.Add(this.lblLastName);
            this.pnlLastName.Location = new System.Drawing.Point(274, 48);
            this.pnlLastName.Name = "pnlLastName";
            this.pnlLastName.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLastName.Size = new System.Drawing.Size(265, 80);
            this.pnlLastName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderRadius = 6;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(5, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.PlaceholderText = "Arslan";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(255, 42);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.Location = new System.Drawing.Point(5, 5);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(255, 33);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Soyadı:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlIdentity
            // 
            this.pnlIdentity.Controls.Add(this.txtIdentity);
            this.pnlIdentity.Controls.Add(this.lblIdentity);
            this.pnlIdentity.Location = new System.Drawing.Point(3, 134);
            this.pnlIdentity.Name = "pnlIdentity";
            this.pnlIdentity.Padding = new System.Windows.Forms.Padding(5);
            this.pnlIdentity.Size = new System.Drawing.Size(536, 80);
            this.pnlIdentity.TabIndex = 3;
            // 
            // txtIdentity
            // 
            this.txtIdentity.BorderRadius = 6;
            this.txtIdentity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentity.DefaultText = "";
            this.txtIdentity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdentity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdentity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdentity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdentity.ForeColor = System.Drawing.Color.Black;
            this.txtIdentity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentity.Location = new System.Drawing.Point(5, 38);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.PasswordChar = '\0';
            this.txtIdentity.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtIdentity.PlaceholderText = "12345678910";
            this.txtIdentity.SelectedText = "";
            this.txtIdentity.Size = new System.Drawing.Size(526, 42);
            this.txtIdentity.TabIndex = 2;
            // 
            // lblIdentity
            // 
            this.lblIdentity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdentity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdentity.Location = new System.Drawing.Point(5, 5);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(526, 33);
            this.lblIdentity.TabIndex = 0;
            this.lblIdentity.Text = "T.C. Kimlik Numarası:";
            this.lblIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPhone
            // 
            this.pnlPhone.Controls.Add(this.txtPhoneNumber);
            this.pnlPhone.Controls.Add(this.lblPhoneNumber);
            this.pnlPhone.Location = new System.Drawing.Point(3, 220);
            this.pnlPhone.Name = "pnlPhone";
            this.pnlPhone.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPhone.Size = new System.Drawing.Size(536, 80);
            this.pnlPhone.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderRadius = 6;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(5, 38);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumber.PlaceholderText = "+90 543 987 65 42";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(526, 42);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 5);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(526, 33);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Telefon Numarası:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMail
            // 
            this.pnlMail.Controls.Add(this.txtMailAddress);
            this.pnlMail.Controls.Add(this.lblMailAddress);
            this.pnlMail.Location = new System.Drawing.Point(3, 306);
            this.pnlMail.Name = "pnlMail";
            this.pnlMail.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMail.Size = new System.Drawing.Size(265, 80);
            this.pnlMail.TabIndex = 5;
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.BorderRadius = 6;
            this.txtMailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMailAddress.DefaultText = "";
            this.txtMailAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMailAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMailAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMailAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMailAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMailAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMailAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMailAddress.ForeColor = System.Drawing.Color.Black;
            this.txtMailAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMailAddress.Location = new System.Drawing.Point(5, 38);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.PasswordChar = '\0';
            this.txtMailAddress.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMailAddress.PlaceholderText = "test@example.com";
            this.txtMailAddress.SelectedText = "";
            this.txtMailAddress.Size = new System.Drawing.Size(255, 42);
            this.txtMailAddress.TabIndex = 2;
            // 
            // lblMailAddress
            // 
            this.lblMailAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMailAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailAddress.Location = new System.Drawing.Point(5, 5);
            this.lblMailAddress.Name = "lblMailAddress";
            this.lblMailAddress.Size = new System.Drawing.Size(255, 33);
            this.lblMailAddress.TabIndex = 0;
            this.lblMailAddress.Text = "Mail Adresi:";
            this.lblMailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBirthDate
            // 
            this.pnlBirthDate.Controls.Add(this.dtpBirthDate);
            this.pnlBirthDate.Controls.Add(this.lblBirthDate);
            this.pnlBirthDate.Location = new System.Drawing.Point(274, 306);
            this.pnlBirthDate.Name = "pnlBirthDate";
            this.pnlBirthDate.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBirthDate.Size = new System.Drawing.Size(265, 80);
            this.pnlBirthDate.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.BorderRadius = 6;
            this.dtpBirthDate.Checked = true;
            this.dtpBirthDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpBirthDate.FillColor = System.Drawing.Color.White;
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthDate.Location = new System.Drawing.Point(5, 38);
            this.dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(255, 42);
            this.dtpBirthDate.TabIndex = 1;
            this.dtpBirthDate.Value = new System.DateTime(2024, 7, 2, 0, 49, 49, 239);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBirthDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirthDate.Location = new System.Drawing.Point(5, 5);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(255, 33);
            this.lblBirthDate.TabIndex = 0;
            this.lblBirthDate.Text = "Doğum Tarihi:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(116)))), ((int)(((byte)(69)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(184, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 45);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Düzenlemeyi Kaydet";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 10;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(365, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 45);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Temizle";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BorderRadius = 10;
            this.btnDeleteCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(3, 443);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(536, 45);
            this.btnDeleteCustomer.TabIndex = 10;
            this.btnDeleteCustomer.Text = "Müşteriyi Sil";
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.Controls.Add(this.lblPickCustomer);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(554, 0);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(307, 83);
            this.pnlRightTop.TabIndex = 1;
            // 
            // lblPickCustomer
            // 
            this.lblPickCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPickCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPickCustomer.Location = new System.Drawing.Point(0, 50);
            this.lblPickCustomer.Name = "lblPickCustomer";
            this.lblPickCustomer.Size = new System.Drawing.Size(307, 33);
            this.lblPickCustomer.TabIndex = 1;
            this.lblPickCustomer.Text = "Müşteri Seç";
            this.lblPickCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRightSearchBar
            // 
            this.pnlRightSearchBar.Controls.Add(this.pnlRightCustomers);
            this.pnlRightSearchBar.Controls.Add(this.txtSearchBox);
            this.pnlRightSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightSearchBar.Location = new System.Drawing.Point(554, 83);
            this.pnlRightSearchBar.Name = "pnlRightSearchBar";
            this.pnlRightSearchBar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlRightSearchBar.Size = new System.Drawing.Size(307, 488);
            this.pnlRightSearchBar.TabIndex = 2;
            // 
            // pnlRightCustomers
            // 
            this.pnlRightCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightCustomers.Location = new System.Drawing.Point(5, 36);
            this.pnlRightCustomers.Name = "pnlRightCustomers";
            this.pnlRightCustomers.Size = new System.Drawing.Size(297, 440);
            this.pnlRightCustomers.TabIndex = 2;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BorderColor = System.Drawing.Color.Black;
            this.txtSearchBox.BorderRadius = 6;
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBox.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.IconLeft = global::insurance_tracking.Properties.Resources.search_interface_symbol;
            this.txtSearchBox.Location = new System.Drawing.Point(5, 0);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PasswordChar = '\0';
            this.txtSearchBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchBox.PlaceholderText = "Ara";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.Size = new System.Drawing.Size(297, 36);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // FormCustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(861, 571);
            this.Controls.Add(this.pnlRightSearchBar);
            this.Controls.Add(this.pnlRightTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomerEdit";
            this.Text = "Müşteri Ekle/Düzenle/Sil";
            this.Load += new System.EventHandler(this.FormCustomerEdit_Load);
            this.pnlLeft.ResumeLayout(false);
            this.flpCustomer.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlLastName.ResumeLayout(false);
            this.pnlIdentity.ResumeLayout(false);
            this.pnlPhone.ResumeLayout(false);
            this.pnlMail.ResumeLayout(false);
            this.pnlBirthDate.ResumeLayout(false);
            this.pnlRightTop.ResumeLayout(false);
            this.pnlRightSearchBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.FlowLayoutPanel flpCustomer;
        private System.Windows.Forms.Panel pnlName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnlLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel pnlIdentity;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Panel pnlPhone;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Panel pnlMail;
        private System.Windows.Forms.Label lblMailAddress;
        private System.Windows.Forms.Panel pnlBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtIdentity;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtMailAddress;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Panel pnlRightTop;
        private System.Windows.Forms.Label lblPickCustomer;
        private System.Windows.Forms.Panel pnlRightSearchBar;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
        private System.Windows.Forms.Panel pnlRightCustomers;
    }
}