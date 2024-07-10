namespace insurance_tracking.Forms
{
    partial class FormInsuranceTrack
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomerList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.InsuranceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsureAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferanceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UavtCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlFillTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFinishDay = new System.Windows.Forms.Label();
            this.cbDay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.pnlFill.SuspendLayout();
            this.pnlFillTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCustomerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCustomerList.ColumnHeadersHeight = 33;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InsuranceType,
            this.Address,
            this.DocumentNo,
            this.SerialNo,
            this.CreatedAt,
            this.EndDate,
            this.InsureAmount,
            this.IsActive,
            this.IssueDate,
            this.Plate,
            this.ReferanceCode,
            this.UavtCode,
            this.CustomerId,
            this.InsureId});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerList.Location = new System.Drawing.Point(0, 97);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowTemplate.Height = 38;
            this.dgvCustomerList.Size = new System.Drawing.Size(1185, 605);
            this.dgvCustomerList.TabIndex = 1;
            this.dgvCustomerList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.dgvCustomerList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvCustomerList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvCustomerList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            this.dgvCustomerList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.dgvCustomerList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvCustomerList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomerList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvCustomerList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomerList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomerList.ThemeStyle.HeaderStyle.Height = 33;
            this.dgvCustomerList.ThemeStyle.ReadOnly = false;
            this.dgvCustomerList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.dgvCustomerList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomerList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvCustomerList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerList.ThemeStyle.RowsStyle.Height = 38;
            this.dgvCustomerList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            this.dgvCustomerList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // InsuranceType
            // 
            this.InsuranceType.HeaderText = "Poliçe Tipi";
            this.InsuranceType.Name = "InsuranceType";
            // 
            // Address
            // 
            this.Address.HeaderText = "Adres";
            this.Address.Name = "Address";
            // 
            // DocumentNo
            // 
            this.DocumentNo.HeaderText = "Doküman Numarası";
            this.DocumentNo.Name = "DocumentNo";
            // 
            // SerialNo
            // 
            this.SerialNo.HeaderText = "Seri Numarası";
            this.SerialNo.Name = "SerialNo";
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "Oluşturma Tarihi";
            this.CreatedAt.Name = "CreatedAt";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Bitiş Tarihi";
            this.EndDate.Name = "EndDate";
            // 
            // InsureAmount
            // 
            this.InsureAmount.HeaderText = "Poliçe Ücreti";
            this.InsureAmount.Name = "InsureAmount";
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Aktif Mi";
            this.IsActive.Name = "IsActive";
            // 
            // IssueDate
            // 
            this.IssueDate.HeaderText = "Tanzim Tarihi";
            this.IssueDate.Name = "IssueDate";
            // 
            // Plate
            // 
            this.Plate.HeaderText = "Plaka";
            this.Plate.Name = "Plate";
            // 
            // ReferanceCode
            // 
            this.ReferanceCode.HeaderText = "Referans Kodu";
            this.ReferanceCode.Name = "ReferanceCode";
            // 
            // UavtCode
            // 
            this.UavtCode.HeaderText = "Uavt Kodu";
            this.UavtCode.Name = "UavtCode";
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "müşteri id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // InsureId
            // 
            this.InsureId.HeaderText = "Poliçe id";
            this.InsureId.Name = "InsureId";
            this.InsureId.Visible = false;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.dgvCustomerList);
            this.pnlFill.Controls.Add(this.pnlFillTop);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(1185, 702);
            this.pnlFill.TabIndex = 1;
            // 
            // pnlFillTop
            // 
            this.pnlFillTop.BackColor = System.Drawing.Color.White;
            this.pnlFillTop.Controls.Add(this.panel1);
            this.pnlFillTop.Controls.Add(this.pnlTopRight);
            this.pnlFillTop.Controls.Add(this.lblCustomerCount);
            this.pnlFillTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFillTop.Location = new System.Drawing.Point(0, 0);
            this.pnlFillTop.Name = "pnlFillTop";
            this.pnlFillTop.Size = new System.Drawing.Size(1185, 97);
            this.pnlFillTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFinishDay);
            this.panel1.Controls.Add(this.cbDay);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(138, 54);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 10, 2);
            this.panel1.Size = new System.Drawing.Size(832, 43);
            this.panel1.TabIndex = 4;
            // 
            // lblFinishDay
            // 
            this.lblFinishDay.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFinishDay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinishDay.Location = new System.Drawing.Point(80, 2);
            this.lblFinishDay.Name = "lblFinishDay";
            this.lblFinishDay.Size = new System.Drawing.Size(79, 39);
            this.lblFinishDay.TabIndex = 7;
            this.lblFinishDay.Text = "Gün Seç:";
            this.lblFinishDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDay
            // 
            this.cbDay.BackColor = System.Drawing.Color.Transparent;
            this.cbDay.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FillColor = System.Drawing.Color.Gainsboro;
            this.cbDay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDay.ItemHeight = 30;
            this.cbDay.Items.AddRange(new object[] {
            "Temizle",
            "1",
            "3",
            "5",
            "10",
            "20",
            "30"});
            this.cbDay.Location = new System.Drawing.Point(159, 2);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(179, 36);
            this.cbDay.TabIndex = 6;
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(338, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(42, 39);
            this.panel3.TabIndex = 5;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpStartDate.FillColor = System.Drawing.Color.IndianRed;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.ForeColor = System.Drawing.Color.White;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(380, 2);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 39);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.Value = new System.DateTime(2024, 7, 10, 17, 51, 41, 717);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(580, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 39);
            this.panel2.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpEndDate.FillColor = System.Drawing.Color.IndianRed;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.ForeColor = System.Drawing.Color.White;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(622, 2);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 39);
            this.dtpEndDate.TabIndex = 3;
            this.dtpEndDate.Value = new System.DateTime(2024, 7, 10, 17, 51, 41, 717);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.txtSearchBox);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopRight.Location = new System.Drawing.Point(970, 0);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlTopRight.Size = new System.Drawing.Size(215, 97);
            this.pnlTopRight.TabIndex = 1;
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
            this.txtSearchBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSearchBox.FillColor = System.Drawing.Color.LightGray;
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBox.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.IconLeft = global::insurance_tracking.Properties.Resources.search_interface_symbol;
            this.txtSearchBox.Location = new System.Drawing.Point(0, 56);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PasswordChar = '\0';
            this.txtSearchBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchBox.PlaceholderText = "Ara";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.Size = new System.Drawing.Size(210, 36);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCustomerCount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerCount.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblCustomerCount.Size = new System.Drawing.Size(138, 97);
            this.lblCustomerCount.TabIndex = 0;
            this.lblCustomerCount.Text = "Poliçe Sayısı: 0";
            this.lblCustomerCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FormInsuranceTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 702);
            this.Controls.Add(this.pnlFill);
            this.Name = "FormInsuranceTrack";
            this.Text = "Poliçe Takip";
            this.Load += new System.EventHandler(this.FormInsuranceTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFillTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlTopRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomerList;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlFillTop;
        private System.Windows.Forms.Panel pnlTopRight;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
        private System.Windows.Forms.Label lblCustomerCount;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFinishDay;
        private Guna.UI2.WinForms.Guna2ComboBox cbDay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsureAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferanceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UavtCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsureId;
    }
}