namespace insurance_tracking.Forms
{
    partial class FormCustomerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlFillTop = new System.Windows.Forms.Panel();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlFill.SuspendLayout();
            this.pnlFillTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.pnlTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.guna2DataGridView1);
            this.pnlFill.Controls.Add(this.pnlFillTop);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(928, 593);
            this.pnlFill.TabIndex = 0;
            // 
            // pnlFillTop
            // 
            this.pnlFillTop.BackColor = System.Drawing.Color.White;
            this.pnlFillTop.Controls.Add(this.pnlTopRight);
            this.pnlFillTop.Controls.Add(this.lblCustomerCount);
            this.pnlFillTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFillTop.Location = new System.Drawing.Point(0, 0);
            this.pnlFillTop.Name = "pnlFillTop";
            this.pnlFillTop.Size = new System.Drawing.Size(928, 97);
            this.pnlFillTop.TabIndex = 0;
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
            this.lblCustomerCount.Text = "Müşteri Sayısı: 25";
            this.lblCustomerCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.guna2DataGridView1.ColumnHeadersHeight = 33;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerPhoto,
            this.CustomerName,
            this.CustomerLastName,
            this.CustomerPhoneNumber,
            this.CustomerMail,
            this.CustomerIdentity,
            this.CustomerBirthDate});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 97);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 38;
            this.guna2DataGridView1.Size = new System.Drawing.Size(928, 496);
            this.guna2DataGridView1.TabIndex = 1;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 33;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 38;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // CustomerPhoto
            // 
            this.CustomerPhoto.HeaderText = "";
            this.CustomerPhoto.Name = "CustomerPhoto";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Adı";
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.HeaderText = "Soyadı";
            this.CustomerLastName.Name = "CustomerLastName";
            // 
            // CustomerPhoneNumber
            // 
            this.CustomerPhoneNumber.HeaderText = "Telefon Numarası";
            this.CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            // 
            // CustomerMail
            // 
            this.CustomerMail.HeaderText = "Müşteri Mail Adresi";
            this.CustomerMail.Name = "CustomerMail";
            // 
            // CustomerIdentity
            // 
            this.CustomerIdentity.HeaderText = "T.C. Numarası";
            this.CustomerIdentity.Name = "CustomerIdentity";
            // 
            // CustomerBirthDate
            // 
            this.CustomerBirthDate.HeaderText = "Doğum Tarihi";
            this.CustomerBirthDate.Name = "CustomerBirthDate";
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.guna2TextBox1);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopRight.Location = new System.Drawing.Point(713, 0);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlTopRight.Size = new System.Drawing.Size(215, 97);
            this.pnlTopRight.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 6;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2TextBox1.FillColor = System.Drawing.Color.LightGray;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = global::insurance_tracking.Properties.Resources.search_interface_symbol;
            this.guna2TextBox1.Location = new System.Drawing.Point(0, 56);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Ara";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(210, 36);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 593);
            this.Controls.Add(this.pnlFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomerList";
            this.Text = "Müşteri Listesi";
            this.pnlFill.ResumeLayout(false);
            this.pnlFillTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.pnlTopRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlFillTop;
        private System.Windows.Forms.Label lblCustomerCount;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
        private System.Windows.Forms.DataGridViewImageColumn CustomerPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIdentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBirthDate;
        private System.Windows.Forms.Panel pnlTopRight;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}