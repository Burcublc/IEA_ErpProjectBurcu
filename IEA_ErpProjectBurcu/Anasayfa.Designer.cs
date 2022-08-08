namespace IEA_ErpProjectBurcu
{
    partial class Anasayfa
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.btnUrunIslem = new System.Windows.Forms.Button();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAra = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMenuTxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scMenu = new System.Windows.Forms.SplitContainer();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).BeginInit();
            this.scMenu.Panel1.SuspendLayout();
            this.scMenu.Panel2.SuspendLayout();
            this.scMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 70);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 44);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 44);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yönetim";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 70);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(800, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(234, 157);
            this.tvMenu.TabIndex = 1;
            this.tvMenu.DoubleClick += new System.EventHandler(this.tvMenu_DoubleClick);
            // 
            // btnUrunIslem
            // 
            this.btnUrunIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunIslem.Location = new System.Drawing.Point(116, 14);
            this.btnUrunIslem.Name = "btnUrunIslem";
            this.btnUrunIslem.Size = new System.Drawing.Size(75, 46);
            this.btnUrunIslem.TabIndex = 1;
            this.btnUrunIslem.Text = "Ürün İşlemleri";
            this.btnUrunIslem.UseVisualStyleBackColor = true;
            this.btnUrunIslem.Click += new System.EventHandler(this.btnUrunIslem_Click);
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilgiGiris.Location = new System.Drawing.Point(12, 14);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(75, 46);
            this.btnBilgiGiris.TabIndex = 0;
            this.btnBilgiGiris.Text = "Bilgi Giriş İşlemleri";
            this.btnBilgiGiris.UseVisualStyleBackColor = true;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblMenuTxt);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.Ara32x321;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Location = new System.Drawing.Point(196, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(30, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::IEA_ErpProjectBurcu.Properties.Resources.RightLeft2Red;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(196, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblMenuTxt
            // 
            this.lblMenuTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMenuTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTxt.Location = new System.Drawing.Point(3, 29);
            this.lblMenuTxt.Name = "lblMenuTxt";
            this.lblMenuTxt.Size = new System.Drawing.Size(187, 23);
            this.lblMenuTxt.TabIndex = 1;
            this.lblMenuTxt.Text = "****";
            this.lblMenuTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.scMenu);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 377);
            this.panel2.TabIndex = 4;
            // 
            // scMenu
            // 
            this.scMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenu.Location = new System.Drawing.Point(0, 61);
            this.scMenu.Name = "scMenu";
            this.scMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMenu.Panel1
            // 
            this.scMenu.Panel1.Controls.Add(this.tvMenu);
            this.scMenu.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // scMenu.Panel2
            // 
            this.scMenu.Panel2.Controls.Add(this.btnUrunIslem);
            this.scMenu.Panel2.Controls.Add(this.btnBilgiGiris);
            this.scMenu.Size = new System.Drawing.Size(234, 316);
            this.scMenu.SplitterDistance = 157;
            this.scMenu.TabIndex = 1;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(234, 73);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 377);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.scMenu.Panel1.ResumeLayout(false);
            this.scMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).EndInit();
            this.scMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Label lblMenuTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUrunIslem;
        private System.Windows.Forms.Button btnBilgiGiris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer scMenu;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Splitter splitter2;
    }
}