namespace IEA_ErpProjectBurcu.BilgiGiris.Firmalar
{
    partial class FirmalarListesi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnFirmaBul = new System.Windows.Forms.Button();
            this.TxtFirmaAdi = new System.Windows.Forms.TextBox();
            this.LblFirmaAdi = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnFirmaBul);
            this.splitContainer1.Panel1.Controls.Add(this.TxtFirmaAdi);
            this.splitContainer1.Panel1.Controls.Add(this.LblFirmaAdi);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Liste);
            this.splitContainer1.Size = new System.Drawing.Size(880, 483);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnFirmaBul
            // 
            this.BtnFirmaBul.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.Ara32x323;
            this.BtnFirmaBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFirmaBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirmaBul.Location = new System.Drawing.Point(27, 401);
            this.BtnFirmaBul.Name = "BtnFirmaBul";
            this.BtnFirmaBul.Size = new System.Drawing.Size(155, 61);
            this.BtnFirmaBul.TabIndex = 2;
            this.BtnFirmaBul.Text = "Firma Ara";
            this.BtnFirmaBul.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFirmaBul.UseVisualStyleBackColor = true;
            // 
            // TxtFirmaAdi
            // 
            this.TxtFirmaAdi.Location = new System.Drawing.Point(15, 57);
            this.TxtFirmaAdi.Name = "TxtFirmaAdi";
            this.TxtFirmaAdi.Size = new System.Drawing.Size(181, 20);
            this.TxtFirmaAdi.TabIndex = 1;
            // 
            // LblFirmaAdi
            // 
            this.LblFirmaAdi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblFirmaAdi.Location = new System.Drawing.Point(12, 9);
            this.LblFirmaAdi.Name = "LblFirmaAdi";
            this.LblFirmaAdi.Size = new System.Drawing.Size(184, 35);
            this.LblFirmaAdi.TabIndex = 0;
            this.LblFirmaAdi.Text = "Firma Adı";
            this.LblFirmaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.Sehir,
            this.FirmaTip,
            this.Tel,
            this.Email});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(666, 483);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Adi";
            this.Adi.Name = "Adi";
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Sehir";
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 56;
            // 
            // FirmaTip
            // 
            this.FirmaTip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FirmaTip.HeaderText = "Firma Tipi";
            this.FirmaTip.Name = "FirmaTip";
            this.FirmaTip.Width = 77;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.Width = 47;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
            // 
            // FirmalarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 483);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FirmalarListesi";
            this.Text = "FirmalarListesi";
            this.Load += new System.EventHandler(this.FirmalarListesi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button BtnFirmaBul;
        private System.Windows.Forms.TextBox TxtFirmaAdi;
        private System.Windows.Forms.Label LblFirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}