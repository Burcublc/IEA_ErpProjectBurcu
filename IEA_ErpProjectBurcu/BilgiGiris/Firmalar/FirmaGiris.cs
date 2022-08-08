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

namespace IEA_ErpProjectBurcu.BilgiGiris.Firmalar
{
    public partial class FirmaGiris : Form
    {
        private readonly ErpPro102STekrarEntities _db;
        private List<tblFirmalar> list;
        private int secimId=-1;
        Formlar f = new Formlar();
        public FirmaGiris(ErpPro102STekrarEntities db)
        {
            _db = db;
            InitializeComponent();
        }

        private void FirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;
        }

        private void ComboDoldur()
        {
            CmbSehir.DataSource = _db.Sehirler.ToList();
            CmbSehir.ValueMember = "Id";
            CmbSehir.DisplayMember = "name";
            CmbSehir.SelectedIndex = -1;

            CmbFirmaTip.DataSource = Enum.GetValues(typeof(FirmaTip));
            CmbFirmaTip.SelectedIndex = -1;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if(TxtAdi.Text=="" && TxtAdres.Text=="" && CmbSehir.Text=="")
            {
                MessageBox.Show("Lütfen ALanlari Boş Geçmeyiniz!!");
                return;
            }
            tblFirmalar yenikayit=new tblFirmalar();
            yenikayit.Adi = TxtAdi.Text;
            yenikayit.Adres=TxtAdres.Text;
            yenikayit.SehirId = Convert.ToInt32(CmbSehir.SelectedValue);
            yenikayit.FirmaTip = CmbFirmaTip.Text;
            yenikayit.VergiDairesi = TxtVergiDairesi.Text;
            yenikayit.VergiNo=TxtVergiNo.Text;
            yenikayit.Tel = TxtTel.Text;
            yenikayit.Email = TxtEmail.Text;
            yenikayit.Web = TxtWeb.Text;
            _db.tblFirmalar.Add(yenikayit);
            _db.SaveChanges();
            MessageBox.Show("Kayit İşleminiz Başarıyla Gerçekleşmiştir.");
            Temizle();
            Listele();
        }
       
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            list = _db.tblFirmalar.ToList();
            foreach(var k in list)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = k.Id;
                Liste.Rows[i].Cells[2].Value = k.Adi;
                Liste.Rows[i].Cells[3].Value = k.Sehirler.name;
                Liste.Rows[i].Cells[4].Value = k.FirmaTip;
                Liste.Rows[i].Cells[5].Value = k.Tel;
                Liste.Rows[i].Cells[6].Value = k.Email;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows= false;
            Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Temizle()
        {
            foreach(Control k in ScMenu.Panel1.Controls)
            {
                if(k is TextBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }
            }
            CmbSehir.SelectedIndex = -1;
            CmbFirmaTip.SelectedIndex = -1;
            TxtKayitBul.Text = "";
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow!=null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }
            Ac(secimId);
        }
        private tblFirmalar KayitBul;
        public void Ac(int secimId)
        {
            KayitBul = list.FirstOrDefault(x => x.Id == secimId);
            if (KayitBul != null)
            {
                TxtAdi.Text = KayitBul.Adi;
                TxtAdres.Text = KayitBul.Adres;
                TxtEmail.Text = KayitBul.Email;
                TxtTel.Text = KayitBul.Tel;
                TxtVergiDairesi.Text = KayitBul.VergiDairesi;
                TxtVergiNo.Text = KayitBul.VergiNo;
                TxtWeb.Text = KayitBul.Web;
                CmbSehir.Text = KayitBul.Sehirler.name;
                CmbFirmaTip.Text = KayitBul.FirmaTip;
                TxtKayitBul.Text = KayitBul.Id.ToString().PadLeft(4, '0');
            }
            BtnDetayEkle.Visible = true;
            BtnDetayGoster.Visible = true;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (secimId < 0) 
            {
                MessageBox.Show("Lütfen Listeden Bir Kayit Seciniz!");
                return;
            }
            if (KayitBul != null)
            {
                KayitBul.Adi = TxtAdi.Text;
                KayitBul.Adres = TxtAdres.Text;
                KayitBul.Tel = TxtTel.Text;
                KayitBul.Email = TxtEmail.Text;
                KayitBul.Web = TxtWeb.Text;
                KayitBul.SehirId = Convert.ToInt32(CmbSehir.SelectedValue);
                KayitBul.FirmaTip = CmbFirmaTip.Text;
                KayitBul.VergiDairesi = TxtVergiDairesi.Text;
                KayitBul.VergiNo = TxtVergiNo.Text;
            }
            _db.SaveChanges();
            MessageBox.Show("Guncelleme İşlemi Başarıyla Gerçekleşmiştir.");
            Temizle();
            Listele();
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Lütfen Silinecek Kaydı Seçiniz!");
                return;
            }
            DialogResult dr=MessageBox.Show("Kayit Kalici Olarak Silinecektir","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)Sil();
        }

        private void Sil()
        {
            if (secimId > 0)
            {
                _db.tblFirmalar.Remove(KayitBul);
                _db.SaveChanges();
                MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşmiştir.");
                Temizle();
                Listele();
                secimId = -1;
                BtnDetayEkle.Visible = false;
                BtnDetayGoster.Visible = false;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            Button btn=new Button();
            btn.Size = new Size(25, TxtKayitBul.ClientSize.Height);
            btn.Location = new Point(TxtKayitBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor= Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor=(AnchorStyles.Top|AnchorStyles.Right);
            TxtKayitBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int id=f.FirmalarListesiAc(true);
            if (id > 0)
            {
                Ac(id);
            }
        }

        private void BtnDetayGoster_Click(object sender, EventArgs e)
        {
            DetayGoster();
        }

        private void DetayGoster()
        {
            FirmaDetayGoster frm = new FirmaDetayGoster(new ErpPro102STekrarEntities());
            frm.MdiParent = Form.ActiveForm;
            frm.secimId = secimId;
            frm.Show();
        }

        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {
           DetayEkle();
        }

        private void DetayEkle()
        {
            FirmaDetayEkle frm = new FirmaDetayEkle(new ErpPro102STekrarEntities());
            frm.MdiParent = Form.ActiveForm;
            frm.secimId = Convert.ToInt32(Liste.CurrentRow.Cells[1].Value);
            frm.isim = Convert.ToString(Liste.CurrentRow.Cells[2].Value);
            frm.Show();
            
        }

        private void Liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
