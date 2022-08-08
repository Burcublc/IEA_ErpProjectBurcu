namespace IEA_ErpProjectBurcu.BilgiGiris.Doktorlar
{
    partial class DoktorGiris
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
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.scMenu = new System.Windows.Forms.SplitContainer();
            this.TxtVergiDairesi = new System.Windows.Forms.TextBox();
            this.TxtMuayehane = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.TxtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.TxtVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.TxtDTarih = new System.Windows.Forms.DateTimePicker();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.CmbHastane3 = new System.Windows.Forms.ComboBox();
            this.CmbHastane2 = new System.Windows.Forms.ComboBox();
            this.CmbHastane1 = new System.Windows.Forms.ComboBox();
            this.CmbSehir = new System.Windows.Forms.ComboBox();
            this.CmbUnvan = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).BeginInit();
            this.scMenu.Panel1.SuspendLayout();
            this.scMenu.Panel2.SuspendLayout();
            this.scMenu.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1004, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.exit_641;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(930, 12);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(62, 36);
            this.BtnKapat.TabIndex = 1;
            this.BtnKapat.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.temizleicon1;
            this.BtnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTemizle.Location = new System.Drawing.Point(255, 12);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(62, 36);
            this.BtnTemizle.TabIndex = 1;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.cop24x241;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.Location = new System.Drawing.Point(177, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(62, 36);
            this.BtnSil.TabIndex = 1;
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.Update32x321;
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.Location = new System.Drawing.Point(100, 12);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(62, 36);
            this.BtnGuncelle.TabIndex = 1;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.Save_icon64x641;
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.Location = new System.Drawing.Point(23, 12);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(62, 36);
            this.BtnKaydet.TabIndex = 1;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // scMenu
            // 
            this.scMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenu.Location = new System.Drawing.Point(0, 59);
            this.scMenu.Name = "scMenu";
            this.scMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMenu.Panel1
            // 
            this.scMenu.Panel1.Controls.Add(this.TxtId);
            this.scMenu.Panel1.Controls.Add(this.TxtVergiDairesi);
            this.scMenu.Panel1.Controls.Add(this.TxtMuayehane);
            this.scMenu.Panel1.Controls.Add(this.TxtEmail);
            this.scMenu.Panel1.Controls.Add(this.TxtGsm);
            this.scMenu.Panel1.Controls.Add(this.TxtTel2);
            this.scMenu.Panel1.Controls.Add(this.TxtVergiNo);
            this.scMenu.Panel1.Controls.Add(this.TxtTel1);
            this.scMenu.Panel1.Controls.Add(this.TxtDTarih);
            this.scMenu.Panel1.Controls.Add(this.TxtAdi);
            this.scMenu.Panel1.Controls.Add(this.CmbHastane3);
            this.scMenu.Panel1.Controls.Add(this.CmbHastane2);
            this.scMenu.Panel1.Controls.Add(this.CmbHastane1);
            this.scMenu.Panel1.Controls.Add(this.CmbSehir);
            this.scMenu.Panel1.Controls.Add(this.CmbUnvan);
            this.scMenu.Panel1.Controls.Add(this.label15);
            this.scMenu.Panel1.Controls.Add(this.label13);
            this.scMenu.Panel1.Controls.Add(this.label9);
            this.scMenu.Panel1.Controls.Add(this.label5);
            this.scMenu.Panel1.Controls.Add(this.label12);
            this.scMenu.Panel1.Controls.Add(this.label8);
            this.scMenu.Panel1.Controls.Add(this.label3);
            this.scMenu.Panel1.Controls.Add(this.label14);
            this.scMenu.Panel1.Controls.Add(this.label11);
            this.scMenu.Panel1.Controls.Add(this.label7);
            this.scMenu.Panel1.Controls.Add(this.label4);
            this.scMenu.Panel1.Controls.Add(this.label10);
            this.scMenu.Panel1.Controls.Add(this.label6);
            this.scMenu.Panel1.Controls.Add(this.label2);
            // 
            // scMenu.Panel2
            // 
            this.scMenu.Panel2.Controls.Add(this.Liste);
            this.scMenu.Size = new System.Drawing.Size(1004, 461);
            this.scMenu.SplitterDistance = 252;
            this.scMenu.TabIndex = 2;
            // 
            // TxtVergiDairesi
            // 
            this.TxtVergiDairesi.Location = new System.Drawing.Point(771, 170);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Size = new System.Drawing.Size(135, 20);
            this.TxtVergiDairesi.TabIndex = 6;
            this.TxtVergiDairesi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TxtMuayehane
            // 
            this.TxtMuayehane.Location = new System.Drawing.Point(625, 108);
            this.TxtMuayehane.Name = "TxtMuayehane";
            this.TxtMuayehane.Size = new System.Drawing.Size(355, 20);
            this.TxtMuayehane.TabIndex = 5;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(124, 192);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(355, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(124, 154);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(159, 20);
            this.TxtGsm.TabIndex = 4;
            // 
            // TxtTel2
            // 
            this.TxtTel2.Location = new System.Drawing.Point(124, 128);
            this.TxtTel2.Mask = "(999) 000-0000";
            this.TxtTel2.Name = "TxtTel2";
            this.TxtTel2.Size = new System.Drawing.Size(159, 20);
            this.TxtTel2.TabIndex = 4;
            // 
            // TxtVergiNo
            // 
            this.TxtVergiNo.Location = new System.Drawing.Point(771, 198);
            this.TxtVergiNo.Mask = "00000000000";
            this.TxtVergiNo.Name = "TxtVergiNo";
            this.TxtVergiNo.Size = new System.Drawing.Size(135, 20);
            this.TxtVergiNo.TabIndex = 4;
            // 
            // TxtTel1
            // 
            this.TxtTel1.Location = new System.Drawing.Point(124, 104);
            this.TxtTel1.Mask = "(999) 000-0000";
            this.TxtTel1.Name = "TxtTel1";
            this.TxtTel1.Size = new System.Drawing.Size(159, 20);
            this.TxtTel1.TabIndex = 4;
            // 
            // TxtDTarih
            // 
            this.TxtDTarih.Location = new System.Drawing.Point(126, 72);
            this.TxtDTarih.Name = "TxtDTarih";
            this.TxtDTarih.Size = new System.Drawing.Size(355, 20);
            this.TxtDTarih.TabIndex = 3;
            // 
            // TxtAdi
            // 
            this.TxtAdi.Location = new System.Drawing.Point(124, 46);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(357, 20);
            this.TxtAdi.TabIndex = 2;
            // 
            // CmbHastane3
            // 
            this.CmbHastane3.FormattingEnabled = true;
            this.CmbHastane3.Location = new System.Drawing.Point(625, 72);
            this.CmbHastane3.Name = "CmbHastane3";
            this.CmbHastane3.Size = new System.Drawing.Size(355, 21);
            this.CmbHastane3.TabIndex = 1;
            // 
            // CmbHastane2
            // 
            this.CmbHastane2.FormattingEnabled = true;
            this.CmbHastane2.Location = new System.Drawing.Point(625, 46);
            this.CmbHastane2.Name = "CmbHastane2";
            this.CmbHastane2.Size = new System.Drawing.Size(355, 21);
            this.CmbHastane2.TabIndex = 1;
            // 
            // CmbHastane1
            // 
            this.CmbHastane1.FormattingEnabled = true;
            this.CmbHastane1.Location = new System.Drawing.Point(625, 19);
            this.CmbHastane1.Name = "CmbHastane1";
            this.CmbHastane1.Size = new System.Drawing.Size(355, 21);
            this.CmbHastane1.TabIndex = 1;
            // 
            // CmbSehir
            // 
            this.CmbSehir.FormattingEnabled = true;
            this.CmbSehir.Location = new System.Drawing.Point(124, 226);
            this.CmbSehir.Name = "CmbSehir";
            this.CmbSehir.Size = new System.Drawing.Size(355, 21);
            this.CmbSehir.TabIndex = 1;
            // 
            // CmbUnvan
            // 
            this.CmbUnvan.FormattingEnabled = true;
            this.CmbUnvan.Location = new System.Drawing.Point(126, 19);
            this.CmbUnvan.Name = "CmbUnvan";
            this.CmbUnvan.Size = new System.Drawing.Size(355, 21);
            this.CmbUnvan.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 34);
            this.label15.TabIndex = 0;
            this.label15.Text = "Şehir :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(656, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "Vergi Dairesi :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tel 2 :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hastane 2 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 34);
            this.label12.TabIndex = 0;
            this.label12.Text = "Email :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(519, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Muayehane :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad ve Soyad :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(656, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "Vergi No :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Doğum Tarihi :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tel 1 :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hastane 1 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Gsm :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hastane 3 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ünvan :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.Tel1,
            this.Tel2,
            this.Gsm,
            this.Email,
            this.Sehir});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1004, 205);
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
            this.Adi.HeaderText = "Doktor Adı";
            this.Adi.Name = "Adi";
            // 
            // Tel1
            // 
            this.Tel1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel1.HeaderText = "Telefon 1";
            this.Tel1.Name = "Tel1";
            this.Tel1.Width = 77;
            // 
            // Tel2
            // 
            this.Tel2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel2.HeaderText = "Telefon 2";
            this.Tel2.Name = "Tel2";
            this.Tel2.Width = 77;
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
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 56;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(771, 226);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(209, 20);
            this.TxtId.TabIndex = 7;
            // 
            // DoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 520);
            this.Controls.Add(this.scMenu);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label1);
            this.Name = "DoktorGiris";
            this.Text = "DoktorGiris";
            this.Load += new System.EventHandler(this.DoktorGiris_Load);
            this.scMenu.Panel1.ResumeLayout(false);
            this.scMenu.Panel1.PerformLayout();
            this.scMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).EndInit();
            this.scMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.SplitContainer scMenu;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtVergiDairesi;
        private System.Windows.Forms.TextBox TxtMuayehane;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.MaskedTextBox TxtTel2;
        private System.Windows.Forms.MaskedTextBox TxtVergiNo;
        private System.Windows.Forms.MaskedTextBox TxtTel1;
        private System.Windows.Forms.DateTimePicker TxtDTarih;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.ComboBox CmbHastane3;
        private System.Windows.Forms.ComboBox CmbHastane2;
        private System.Windows.Forms.ComboBox CmbHastane1;
        private System.Windows.Forms.ComboBox CmbSehir;
        private System.Windows.Forms.ComboBox CmbUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.TextBox TxtId;
    }
}