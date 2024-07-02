namespace insurance_tracking.Forms
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLeftInside = new System.Windows.Forms.Panel();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTopMid = new System.Windows.Forms.Panel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.pnlTopLeftInsideRight = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooterVersion = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlTopTop = new System.Windows.Forms.Panel();
            this.pnlTopBottom = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnInsure = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsuranceTrack = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerList = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftInside.SuspendLayout();
            this.pnlLeftTop.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.pnlTopLeftInsideRight.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlTopTop.SuspendLayout();
            this.pnlTopBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlLeftInside);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(15);
            this.pnlLeft.Size = new System.Drawing.Size(255, 756);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlLeftInside
            // 
            this.pnlLeftInside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.pnlLeftInside.Controls.Add(this.btnInsure);
            this.pnlLeftInside.Controls.Add(this.btnInsuranceTrack);
            this.pnlLeftInside.Controls.Add(this.btnCustomerEdit);
            this.pnlLeftInside.Controls.Add(this.btnCustomerList);
            this.pnlLeftInside.Controls.Add(this.btnHome);
            this.pnlLeftInside.Controls.Add(this.pnlLeftTop);
            this.pnlLeftInside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftInside.Location = new System.Drawing.Point(15, 15);
            this.pnlLeftInside.Name = "pnlLeftInside";
            this.pnlLeftInside.Size = new System.Drawing.Size(225, 726);
            this.pnlLeftInside.TabIndex = 1;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.pictureBox1);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(225, 139);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.pnlLeftInside;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.pnlTop.Controls.Add(this.pnlTopMid);
            this.pnlTop.Controls.Add(this.pnlTopLeft);
            this.pnlTop.Controls.Add(this.pnlTopRight);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 15);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1032, 44);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pnlTopMid
            // 
            this.pnlTopMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopMid.Location = new System.Drawing.Point(205, 0);
            this.pnlTopMid.Name = "pnlTopMid";
            this.pnlTopMid.Size = new System.Drawing.Size(705, 44);
            this.pnlTopMid.TabIndex = 0;
            this.pnlTopMid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopMid_MouseDown);
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.pnlTopLeftInsideRight);
            this.pnlTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(205, 44);
            this.pnlTopLeft.TabIndex = 2;
            // 
            // pnlTopLeftInsideRight
            // 
            this.pnlTopLeftInsideRight.Controls.Add(this.lblCompany);
            this.pnlTopLeftInsideRight.Controls.Add(this.lblName);
            this.pnlTopLeftInsideRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopLeftInsideRight.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLeftInsideRight.Name = "pnlTopLeftInsideRight";
            this.pnlTopLeftInsideRight.Size = new System.Drawing.Size(205, 44);
            this.pnlTopLeftInsideRight.TabIndex = 3;
            // 
            // lblCompany
            // 
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompany.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCompany.Location = new System.Drawing.Point(0, 24);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(205, 20);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "İDS Grup Sigorta ";
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(205, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Kürşat Arslan";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.btnMinimize);
            this.pnlTopRight.Controls.Add(this.btnMaximize);
            this.pnlTopRight.Controls.Add(this.btnExit);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopRight.Location = new System.Drawing.Point(910, 0);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTopRight.Size = new System.Drawing.Size(122, 44);
            this.pnlTopRight.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.Peru;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(28, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.Size = new System.Drawing.Size(28, 24);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FillColor = System.Drawing.Color.Green;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(56, 10);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMaximize.Size = new System.Drawing.Size(28, 24);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(84, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(28, 24);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMid
            // 
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(255, 59);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(1037, 697);
            this.pnlMid.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblFooterVersion);
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(255, 716);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1037, 40);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblFooterVersion
            // 
            this.lblFooterVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFooterVersion.Location = new System.Drawing.Point(1003, 0);
            this.lblFooterVersion.Name = "lblFooterVersion";
            this.lblFooterVersion.Size = new System.Drawing.Size(34, 40);
            this.lblFooterVersion.TabIndex = 1;
            this.lblFooterVersion.Text = "v1.0";
            this.lblFooterVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFooter.Location = new System.Drawing.Point(0, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(140, 40);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "NK Yazılım © 2024";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTopTop
            // 
            this.pnlTopTop.Controls.Add(this.pnlTop);
            this.pnlTopTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTop.Location = new System.Drawing.Point(255, 0);
            this.pnlTopTop.Name = "pnlTopTop";
            this.pnlTopTop.Padding = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.pnlTopTop.Size = new System.Drawing.Size(1037, 59);
            this.pnlTopTop.TabIndex = 5;
            // 
            // pnlTopBottom
            // 
            this.pnlTopBottom.Controls.Add(this.btnCloseChildForm);
            this.pnlTopBottom.Controls.Add(this.lblTitle);
            this.pnlTopBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBottom.Location = new System.Drawing.Point(255, 59);
            this.pnlTopBottom.Name = "pnlTopBottom";
            this.pnlTopBottom.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTopBottom.Size = new System.Drawing.Size(1037, 40);
            this.pnlTopBottom.TabIndex = 6;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseChildForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseChildForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseChildForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.Location = new System.Drawing.Point(884, 5);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(148, 30);
            this.btnCloseChildForm.TabIndex = 6;
            this.btnCloseChildForm.Text = "Kapat";
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(5, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(514, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Ana Sayfa";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.pnlTop;
            // 
            // btnInsure
            // 
            this.btnInsure.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsure.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsure.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsure.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.btnInsure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsure.ForeColor = System.Drawing.Color.Black;
            this.btnInsure.Image = global::insurance_tracking.Properties.Resources.insurance;
            this.btnInsure.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInsure.Location = new System.Drawing.Point(0, 339);
            this.btnInsure.Name = "btnInsure";
            this.btnInsure.Size = new System.Drawing.Size(225, 50);
            this.btnInsure.TabIndex = 4;
            this.btnInsure.Text = "Sigorta Yap";
            this.btnInsure.Click += new System.EventHandler(this.btnInsure_Click);
            // 
            // btnInsuranceTrack
            // 
            this.btnInsuranceTrack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsuranceTrack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsuranceTrack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsuranceTrack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsuranceTrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsuranceTrack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.btnInsuranceTrack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsuranceTrack.ForeColor = System.Drawing.Color.Black;
            this.btnInsuranceTrack.Image = global::insurance_tracking.Properties.Resources.life_insurance;
            this.btnInsuranceTrack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInsuranceTrack.Location = new System.Drawing.Point(0, 289);
            this.btnInsuranceTrack.Name = "btnInsuranceTrack";
            this.btnInsuranceTrack.Size = new System.Drawing.Size(225, 50);
            this.btnInsuranceTrack.TabIndex = 3;
            this.btnInsuranceTrack.Text = "Sigorta Takip";
            this.btnInsuranceTrack.Click += new System.EventHandler(this.btnInsuranceTrack_Click);
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.btnCustomerEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCustomerEdit.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerEdit.Image = global::insurance_tracking.Properties.Resources.edit;
            this.btnCustomerEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerEdit.Location = new System.Drawing.Point(0, 239);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(225, 50);
            this.btnCustomerEdit.TabIndex = 2;
            this.btnCustomerEdit.Text = "Müşteri Ekle/Düzenle";
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.btnCustomerList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCustomerList.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerList.Image = global::insurance_tracking.Properties.Resources.people;
            this.btnCustomerList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerList.Location = new System.Drawing.Point(0, 189);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(225, 50);
            this.btnCustomerList.TabIndex = 1;
            this.btnCustomerList.Text = "Müşteri Listesi";
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::insurance_tracking.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 139);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(225, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::insurance_tracking.Properties.Resources.N_interface;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1292, 756);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTopBottom);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.pnlTopTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftInside.ResumeLayout(false);
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopLeftInsideRight.ResumeLayout(false);
            this.pnlTopRight.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlTopTop.ResumeLayout(false);
            this.pnlTopBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftInside;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.Panel pnlTopLeftInsideRight;
        private System.Windows.Forms.Panel pnlTopRight;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnMaximize;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Panel pnlLeftTop;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnCustomerEdit;
        private Guna.UI2.WinForms.Guna2Button btnCustomerList;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooterVersion;
        private System.Windows.Forms.Label lblFooter;
        private Guna.UI2.WinForms.Guna2Button btnInsuranceTrack;
        private System.Windows.Forms.Panel pnlTopMid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTopTop;
        private System.Windows.Forms.Panel pnlTopBottom;
        private Guna.UI2.WinForms.Guna2Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnInsure;
    }
}