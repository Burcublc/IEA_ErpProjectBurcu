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

namespace IEA_ErpProjectBurcu.BilgiGiris.Doktorlar
{
    public partial class DoktorGiris : Form
    {
        private readonly ErpPro102STekrarEntities _db;
        private int secimId = -1;
        List<tblDoktorlar> dliste;
        Formlar f = new Formlar();
        public DoktorGiris(ErpPro102STekrarEntities db)
        {
            _db = db;
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        
        private void Listele()
        {
            int i = 0;
            Liste.Rows.Clear();
            dliste = _db.tblDoktorlar.ToList();
            foreach(var s in dliste)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = s.Id;
                Liste.Rows[i].Cells[2].Value = s.Adi;
                Liste.Rows[i].Cells[3].Value = s.Tel1;
                Liste.Rows[i].Cells[4].Value = s.Tel2;
                Liste.Rows[i].Cells[5].Value = s.Gsm;
                Liste.Rows[i].Cells[6].Value = s.Email;
                Liste.Rows[i].Cells[7].Value = s.Sehirler.name;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows= false;
            Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void ComboDoldur()
        {
            CmbHastane1.DataSource = _db.tblHastaneler.ToList(); ;
            CmbHastane1.ValueMember = "Id";
            CmbHastane1.DisplayMember = "Adi";
            CmbHastane1.SelectedIndex = -1;

            CmbHastane2.DataSource = _db.tblHastaneler.ToList(); ;
            CmbHastane2.ValueMember = "Id";
            CmbHastane2.DisplayMember = "Adi";
            CmbHastane2.SelectedIndex = -1;

            CmbHastane3.DataSource = _db.tblHastaneler.ToList(); ;
            CmbHastane3.ValueMember = "Id";
            CmbHastane3.DisplayMember = "Adi";
            CmbHastane3.SelectedIndex = -1;


            CmbSehir.DataSource = _db.Sehirler.ToList();
            CmbSehir.ValueMember = "Id";
            CmbSehir.DisplayMember = "name";
            CmbSehir.SelectedIndex = -1;

            CmbUnvan.DataSource = Enum.GetValues(typeof(Unvan));
            CmbUnvan.SelectedIndex = -1;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {

            if(CmbUnvan.Text=="" || TxtAdi.Text == "" || CmbHastane1.Text=="" || CmbHastane2.Text == "" || CmbHastane3.Text == "" || CmbSehir.Text=="")
            {
                MessageBox.Show("Lütfen alanları boş geçmeyiniz!!");
                return;
            }
            tblDoktorlar doktor = new tblDoktorlar();
            doktor.Unvan = CmbUnvan.Text;
            doktor.Adi = TxtAdi.Text;
            doktor.DTarih = TxtDTarih.Value;
            doktor.Tel1 = TxtTel1.Text;
            doktor.Tel2 = TxtTel2.Text;
            doktor.Gsm = TxtGsm.Text;
            doktor.Email=TxtEmail.Text;
            doktor.SehirId = (int)CmbSehir.SelectedValue;
            doktor.Hastane1Id = (int)CmbHastane1.SelectedValue;
            doktor.Hastane2Id = (int)CmbHastane2.SelectedValue;
            doktor.Hastane3Id = (int)CmbHastane3.SelectedValue;
            doktor.Muayehane = TxtMuayehane.Text;
            doktor.VergiDairesi=TxtVergiDairesi.Text;
            doktor.VergiNo = TxtVergiNo.Text;

            _db.tblDoktorlar.Add(doktor);
            _db.SaveChanges();
            MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir.");
            Listele();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            
            if (secimId > 0)
            {

                if (CmbUnvan.Text == "" || TxtAdi.Text == "" || CmbHastane1.Text == "" || CmbHastane2.Text == "" || CmbHastane3.Text == "" || CmbSehir.Text == "")
                {
                    MessageBox.Show("Lütfen alanları boş geçmeyiniz!!");
                    return;
                }
                var srg = (from s in _db.tblDoktorlar select s).FirstOrDefault(s => s.Id == secimId);
                srg.Unvan = CmbUnvan.Text;
                srg.Adi=TxtAdi.Text;
                srg.DTarih = TxtDTarih.Value;
                srg.Tel1=TxtTel1.Text;
                srg.Tel2=TxtTel2.Text;
                srg.Gsm=TxtGsm.Text;
                srg.Email=TxtEmail.Text;
                srg.SehirId=Convert.ToInt32(CmbSehir.SelectedValue);
                srg.Hastane1Id = Convert.ToInt32(CmbHastane1.SelectedValue);
                srg.Hastane2Id = Convert.ToInt32(CmbHastane2.SelectedValue);
                srg.Hastane3Id = Convert.ToInt32(CmbHastane3.SelectedValue);
                srg.Muayehane = TxtMuayehane.Text;
                srg.VergiDairesi=TxtVergiDairesi.Text;
                srg.VergiNo=TxtVergiNo.Text;
                _db.SaveChanges();
                MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçeklerşmiştir!!");
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncelemek istediğiniz elemanı listeden seçiniz!");
                return;
            }
        }

        private void Temizle()
        {
            foreach(Control k in scMenu.Panel1.Controls)
            {
                if(k is TextBox || k is MaskedTextBox)
                {
                    k.Text = "";                 
                }
            }
            CmbHastane1.SelectedIndex = -1;
            CmbHastane2.SelectedIndex = -1;
            CmbHastane3.SelectedIndex = -1;
            CmbSehir.SelectedIndex = -1;
            CmbUnvan.SelectedIndex = -1;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int)Liste.CurrentRow.Cells[1].Value;
            Ac(secimId);
        }
        tblDoktorlar srg;
        public void Ac(int secimId)
        {
            srg = dliste.FirstOrDefault(x => x.Id == secimId);
            CmbUnvan.Text = srg.Unvan;
            TxtAdi.Text = srg.Adi;
            TxtDTarih.Text = srg.DTarih.ToString();
            TxtTel1.Text = srg.Tel1;
            TxtTel2.Text = srg.Tel2;
            TxtGsm.Text = srg.Gsm;
            TxtEmail.Text=srg.Email;
            CmbSehir.Text = srg.Sehirler.name;
            CmbHastane1.Text = srg.tblHastaneler.Adi;
            CmbHastane2.Text = srg.tblHastaneler1.Adi;
            CmbHastane3.Text = srg.tblHastaneler2.Adi;
            TxtMuayehane.Text = srg.Muayehane;
            TxtVergiDairesi.Text = srg.VergiDairesi;
            TxtVergiNo.Text= srg.VergiNo;
            TxtId.Text = srg.Id.ToString().PadLeft(4, '0');
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Lütfen Silmek istediğiniz elemanı Listeden seçiniz!!");
                return;
            }
            DialogResult dr = MessageBox.Show("Kayıt Kalıcı Olarak Silinecektir!", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) Sil();
        }

        private void Sil()
        {
            _db.tblDoktorlar.Remove(srg);
            _db.SaveChanges();
            MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşmiştir!!");
            Listele();
            Temizle();
        }
        protected override void OnLoad(EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(25, TxtId.ClientSize.Height);
            btn.Location = new Point(TxtId.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtId.Controls.Add(btn);
            base.OnLoad(e);

            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            int id = f.DoktorlarListesiAc(true);
            if (id > 0)
            {
                Ac(id);
            }
            
        }
    }
}
