namespace insurance_tracking.Forms
{
    partial class FormAddOffer
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
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblOfferType = new System.Windows.Forms.Label();
            this.pnlMidFill = new System.Windows.Forms.Panel();
            this.pnlMidLeft = new System.Windows.Forms.Panel();
            this.cbInsureType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flpDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumentNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerialNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsureAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReferanceCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUavtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCreateOffer = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFill.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlMidFill.SuspendLayout();
            this.pnlMidLeft.SuspendLayout();
            this.flpDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.pnlFill.Controls.Add(this.pnlMidFill);
            this.pnlFill.Controls.Add(this.pnlTop);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(847, 547);
            this.pnlFill.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblOfferType);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(847, 94);
            this.pnlTop.TabIndex = 0;
            // 
            // lblOfferType
            // 
            this.lblOfferType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOfferType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOfferType.Location = new System.Drawing.Point(0, 48);
            this.lblOfferType.Name = "lblOfferType";
            this.lblOfferType.Size = new System.Drawing.Size(847, 46);
            this.lblOfferType.TabIndex = 1;
            this.lblOfferType.Text = "Teklif Tipi";
            this.lblOfferType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMidFill
            // 
            this.pnlMidFill.Controls.Add(this.panel1);
            this.pnlMidFill.Controls.Add(this.pnlMidLeft);
            this.pnlMidFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMidFill.Location = new System.Drawing.Point(0, 94);
            this.pnlMidFill.Name = "pnlMidFill";
            this.pnlMidFill.Size = new System.Drawing.Size(847, 453);
            this.pnlMidFill.TabIndex = 1;
            // 
            // pnlMidLeft
            // 
            this.pnlMidLeft.Controls.Add(this.flpDetail);
            this.pnlMidLeft.Controls.Add(this.cbInsureType);
            this.pnlMidLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMidLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMidLeft.Name = "pnlMidLeft";
            this.pnlMidLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMidLeft.Size = new System.Drawing.Size(319, 453);
            this.pnlMidLeft.TabIndex = 0;
            // 
            // cbInsureType
            // 
            this.cbInsureType.BackColor = System.Drawing.Color.Transparent;
            this.cbInsureType.BorderRadius = 6;
            this.cbInsureType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbInsureType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInsureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsureType.FillColor = System.Drawing.Color.Gainsboro;
            this.cbInsureType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInsureType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbInsureType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbInsureType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbInsureType.ItemHeight = 30;
            this.cbInsureType.Items.AddRange(new object[] {
            "Trafik",
            "Kasko",
            "Konut",
            "Dask",
            "Tamamlayıcı Sağlık Sigortası (tss)",
            "Bireysel Emeklilik (bes)"});
            this.cbInsureType.Location = new System.Drawing.Point(10, 10);
            this.cbInsureType.Name = "cbInsureType";
            this.cbInsureType.Size = new System.Drawing.Size(299, 36);
            this.cbInsureType.TabIndex = 0;
            // 
            // flpDetail
            // 
            this.flpDetail.Controls.Add(this.lblCustomerName);
            this.flpDetail.Controls.Add(this.txtName);
            this.flpDetail.Controls.Add(this.label1);
            this.flpDetail.Controls.Add(this.txtAddress);
            this.flpDetail.Controls.Add(this.label2);
            this.flpDetail.Controls.Add(this.txtDocumentNo);
            this.flpDetail.Controls.Add(this.label3);
            this.flpDetail.Controls.Add(this.txtSerialNo);
            this.flpDetail.Controls.Add(this.label4);
            this.flpDetail.Controls.Add(this.txtInsureAmount);
            this.flpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDetail.Location = new System.Drawing.Point(10, 46);
            this.flpDetail.Name = "flpDetail";
            this.flpDetail.Size = new System.Drawing.Size(299, 397);
            this.flpDetail.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomerName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerName.Location = new System.Drawing.Point(3, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(293, 37);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Müşteri Adı: ";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 6;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.FillColor = System.Drawing.Color.Gainsboro;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(3, 40);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(293, 36);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adres:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.txtAddress.FillColor = System.Drawing.Color.Gainsboro;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(3, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(293, 36);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Belge Numarası:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.txtDocumentNo.FillColor = System.Drawing.Color.Gainsboro;
            this.txtDocumentNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumentNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocumentNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumentNo.Location = new System.Drawing.Point(3, 198);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.PasswordChar = '\0';
            this.txtDocumentNo.PlaceholderText = "";
            this.txtDocumentNo.SelectedText = "";
            this.txtDocumentNo.Size = new System.Drawing.Size(293, 36);
            this.txtDocumentNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seri No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.txtSerialNo.FillColor = System.Drawing.Color.Gainsboro;
            this.txtSerialNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerialNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSerialNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerialNo.Location = new System.Drawing.Point(3, 277);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.PasswordChar = '\0';
            this.txtSerialNo.PlaceholderText = "";
            this.txtSerialNo.SelectedText = "";
            this.txtSerialNo.Size = new System.Drawing.Size(293, 36);
            this.txtSerialNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Poliçe Ücreti:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtInsureAmount
            // 
            this.txtInsureAmount.BorderRadius = 6;
            this.txtInsureAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInsureAmount.DefaultText = "";
            this.txtInsureAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInsureAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInsureAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInsureAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInsureAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInsureAmount.FillColor = System.Drawing.Color.Gainsboro;
            this.txtInsureAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInsureAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInsureAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInsureAmount.Location = new System.Drawing.Point(3, 356);
            this.txtInsureAmount.Name = "txtInsureAmount";
            this.txtInsureAmount.PasswordChar = '\0';
            this.txtInsureAmount.PlaceholderText = "";
            this.txtInsureAmount.SelectedText = "";
            this.txtInsureAmount.Size = new System.Drawing.Size(293, 36);
            this.txtInsureAmount.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(319, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(319, 453);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txtPlate);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txtReferanceCode);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.txtUavtCode);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.dtpIssueDate);
            this.flowLayoutPanel1.Controls.Add(this.btnCreateOffer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(299, 433);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 73);
            this.label5.TabIndex = 0;
            this.label5.Text = "Plaka:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPlate
            // 
            this.txtPlate.BorderRadius = 6;
            this.txtPlate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlate.DefaultText = "";
            this.txtPlate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPlate.FillColor = System.Drawing.Color.Gainsboro;
            this.txtPlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlate.Location = new System.Drawing.Point(3, 76);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.PasswordChar = '\0';
            this.txtPlate.PlaceholderText = "";
            this.txtPlate.SelectedText = "";
            this.txtPlate.Size = new System.Drawing.Size(293, 36);
            this.txtPlate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(3, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Referans Kodu:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtReferanceCode
            // 
            this.txtReferanceCode.BorderRadius = 6;
            this.txtReferanceCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReferanceCode.DefaultText = "";
            this.txtReferanceCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReferanceCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReferanceCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReferanceCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReferanceCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReferanceCode.FillColor = System.Drawing.Color.Gainsboro;
            this.txtReferanceCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReferanceCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReferanceCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReferanceCode.Location = new System.Drawing.Point(3, 155);
            this.txtReferanceCode.Name = "txtReferanceCode";
            this.txtReferanceCode.PasswordChar = '\0';
            this.txtReferanceCode.PlaceholderText = "";
            this.txtReferanceCode.SelectedText = "";
            this.txtReferanceCode.Size = new System.Drawing.Size(293, 36);
            this.txtReferanceCode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(3, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 37);
            this.label7.TabIndex = 4;
            this.label7.Text = "Uavt Kodu:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtUavtCode
            // 
            this.txtUavtCode.BorderRadius = 6;
            this.txtUavtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUavtCode.DefaultText = "";
            this.txtUavtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUavtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUavtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUavtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUavtCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUavtCode.FillColor = System.Drawing.Color.Gainsboro;
            this.txtUavtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUavtCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUavtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUavtCode.Location = new System.Drawing.Point(3, 234);
            this.txtUavtCode.Name = "txtUavtCode";
            this.txtUavtCode.PasswordChar = '\0';
            this.txtUavtCode.PlaceholderText = "";
            this.txtUavtCode.SelectedText = "";
            this.txtUavtCode.Size = new System.Drawing.Size(293, 36);
            this.txtUavtCode.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(3, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 37);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tanzim Tarihi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Checked = true;
            this.dtpIssueDate.FillColor = System.Drawing.Color.Gainsboro;
            this.dtpIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpIssueDate.Location = new System.Drawing.Point(3, 313);
            this.dtpIssueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpIssueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(293, 36);
            this.dtpIssueDate.TabIndex = 7;
            this.dtpIssueDate.Value = new System.DateTime(2024, 7, 10, 20, 41, 54, 632);
            // 
            // btnCreateOffer
            // 
            this.btnCreateOffer.BorderRadius = 6;
            this.btnCreateOffer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateOffer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateOffer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateOffer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateOffer.FillColor = System.Drawing.Color.Red;
            this.btnCreateOffer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateOffer.ForeColor = System.Drawing.Color.White;
            this.btnCreateOffer.Location = new System.Drawing.Point(3, 355);
            this.btnCreateOffer.Name = "btnCreateOffer";
            this.btnCreateOffer.Size = new System.Drawing.Size(293, 45);
            this.btnCreateOffer.TabIndex = 8;
            this.btnCreateOffer.Text = "Teklifi Oluştur";
            this.btnCreateOffer.Click += new System.EventHandler(this.btnCreateOffer_Click);
            // 
            // FormAddOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 547);
            this.Controls.Add(this.pnlFill);
            this.Name = "FormAddOffer";
            this.Text = "Yeni Teklif Ekle";
            this.pnlFill.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlMidFill.ResumeLayout(false);
            this.pnlMidLeft.ResumeLayout(false);
            this.flpDetail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMidFill;
        private System.Windows.Forms.Panel pnlMidLeft;
        private System.Windows.Forms.Label lblOfferType;
        private Guna.UI2.WinForms.Guna2ComboBox cbInsureType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPlate;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtReferanceCode;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtUavtCode;
        private System.Windows.Forms.FlowLayoutPanel flpDetail;
        private System.Windows.Forms.Label lblCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtDocumentNo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSerialNo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtInsureAmount;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpIssueDate;
        private Guna.UI2.WinForms.Guna2Button btnCreateOffer;
    }
}