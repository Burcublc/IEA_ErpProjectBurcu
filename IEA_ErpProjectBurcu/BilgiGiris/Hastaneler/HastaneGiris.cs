using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProjectBurcu.Entity;
using IEA_ErpProjectBurcu.Fonksiyonlar;
using IEA_ErpProjectBurcu.Properties;

namespace IEA_ErpProjectBurcu.BilgiGiris.Hastaneler
{
    public partial class HastaneGiris : Form
    {
        private readonly ErpPro102STekrarEntities _db=new ErpPro102STekrarEntities();
        List<tblHastaneler> hlist;
        private tblHastaneler KayitBul;
        private int secimId = -1;
        Formlar f = new Formlar();
        public HastaneGiris()
        {
            InitializeComponent();
        }
        private void HastaneGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
            btnDetayEkle.Visible = false;
            btnDetayGoster.Visible = false;
        }        
        private void Listele()
        {
            Liste.Rows.Clear();
            hlist = _db.tblHastaneler.ToList();
            int i = 0;
            foreach (var s in hlist)
            {            
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = s.Id;
                Liste.Rows[i].Cells[2].Value = s.Adi;
                if(s.tblHastaneTipleri!=null)Liste.Rows[i].Cells[3].Value = s.tblHastaneTipleri.TipAdi;
                if (s.Sehirler != null) Liste.Rows[i].Cells[4].Value = s.Sehirler.name;
                Liste.Rows[i].Cells[5].Value = s.Telefon;          
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void ComboDoldur()
        {
            cmbHastaneTipi.DataSource = _db.tblHastaneTipleri.ToList();
            cmbHastaneTipi.ValueMember = "Id";
            cmbHastaneTipi.DisplayMember = "TipAdi";
            cmbHastaneTipi.SelectedIndex = -1;

            cmbSehir.DataSource = _db.Sehirler.ToList();
            cmbSehir.ValueMember = "Id";
            cmbSehir.DisplayMember = "name";
            cmbSehir.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {

            if(TxtHastaneadi.Text=="" || TxtCariadi.Text=="" || TxtAdres.Text=="" || TxtTel.Text=="" || TxtVergidairesi.Text=="" || TxtVergino.Text=="" || cmbHastaneTipi.Text=="" || cmbSehir.Text=="")
            {
                MessageBox.Show("Lütfen ilgili alanları dolduruz!!");
                return;
            }
            tblHastaneler hastane = new tblHastaneler();
            hastane.Adi = TxtHastaneadi.Text;
            if(cmbHastaneTipi.SelectedValue!=null)hastane.TipId =(int)cmbHastaneTipi.SelectedValue;
            hastane.Adres=TxtAdres.Text;
            if (cmbSehir.SelectedValue != null) hastane.SehirId = (int)cmbSehir.SelectedValue;
            hastane.Telefon = TxtTel.Text;
            hastane.CariAdi = TxtCariadi.Text;
            hastane.VergiDairesi = TxtVergidairesi.Text;
            hastane.VergiNo = TxtVergino.Text;

            _db.tblHastaneler.Add(hastane);
            _db.SaveChanges();
            MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir.");
            Temizle();
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) //satır boş değilse yap
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value; //Mevcut satırdaki 1.sütundaki değeri yani Id 'yi atıyoruz
            }
            Ac(secimId);
        }

        public void Ac(int id)
        {
            secimId = id;
            KayitBul = hlist.FirstOrDefault(x=>x.Id==id);
            TxtHastaneadi.Text = KayitBul.Adi;
            TxtCariadi.Text = KayitBul.CariAdi;
            if(KayitBul.tblHastaneTipleri!=null)cmbHastaneTipi.Text = KayitBul.tblHastaneTipleri.TipAdi;
            TxtAdres.Text = KayitBul.Adres;
            TxtVergidairesi.Text = KayitBul.VergiDairesi;
            TxtVergino.Text = KayitBul.VergiNo;
            if(KayitBul.Sehirler!=null)cmbSehir.Text = KayitBul.Sehirler.name;
            TxtTel.Text = KayitBul.Telefon;
            TxtUrunId.Text = KayitBul.Id.ToString().PadLeft(4,'0');

            btnDetayEkle.Visible = true;
            btnDetayGoster.Visible = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {          
            Guncelle();
        }

        private void Guncelle()
        {
            if (secimId < 0)
            {
                MessageBox.Show("Lütfen Listeden Güncellenecek Elemanı Seçiniz!!");
                return;
            }
            if (TxtHastaneadi.Text == "" || TxtCariadi.Text == "" || TxtAdres.Text == "" || TxtTel.Text == "" || TxtVergidairesi.Text == "" || TxtVergino.Text == "" || cmbHastaneTipi.Text == "" || cmbSehir.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları dolduruz!!");
                return;
            }
            
            KayitBul.Adi=TxtHastaneadi.Text;
            if(cmbHastaneTipi.SelectedValue!=null)KayitBul.TipId = Convert.ToInt32(cmbHastaneTipi.SelectedValue);
            KayitBul.Adres = TxtAdres.Text;
            if(cmbSehir.SelectedValue!=null)KayitBul.SehirId = Convert.ToInt32(cmbSehir.SelectedValue);
            KayitBul.Telefon = TxtTel.Text;
            KayitBul.CariAdi = TxtCariadi.Text;
            KayitBul.VergiDairesi = TxtVergidairesi.Text;
            KayitBul.VergiNo = TxtVergino.Text;
            _db.SaveChanges();
            MessageBox.Show("Kaydınız Güncellenmiştir.");
            Temizle();
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach(Control k in ScMenu.Panel1.Controls)
            {
                if(k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox) 
                {
                    k.Text = "";
                }
            }
            cmbHastaneTipi.SelectedIndex = -1;
            cmbSehir.SelectedIndex = -1;
            btnDetayEkle.Visible = false;
            btnDetayGoster.Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Lütfen Listeden Silinecek Elemanı Giriniz:");
                return;
            }
            DialogResult dr = MessageBox.Show("Kayıt Kalıcı Olarak Silinecektir!", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) Sil();
        }

        private void Sil()
        {                    
            _db.tblHastaneler.Remove(KayitBul);
            _db.SaveChanges();
            MessageBox.Show("Kaydınız Silinmiştir.");
            Temizle();
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            f.HastaneDetayAc(secimId);
        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            f.HastaneDetayGosterAc(secimId);
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtUrunId.ClientSize.Height);
            btn.Location = new Point(TxtUrunId.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout=ImageLayout.Stretch;
            btn.Anchor=(AnchorStyles.Top | AnchorStyles.Right);
            TxtUrunId.Controls.Add(btn);
            base.OnLoad(e);

            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.HastanelerListesiAc(true);
            if (id > 0)
            {
                Ac(id);
            }
            Anasayfa.Aktarma = -1;
        }
    }
}
