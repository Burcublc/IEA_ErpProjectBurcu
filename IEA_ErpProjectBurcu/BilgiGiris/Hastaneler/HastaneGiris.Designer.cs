namespace IEA_ErpProjectBurcu.BilgiGiris.Hastaneler
{
    partial class HastaneGiris
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
            this.ScMenu = new System.Windows.Forms.SplitContainer();
            this.btnDetayEkle = new System.Windows.Forms.Button();
            this.btnDetayGoster = new System.Windows.Forms.Button();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.TxtVergino = new System.Windows.Forms.MaskedTextBox();
            this.TxtVergidairesi = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.cmbHastaneTipi = new System.Windows.Forms.ComboBox();
            this.TxtCariadi = new System.Windows.Forms.TextBox();
            this.TxtHastaneadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaneAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaneTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScMenu)).BeginInit();
            this.ScMenu.Panel1.SuspendLayout();
            this.ScMenu.Panel2.SuspendLayout();
            this.ScMenu.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(800, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastane Bilgi Girişi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScMenu
            // 
            this.ScMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScMenu.Location = new System.Drawing.Point(0, 48);
            this.ScMenu.Name = "ScMenu";
            this.ScMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScMenu.Panel1
            // 
            this.ScMenu.Panel1.Controls.Add(this.btnDetayEkle);
            this.ScMenu.Panel1.Controls.Add(this.btnDetayGoster);
            this.ScMenu.Panel1.Controls.Add(this.TxtUrunId);
            this.ScMenu.Panel1.Controls.Add(this.TxtVergino);
            this.ScMenu.Panel1.Controls.Add(this.TxtVergidairesi);
            this.ScMenu.Panel1.Controls.Add(this.TxtTel);
            this.ScMenu.Panel1.Controls.Add(this.TxtAdres);
            this.ScMenu.Panel1.Controls.Add(this.cmbSehir);
            this.ScMenu.Panel1.Controls.Add(this.cmbHastaneTipi);
            this.ScMenu.Panel1.Controls.Add(this.TxtCariadi);
            this.ScMenu.Panel1.Controls.Add(this.TxtHastaneadi);
            this.ScMenu.Panel1.Controls.Add(this.label9);
            this.ScMenu.Panel1.Controls.Add(this.label5);
            this.ScMenu.Panel1.Controls.Add(this.label8);
            this.ScMenu.Panel1.Controls.Add(this.label3);
            this.ScMenu.Panel1.Controls.Add(this.label7);
            this.ScMenu.Panel1.Controls.Add(this.label4);
            this.ScMenu.Panel1.Controls.Add(this.label6);
            this.ScMenu.Panel1.Controls.Add(this.label2);
            // 
            // ScMenu.Panel2
            // 
            this.ScMenu.Panel2.Controls.Add(this.Liste);
            this.ScMenu.Size = new System.Drawing.Size(800, 412);
            this.ScMenu.SplitterDistance = 209;
            this.ScMenu.TabIndex = 2;
            // 
            // btnDetayEkle
            // 
            this.btnDetayEkle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDetayEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetayEkle.Location = new System.Drawing.Point(713, 159);
            this.btnDetayEkle.Name = "btnDetayEkle";
            this.btnDetayEkle.Size = new System.Drawing.Size(75, 40);
            this.btnDetayEkle.TabIndex = 8;
            this.btnDetayEkle.Text = "Detay Ekle";
            this.btnDetayEkle.UseVisualStyleBackColor = false;
            this.btnDetayEkle.Click += new System.EventHandler(this.btnDetayEkle_Click);
            // 
            // btnDetayGoster
            // 
            this.btnDetayGoster.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDetayGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetayGoster.Location = new System.Drawing.Point(713, 106);
            this.btnDetayGoster.Name = "btnDetayGoster";
            this.btnDetayGoster.Size = new System.Drawing.Size(75, 40);
            this.btnDetayGoster.TabIndex = 8;
            this.btnDetayGoster.Text = "Detay Göster";
            this.btnDetayGoster.UseVisualStyleBackColor = false;
            this.btnDetayGoster.Click += new System.EventHandler(this.btnDetayGoster_Click);
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(432, 19);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(261, 20);
            this.TxtUrunId.TabIndex = 7;
            // 
            // TxtVergino
            // 
            this.TxtVergino.Location = new System.Drawing.Point(545, 90);
            this.TxtVergino.Mask = "00000000000";
            this.TxtVergino.Name = "TxtVergino";
            this.TxtVergino.Size = new System.Drawing.Size(127, 20);
            this.TxtVergino.TabIndex = 6;
            // 
            // TxtVergidairesi
            // 
            this.TxtVergidairesi.Location = new System.Drawing.Point(545, 58);
            this.TxtVergidairesi.Name = "TxtVergidairesi";
            this.TxtVergidairesi.Size = new System.Drawing.Size(127, 20);
            this.TxtVergidairesi.TabIndex = 5;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(545, 162);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(127, 20);
            this.TxtTel.TabIndex = 4;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(145, 125);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(260, 69);
            this.TxtAdres.TabIndex = 3;
            this.TxtAdres.Text = "";
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(545, 124);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(127, 21);
            this.cmbSehir.TabIndex = 2;
            // 
            // cmbHastaneTipi
            // 
            this.cmbHastaneTipi.FormattingEnabled = true;
            this.cmbHastaneTipi.Location = new System.Drawing.Point(145, 89);
            this.cmbHastaneTipi.Name = "cmbHastaneTipi";
            this.cmbHastaneTipi.Size = new System.Drawing.Size(260, 21);
            this.cmbHastaneTipi.TabIndex = 2;
            // 
            // TxtCariadi
            // 
            this.TxtCariadi.Location = new System.Drawing.Point(145, 57);
            this.TxtCariadi.Name = "TxtCariadi";
            this.TxtCariadi.Size = new System.Drawing.Size(260, 20);
            this.TxtCariadi.TabIndex = 1;
            // 
            // TxtHastaneadi
            // 
            this.TxtHastaneadi.Location = new System.Drawing.Point(145, 19);
            this.TxtHastaneadi.Name = "TxtHastaneadi";
            this.TxtHastaneadi.Size = new System.Drawing.Size(260, 20);
            this.TxtHastaneadi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(429, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefon :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(26, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(429, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vergi No :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(28, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cari Adı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(429, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şehir :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(26, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hastane Tipi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(429, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vergi Dairesi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hastane Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.HastaneAdi,
            this.HastaneTipi,
            this.Sehir,
            this.Tel});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(800, 199);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sıra";
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
            // HastaneAdi
            // 
            this.HastaneAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HastaneAdi.HeaderText = "Hastane Adı";
            this.HastaneAdi.Name = "HastaneAdi";
            // 
            // HastaneTipi
            // 
            this.HastaneTipi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HastaneTipi.HeaderText = "HastaneTipi";
            this.HastaneTipi.Name = "HastaneTipi";
            this.HastaneTipi.Width = 89;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Sehir";
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 56;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.Name = "Tel";
            this.Tel.Width = 68;
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.exit_64;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(722, 7);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(50, 36);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.temizleicon;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(211, 7);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(50, 36);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(145, 7);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(50, 36);
            this.btnSil.TabIndex = 1;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(78, 7);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(50, 36);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.Save_icon64x64;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(12, 8);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(50, 36);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // HastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.ScMenu);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Name = "HastaneGiris";
            this.Text = "Hastane Bilgi Girişi";
            this.Load += new System.EventHandler(this.HastaneGiris_Load);
            this.ScMenu.Panel1.ResumeLayout(false);
            this.ScMenu.Panel1.PerformLayout();
            this.ScMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScMenu)).EndInit();
            this.ScMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.SplitContainer ScMenu;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaneAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaneTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.Button btnDetayGoster;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.MaskedTextBox TxtVergino;
        private System.Windows.Forms.TextBox TxtVergidairesi;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.ComboBox cmbHastaneTipi;
        private System.Windows.Forms.TextBox TxtCariadi;
        private System.Windows.Forms.TextBox TxtHastaneadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetayEkle;
    }
}