namespace IEA_ErpProjectBurcu.BilgiGiris.Hastaneler
{
    partial class HastaneDetayEkle
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
            this.LblId = new System.Windows.Forms.Label();
            this.LblHastaneAdi = new System.Windows.Forms.Label();
            this.TxtYetkili = new System.Windows.Forms.TextBox();
            this.CmbDepartman = new System.Windows.Forms.ComboBox();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(932, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastane Detayları";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblId
            // 
            this.LblId.BackColor = System.Drawing.Color.RosyBrown;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(83, 91);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(47, 38);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "****";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHastaneAdi
            // 
            this.LblHastaneAdi.BackColor = System.Drawing.Color.RosyBrown;
            this.LblHastaneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHastaneAdi.Location = new System.Drawing.Point(167, 91);
            this.LblHastaneAdi.Name = "LblHastaneAdi";
            this.LblHastaneAdi.Size = new System.Drawing.Size(574, 38);
            this.LblHastaneAdi.TabIndex = 2;
            this.LblHastaneAdi.Text = "****";
            this.LblHastaneAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(5, 163);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(152, 20);
            this.TxtYetkili.TabIndex = 3;
            // 
            // CmbDepartman
            // 
            this.CmbDepartman.FormattingEnabled = true;
            this.CmbDepartman.Location = new System.Drawing.Point(170, 163);
            this.CmbDepartman.Name = "CmbDepartman";
            this.CmbDepartman.Size = new System.Drawing.Size(152, 21);
            this.CmbDepartman.TabIndex = 4;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(338, 164);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(152, 20);
            this.TxtTel.TabIndex = 5;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(505, 164);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(152, 20);
            this.TxtGsm.TabIndex = 5;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(673, 164);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(152, 20);
            this.TxtEmail.TabIndex = 3;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnEkle.Location = new System.Drawing.Point(853, 155);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(67, 31);
            this.BtnEkle.TabIndex = 6;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.GirisId,
            this.GirisAdi,
            this.Yetkili,
            this.Departman,
            this.Tel,
            this.Gsm,
            this.Email});
            this.Liste.Location = new System.Drawing.Point(26, 230);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(869, 181);
            this.Liste.TabIndex = 7;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnKaydet.Location = new System.Drawing.Point(820, 417);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 42);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // GirisId
            // 
            this.GirisId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisId.HeaderText = "Giriş Id";
            this.GirisId.Name = "GirisId";
            this.GirisId.Width = 64;
            // 
            // GirisAdi
            // 
            this.GirisAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisAdi.HeaderText = "Giriş Adı";
            this.GirisAdi.Name = "GirisAdi";
            this.GirisAdi.Width = 70;
            // 
            // Yetkili
            // 
            this.Yetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yetkili.HeaderText = "Yetkili";
            this.Yetkili.Name = "Yetkili";
            // 
            // Departman
            // 
            this.Departman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Departman.HeaderText = "Departman";
            this.Departman.Name = "Departman";
            this.Departman.Width = 84;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.Name = "Tel";
            this.Tel.Width = 68;
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
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // HastaneDetayEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 471);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtGsm);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.CmbDepartman);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtYetkili);
            this.Controls.Add(this.LblHastaneAdi);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.label1);
            this.Name = "HastaneDetayEkle";
            this.Text = "HastaneDetayEkle";
            this.Load += new System.EventHandler(this.HastaneDetayEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblHastaneAdi;
        private System.Windows.Forms.TextBox TxtYetkili;
        private System.Windows.Forms.ComboBox CmbDepartman;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}