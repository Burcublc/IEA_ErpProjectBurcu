namespace IEA_ErpProjectBurcu.BilgiGiris.Firmalar
{
    partial class FirmaDetayEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblFirmaId = new System.Windows.Forms.Label();
            this.LblFirmaAdi = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.TxtYetkiliAdi = new System.Windows.Forms.TextBox();
            this.CmbDepartmanAdi = new System.Windows.Forms.ComboBox();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnDetayEkle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiliAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmanAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(881, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Detay Ekle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFirmaId
            // 
            this.LblFirmaId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblFirmaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirmaId.Location = new System.Drawing.Point(103, 114);
            this.LblFirmaId.Name = "LblFirmaId";
            this.LblFirmaId.Size = new System.Drawing.Size(56, 35);
            this.LblFirmaId.TabIndex = 1;
            this.LblFirmaId.Text = "****";
            this.LblFirmaId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFirmaAdi
            // 
            this.LblFirmaAdi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirmaAdi.Location = new System.Drawing.Point(210, 114);
            this.LblFirmaAdi.Name = "LblFirmaAdi";
            this.LblFirmaAdi.Size = new System.Drawing.Size(521, 35);
            this.LblFirmaAdi.TabIndex = 2;
            this.LblFirmaAdi.Text = "****";
            this.LblFirmaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.GirisId,
            this.YetkiliAdi,
            this.DepartmanAdi,
            this.Tel,
            this.Gsm,
            this.Email});
            this.Liste.Location = new System.Drawing.Point(51, 221);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(778, 214);
            this.Liste.TabIndex = 3;
            // 
            // TxtYetkiliAdi
            // 
            this.TxtYetkiliAdi.Location = new System.Drawing.Point(12, 173);
            this.TxtYetkiliAdi.Name = "TxtYetkiliAdi";
            this.TxtYetkiliAdi.Size = new System.Drawing.Size(143, 20);
            this.TxtYetkiliAdi.TabIndex = 4;
            // 
            // CmbDepartmanAdi
            // 
            this.CmbDepartmanAdi.FormattingEnabled = true;
            this.CmbDepartmanAdi.Location = new System.Drawing.Point(161, 173);
            this.CmbDepartmanAdi.Name = "CmbDepartmanAdi";
            this.CmbDepartmanAdi.Size = new System.Drawing.Size(143, 21);
            this.CmbDepartmanAdi.TabIndex = 5;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(310, 173);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(143, 20);
            this.TxtTel.TabIndex = 6;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(459, 173);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(143, 20);
            this.TxtGsm.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(608, 173);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(143, 20);
            this.TxtEmail.TabIndex = 8;
            // 
            // BtnDetayEkle
            // 
            this.BtnDetayEkle.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnDetayEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetayEkle.Location = new System.Drawing.Point(777, 165);
            this.BtnDetayEkle.Name = "BtnDetayEkle";
            this.BtnDetayEkle.Size = new System.Drawing.Size(92, 29);
            this.BtnDetayEkle.TabIndex = 9;
            this.BtnDetayEkle.Text = "Ekle";
            this.BtnDetayEkle.UseVisualStyleBackColor = false;
            this.BtnDetayEkle.Click += new System.EventHandler(this.BtnDetayEkle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKaydet.Location = new System.Drawing.Point(754, 455);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 37);
            this.BtnKaydet.TabIndex = 10;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sıra";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // GirisId
            // 
            this.GirisId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisId.HeaderText = "Giris Id";
            this.GirisId.Name = "GirisId";
            this.GirisId.Width = 64;
            // 
            // YetkiliAdi
            // 
            this.YetkiliAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YetkiliAdi.HeaderText = "Yetkili Adı";
            this.YetkiliAdi.Name = "YetkiliAdi";
            // 
            // DepartmanAdi
            // 
            this.DepartmanAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DepartmanAdi.HeaderText = "Departman Adı";
            this.DepartmanAdi.Name = "DepartmanAdi";
            this.DepartmanAdi.Width = 102;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.Width = 47;
            // 
            // Gsm
            // 
            this.Gsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gsm.HeaderText = "Gsm";
            this.Gsm.Name = "Gsm";
            this.Gsm.Width = 53;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
            // 
            // FirmaDetayEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 504);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnDetayEkle);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtGsm);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.CmbDepartmanAdi);
            this.Controls.Add(this.TxtYetkiliAdi);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.LblFirmaAdi);
            this.Controls.Add(this.LblFirmaId);
            this.Controls.Add(this.label1);
            this.Name = "FirmaDetayEkle";
            this.Text = "FirmaDetayEkle";
            this.Load += new System.EventHandler(this.FirmaDetayEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFirmaId;
        private System.Windows.Forms.Label LblFirmaAdi;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.TextBox TxtYetkiliAdi;
        private System.Windows.Forms.ComboBox CmbDepartmanAdi;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnDetayEkle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiliAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmanAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}