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

namespace IEA_ErpProjectBurcu.BilgiGiris.Firmalar
{
    public partial class FirmaDetayEkle : Form
    {
        private readonly ErpPro102STekrarEntities _db;
        public int secimId = -1;
        public string isim = "";
        public FirmaDetayEkle(ErpPro102STekrarEntities db)
        {
            _db = db;
            InitializeComponent();
        }

        private void FirmaDetayEkle_Load(object sender, EventArgs e)
        {
            LblFirmaId.Text =Convert.ToString(secimId);
            LblFirmaAdi.Text =isim;
            ComboDoldur();
        }

        private void ComboDoldur()
        {
            CmbDepartmanAdi.DataSource = _db.tblDepartmanlar.Where(x => x.DepartmanKodu == "F").ToList();
            CmbDepartmanAdi.ValueMember = "Id";
            CmbDepartmanAdi.DisplayMember = "Adi";
            CmbDepartmanAdi.SelectedIndex = -1;
        }

        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {
            YeniDetayEkle();
        }


        private void YeniDetayEkle()
        {
            if(TxtYetkiliAdi.Text!="" && CmbDepartmanAdi.SelectedIndex != -1)
            {
                Liste.AllowUserToAddRows = false;
                int i = Liste.RowCount;
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = LblFirmaId.Text;
                Liste.Rows[i].Cells[2].Value = TxtYetkiliAdi.Text;
                Liste.Rows[i].Cells[3].Value = CmbDepartmanAdi.SelectedValue;
                Liste.Rows[i].Cells[4].Value = TxtTel.Text;
                Liste.Rows[i].Cells[5].Value = TxtGsm.Text;
                Liste.Rows[i].Cells[6].Value = TxtEmail.Text;
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Alanlari Boş Geçmeyiniz!");
                return;
            }
            
        }

        private void Temizle()
        {
            TxtYetkiliAdi.Text = "";
            CmbDepartmanAdi.SelectedIndex = -1;
            TxtTel.Text = "";
            TxtEmail.Text = "";
            TxtGsm.Text = "";
        }
   
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Liste != null)
            {
                tblFirmaDetaylar[] list=new tblFirmaDetaylar[Liste.RowCount];
                for (int i = 0; i < Liste.Rows.Count; i++)
                {
                    list[i] = new tblFirmaDetaylar();
                    list[i].GirisId = Convert.ToInt32(Liste.Rows[i].Cells[1].Value);
                    list[i].YetkiliAdi = Liste.Rows[i].Cells[2].Value.ToString();
                    list[i].DepartmanId = Convert.ToInt32(Liste.Rows[i].Cells[3].Value);
                    list[i].Tel = Liste.Rows[i].Cells[4].Value.ToString();
                    list[i].Gsm = Liste.Rows[i].Cells[5].Value.ToString();
                    list[i].Email = Liste.Rows[i].Cells[6].Value.ToString();
                }
                _db.tblFirmaDetaylar.AddRange(list);
                _db.SaveChanges();
                MessageBox.Show("Kaydetme İşleminiz Başarıyla Gerçekleşmiştir");
                Close();
            }
            else
            {
                MessageBox.Show("Listede eklenecek eleman yoktur.Lütfen Eleman ekleyiniz!!");
                return;
            }
            
        }
    }
}
