namespace insurance_tracking.Cards
{
    partial class InsureCard
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlate = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblInsureType = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnPickInsure = new Guna.UI2.WinForms.Guna2Button();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlate
            // 
            this.lblPlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlate.Location = new System.Drawing.Point(5, 35);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(193, 30);
            this.lblPlate.TabIndex = 1;
            this.lblPlate.Text = "label2";
            this.lblPlate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblIsActive);
            this.pnlLeft.Controls.Add(this.lblAddress);
            this.pnlLeft.Controls.Add(this.lblPlate);
            this.pnlLeft.Controls.Add(this.lblInsureType);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLeft.Size = new System.Drawing.Size(203, 118);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(5, 65);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(193, 23);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "label3";
            // 
            // lblInsureType
            // 
            this.lblInsureType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInsureType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInsureType.Location = new System.Drawing.Point(5, 5);
            this.lblInsureType.Name = "lblInsureType";
            this.lblInsureType.Size = new System.Drawing.Size(193, 30);
            this.lblInsureType.TabIndex = 0;
            this.lblInsureType.Text = "lblInsureType";
            this.lblInsureType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.btnPickInsure);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(203, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.pnlRight.Size = new System.Drawing.Size(97, 118);
            this.pnlRight.TabIndex = 2;
            // 
            // btnPickInsure
            // 
            this.btnPickInsure.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPickInsure.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPickInsure.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPickInsure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPickInsure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPickInsure.FillColor = System.Drawing.Color.Red;
            this.btnPickInsure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPickInsure.ForeColor = System.Drawing.Color.White;
            this.btnPickInsure.Location = new System.Drawing.Point(10, 20);
            this.btnPickInsure.Name = "btnPickInsure";
            this.btnPickInsure.Size = new System.Drawing.Size(77, 78);
            this.btnPickInsure.TabIndex = 0;
            this.btnPickInsure.Text = "seç";
            this.btnPickInsure.Click += new System.EventHandler(this.btnPickInsure_Click);
            // 
            // lblIsActive
            // 
            this.lblIsActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIsActive.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsActive.Location = new System.Drawing.Point(5, 88);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(193, 23);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "label3";
            // 
            // InsureCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "InsureCard";
            this.Size = new System.Drawing.Size(300, 118);
            this.Load += new System.EventHandler(this.InsureCard_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblInsureType;
        private System.Windows.Forms.Panel pnlRight;
        private Guna.UI2.WinForms.Guna2Button btnPickInsure;
        private System.Windows.Forms.Label lblIsActive;
    }
}
