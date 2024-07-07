namespace insurance_tracking.Forms
{
    partial class FormInsure
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
            this.pnlRightSearchBar = new System.Windows.Forms.Panel();
            this.flpInsure = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInsureType = new System.Windows.Forms.Label();
            this.cbInsuranceType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIdentityNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDocumentNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDocumentNo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSerialNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtInsuranceAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInsuranceAmount = new System.Windows.Forms.Label();
            this.btnInsure = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pnlInsuranceList = new System.Windows.Forms.Panel();
            this.txtSearchAsset = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPickAsset = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLeftInside = new System.Windows.Forms.Panel();
            this.pnlLeftInsideBottom = new System.Windows.Forms.Panel();
            this.txtSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPickCustomer = new System.Windows.Forms.Label();
            this.btnNewInsure = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRightSearchBar.SuspendLayout();
            this.flpInsure.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftInside.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRightSearchBar
            // 
            this.pnlRightSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.pnlRightSearchBar.Controls.Add(this.flpInsure);
            this.pnlRightSearchBar.Controls.Add(this.panel3);
            this.pnlRightSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightSearchBar.Location = new System.Drawing.Point(300, 25);
            this.pnlRightSearchBar.Name = "pnlRightSearchBar";
            this.pnlRightSearchBar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlRightSearchBar.Size = new System.Drawing.Size(848, 713);
            this.pnlRightSearchBar.TabIndex = 5;
            // 
            // flpInsure
            // 
            this.flpInsure.Controls.Add(this.lblInsureType);
            this.flpInsure.Controls.Add(this.cbInsuranceType);
            this.flpInsure.Controls.Add(this.pnlName);
            this.flpInsure.Controls.Add(this.panel1);
            this.flpInsure.Controls.Add(this.panel2);
            this.flpInsure.Controls.Add(this.panel4);
            this.flpInsure.Controls.Add(this.panel5);
            this.flpInsure.Controls.Add(this.panel6);
            this.flpInsure.Controls.Add(this.panel7);
            this.flpInsure.Controls.Add(this.btnInsure);
            this.flpInsure.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpInsure.Location = new System.Drawing.Point(323, 0);
            this.flpInsure.Name = "flpInsure";
            this.flpInsure.Size = new System.Drawing.Size(523, 713);
            this.flpInsure.TabIndex = 5;
            // 
            // lblInsureType
            // 
            this.lblInsureType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInsureType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInsureType.Location = new System.Drawing.Point(3, 0);
            this.lblInsureType.Name = "lblInsureType";
            this.lblInsureType.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblInsureType.Size = new System.Drawing.Size(449, 42);
            this.lblInsureType.TabIndex = 4;
            this.lblInsureType.Text = "Sigorta Tipi";
            this.lblInsureType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbInsuranceType
            // 
            this.cbInsuranceType.BackColor = System.Drawing.Color.Transparent;
            this.cbInsuranceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbInsuranceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInsuranceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsuranceType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInsuranceType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInsuranceType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbInsuranceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbInsuranceType.ItemHeight = 30;
            this.cbInsuranceType.Items.AddRange(new object[] {
            "Trafik",
            "Kasko",
            "Konut",
            "Dask",
            "Tamamlayıcı Sağlık Sigortası (tss)",
            "Bireysel Emeklilik (bes)"});
            this.cbInsuranceType.Location = new System.Drawing.Point(3, 45);
            this.cbInsuranceType.Name = "cbInsuranceType";
            this.cbInsuranceType.Size = new System.Drawing.Size(451, 36);
            this.cbInsuranceType.TabIndex = 5;
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.txtFirstName);
            this.pnlName.Controls.Add(this.lblFirstName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(3, 87);
            this.pnlName.Name = "pnlName";
            this.pnlName.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.pnlName.Size = new System.Drawing.Size(218, 80);
            this.pnlName.TabIndex = 6;
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
            this.txtFirstName.Location = new System.Drawing.Point(0, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.PlaceholderText = "Kürşat";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(213, 42);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.Location = new System.Drawing.Point(0, 5);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(213, 30);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Adı:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(227, 87);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(230, 80);
            this.panel1.TabIndex = 7;
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
            this.txtLastName.Location = new System.Drawing.Point(5, 35);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.PlaceholderText = "Arslan";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(220, 42);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.Location = new System.Drawing.Point(5, 5);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(220, 30);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Soyadı:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIdentityNumber);
            this.panel2.Controls.Add(this.lblIdentity);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 173);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(454, 80);
            this.panel2.TabIndex = 8;
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.BorderRadius = 6;
            this.txtIdentityNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentityNumber.DefaultText = "";
            this.txtIdentityNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdentityNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdentityNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentityNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentityNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdentityNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentityNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdentityNumber.ForeColor = System.Drawing.Color.Black;
            this.txtIdentityNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentityNumber.Location = new System.Drawing.Point(0, 35);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.PasswordChar = '\0';
            this.txtIdentityNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtIdentityNumber.PlaceholderText = "12345678910";
            this.txtIdentityNumber.SelectedText = "";
            this.txtIdentityNumber.Size = new System.Drawing.Size(449, 42);
            this.txtIdentityNumber.TabIndex = 1;
            // 
            // lblIdentity
            // 
            this.lblIdentity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdentity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdentity.Location = new System.Drawing.Point(0, 5);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(449, 30);
            this.lblIdentity.TabIndex = 0;
            this.lblIdentity.Text = "T.C. Kimlik Numarası:";
            this.lblIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.lblAddress);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 259);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.panel4.Size = new System.Drawing.Size(454, 80);
            this.panel4.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderRadius = 6;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(0, 35);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtAddress.PlaceholderText = "Rastgele Mahalle rastgele sokak";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(449, 42);
            this.txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(0, 5);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(449, 30);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Adres:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtDocumentNo);
            this.panel5.Controls.Add(this.lblDocumentNo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 345);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.panel5.Size = new System.Drawing.Size(218, 80);
            this.panel5.TabIndex = 10;
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.BorderRadius = 6;
            this.txtDocumentNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentNo.DefaultText = "";
            this.txtDocumentNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocumentNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocumentNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocumentNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocumentNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDocumentNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumentNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocumentNo.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumentNo.Location = new System.Drawing.Point(0, 35);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.PasswordChar = '\0';
            this.txtDocumentNo.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDocumentNo.PlaceholderText = "BH ";
            this.txtDocumentNo.SelectedText = "";
            this.txtDocumentNo.Size = new System.Drawing.Size(213, 42);
            this.txtDocumentNo.TabIndex = 1;
            // 
            // lblDocumentNo
            // 
            this.lblDocumentNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDocumentNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDocumentNo.Location = new System.Drawing.Point(0, 5);
            this.lblDocumentNo.Name = "lblDocumentNo";
            this.lblDocumentNo.Size = new System.Drawing.Size(213, 30);
            this.lblDocumentNo.TabIndex = 0;
            this.lblDocumentNo.Text = "Belge Numarası";
            this.lblDocumentNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSerialNo);
            this.panel6.Controls.Add(this.lblSerialNo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(227, 345);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(230, 80);
            this.panel6.TabIndex = 11;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BorderRadius = 6;
            this.txtSerialNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerialNo.DefaultText = "";
            this.txtSerialNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSerialNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSerialNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSerialNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSerialNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSerialNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerialNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSerialNo.ForeColor = System.Drawing.Color.Black;
            this.txtSerialNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerialNo.Location = new System.Drawing.Point(5, 35);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.PasswordChar = '\0';
            this.txtSerialNo.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSerialNo.PlaceholderText = "616218";
            this.txtSerialNo.SelectedText = "";
            this.txtSerialNo.Size = new System.Drawing.Size(220, 42);
            this.txtSerialNo.TabIndex = 1;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSerialNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSerialNo.Location = new System.Drawing.Point(5, 5);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(220, 30);
            this.lblSerialNo.TabIndex = 0;
            this.lblSerialNo.Text = "Seri Numarası:";
            this.lblSerialNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtInsuranceAmount);
            this.panel7.Controls.Add(this.lblInsuranceAmount);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 431);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.panel7.Size = new System.Drawing.Size(454, 80);
            this.panel7.TabIndex = 12;
            // 
            // txtInsuranceAmount
            // 
            this.txtInsuranceAmount.BorderRadius = 6;
            this.txtInsuranceAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInsuranceAmount.DefaultText = "";
            this.txtInsuranceAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInsuranceAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInsuranceAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInsuranceAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInsuranceAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInsuranceAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInsuranceAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInsuranceAmount.ForeColor = System.Drawing.Color.Black;
            this.txtInsuranceAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInsuranceAmount.Location = new System.Drawing.Point(0, 35);
            this.txtInsuranceAmount.Name = "txtInsuranceAmount";
            this.txtInsuranceAmount.PasswordChar = '\0';
            this.txtInsuranceAmount.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtInsuranceAmount.PlaceholderText = "1500";
            this.txtInsuranceAmount.SelectedText = "";
            this.txtInsuranceAmount.Size = new System.Drawing.Size(449, 42);
            this.txtInsuranceAmount.TabIndex = 1;
            // 
            // lblInsuranceAmount
            // 
            this.lblInsuranceAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInsuranceAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInsuranceAmount.Location = new System.Drawing.Point(0, 5);
            this.lblInsuranceAmount.Name = "lblInsuranceAmount";
            this.lblInsuranceAmount.Size = new System.Drawing.Size(449, 30);
            this.lblInsuranceAmount.TabIndex = 0;
            this.lblInsuranceAmount.Text = "Sigorta Tutarı:";
            this.lblInsuranceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInsure
            // 
            this.btnInsure.BorderRadius = 10;
            this.btnInsure.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsure.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsure.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsure.ForeColor = System.Drawing.Color.White;
            this.btnInsure.Location = new System.Drawing.Point(3, 517);
            this.btnInsure.Name = "btnInsure";
            this.btnInsure.Size = new System.Drawing.Size(449, 45);
            this.btnInsure.TabIndex = 13;
            this.btnInsure.Text = "Sigorta Kes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.pnlMid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 713);
            this.panel3.TabIndex = 4;
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.pnlMid.Controls.Add(this.btnNewInsure);
            this.pnlMid.Controls.Add(this.pnlInsuranceList);
            this.pnlMid.Controls.Add(this.txtSearchAsset);
            this.pnlMid.Controls.Add(this.lblPickAsset);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(0, 0);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlMid.Size = new System.Drawing.Size(318, 713);
            this.pnlMid.TabIndex = 6;
            // 
            // pnlInsuranceList
            // 
            this.pnlInsuranceList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInsuranceList.Location = new System.Drawing.Point(5, 78);
            this.pnlInsuranceList.Name = "pnlInsuranceList";
            this.pnlInsuranceList.Size = new System.Drawing.Size(308, 544);
            this.pnlInsuranceList.TabIndex = 5;
            // 
            // txtSearchAsset
            // 
            this.txtSearchAsset.BorderColor = System.Drawing.Color.Black;
            this.txtSearchAsset.BorderRadius = 6;
            this.txtSearchAsset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAsset.DefaultText = "";
            this.txtSearchAsset.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchAsset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchAsset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAsset.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAsset.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchAsset.FillColor = System.Drawing.Color.LightGray;
            this.txtSearchAsset.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAsset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchAsset.ForeColor = System.Drawing.Color.Black;
            this.txtSearchAsset.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAsset.IconLeft = global::insurance_tracking.Properties.Resources.search_interface_symbol;
            this.txtSearchAsset.Location = new System.Drawing.Point(5, 42);
            this.txtSearchAsset.Name = "txtSearchAsset";
            this.txtSearchAsset.PasswordChar = '\0';
            this.txtSearchAsset.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchAsset.PlaceholderText = "Ara";
            this.txtSearchAsset.SelectedText = "";
            this.txtSearchAsset.Size = new System.Drawing.Size(308, 36);
            this.txtSearchAsset.TabIndex = 4;
            // 
            // lblPickAsset
            // 
            this.lblPickAsset.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPickAsset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPickAsset.Location = new System.Drawing.Point(5, 0);
            this.lblPickAsset.Name = "lblPickAsset";
            this.lblPickAsset.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPickAsset.Size = new System.Drawing.Size(308, 42);
            this.lblPickAsset.TabIndex = 3;
            this.lblPickAsset.Text = "Varlık Seç";
            this.lblPickAsset.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.pnlLeft.Controls.Add(this.pnlLeftInside);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 25);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 713);
            this.pnlLeft.TabIndex = 3;
            // 
            // pnlLeftInside
            // 
            this.pnlLeftInside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.pnlLeftInside.Controls.Add(this.pnlLeftInsideBottom);
            this.pnlLeftInside.Controls.Add(this.txtSearchCustomer);
            this.pnlLeftInside.Controls.Add(this.lblPickCustomer);
            this.pnlLeftInside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftInside.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftInside.Name = "pnlLeftInside";
            this.pnlLeftInside.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlLeftInside.Size = new System.Drawing.Size(300, 713);
            this.pnlLeftInside.TabIndex = 6;
            // 
            // pnlLeftInsideBottom
            // 
            this.pnlLeftInsideBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftInsideBottom.Location = new System.Drawing.Point(5, 78);
            this.pnlLeftInsideBottom.Name = "pnlLeftInsideBottom";
            this.pnlLeftInsideBottom.Size = new System.Drawing.Size(290, 544);
            this.pnlLeftInsideBottom.TabIndex = 5;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.BorderColor = System.Drawing.Color.Black;
            this.txtSearchCustomer.BorderRadius = 6;
            this.txtSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomer.DefaultText = "";
            this.txtSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchCustomer.FillColor = System.Drawing.Color.LightGray;
            this.txtSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.IconLeft = global::insurance_tracking.Properties.Resources.search_interface_symbol;
            this.txtSearchCustomer.Location = new System.Drawing.Point(5, 42);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchCustomer.PlaceholderText = "Ara";
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.Size = new System.Drawing.Size(290, 36);
            this.txtSearchCustomer.TabIndex = 4;
            // 
            // lblPickCustomer
            // 
            this.lblPickCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPickCustomer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPickCustomer.Location = new System.Drawing.Point(5, 0);
            this.lblPickCustomer.Name = "lblPickCustomer";
            this.lblPickCustomer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPickCustomer.Size = new System.Drawing.Size(290, 42);
            this.lblPickCustomer.TabIndex = 3;
            this.lblPickCustomer.Text = "Müşteri Seç";
            this.lblPickCustomer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnNewInsure
            // 
            this.btnNewInsure.BorderRadius = 10;
            this.btnNewInsure.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewInsure.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewInsure.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewInsure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewInsure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewInsure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewInsure.ForeColor = System.Drawing.Color.White;
            this.btnNewInsure.Location = new System.Drawing.Point(5, 622);
            this.btnNewInsure.Name = "btnNewInsure";
            this.btnNewInsure.Size = new System.Drawing.Size(308, 45);
            this.btnNewInsure.TabIndex = 14;
            this.btnNewInsure.Text = "Yeni Oluştur";
            // 
            // FormInsure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 738);
            this.Controls.Add(this.pnlRightSearchBar);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInsure";
            this.Padding = new System.Windows.Forms.Padding(0, 25, 5, 0);
            this.Text = "Sigorta Yap";
            this.Load += new System.EventHandler(this.FormInsure_Load);
            this.pnlRightSearchBar.ResumeLayout(false);
            this.flpInsure.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlMid.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftInside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRightSearchBar;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftInside;
        private System.Windows.Forms.Panel pnlLeftInsideBottom;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomer;
        private System.Windows.Forms.Label lblPickCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Panel pnlInsuranceList;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAsset;
        private System.Windows.Forms.Label lblPickAsset;
        private System.Windows.Forms.FlowLayoutPanel flpInsure;
        private System.Windows.Forms.Label lblInsureType;
        private Guna.UI2.WinForms.Guna2ComboBox cbInsuranceType;
        private System.Windows.Forms.Panel pnlName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtIdentityNumber;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox txtDocumentNo;
        private System.Windows.Forms.Label lblDocumentNo;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox txtSerialNo;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox txtInsuranceAmount;
        private System.Windows.Forms.Label lblInsuranceAmount;
        private Guna.UI2.WinForms.Guna2Button btnInsure;
        private Guna.UI2.WinForms.Guna2Button btnNewInsure;
    }
}