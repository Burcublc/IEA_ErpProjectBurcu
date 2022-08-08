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

namespace IEA_ErpProjectBurcu.BilgiGiris.Hastaneler
{
    public partial class HastaneDetayEkle : Form
    {
        private int secimId = -1;
        private readonly ErpPro102STekrarEntities _db=new ErpPro102STekrarEntities();
        public HastaneDetayEkle()
        {
            InitializeComponent();
        }

        private void HastaneDetayEkle_Load(object sender, EventArgs e)
        {
            var srg = _db.tblHastaneler.Where(s => s.Id == secimId).FirstOrDefault();
            LblId.Text = srg.Id.ToString();
            LblHastaneAdi.Text = srg.Adi;

            ComboDoldur();
        }

        private void ComboDoldur()
        {
            CmbDepartman.DataSource=_db.tblDepartmanlar.Where(s=>s.DepartmanKodu=="H").ToList();
            CmbDepartman.ValueMember = "Id";
            CmbDepartman.DisplayMember = "Adi";
            CmbDepartman.SelectedIndex = -1;
        }

        public void Ac(int id) 
        {
            secimId = id;
            
        }
        private int i = 0;

        private void BtnEkle_Click(object sender, EventArgs e)
        {            
            Liste.Rows.Add();
            Liste.Rows[i].Cells[0].Value = i+1;
            Liste.Rows[i].Cells[1].Value = LblId.Text;
            Liste.Rows[i].Cells[2].Value = "H";
            Liste.Rows[i].Cells[3].Value = TxtYetkili.Text;
            Liste.Rows[i].Cells[4].Value = CmbDepartman.SelectedValue.ToString();
            Liste.Rows[i].Cells[5].Value = TxtTel.Text;
            Liste.Rows[i].Cells[6].Value = TxtGsm.Text;
            Liste.Rows[i].Cells[7].Value = TxtEmail.Text;
            i++;
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Temizle();
        }

       

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if (Liste.CurrentRow != null)
            {
                tblHastaneDetaylar[] alt = new tblHastaneDetaylar[Liste.RowCount];
                for (int i = 0; i < Liste.RowCount; i++)
                {
                    alt[i] = new tblHastaneDetaylar();
                    alt[i].GirisId = Convert.ToInt32(Liste.Rows[i].Cells[1].Value);
                    alt[i].YetkiliAdi = Liste.Rows[i].Cells[3].Value.ToString();
                    alt[i].DepartmanId = Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                    alt[i].Tel = Liste.Rows[i].Cells[5].Value.ToString();
                    alt[i].Gsm = Liste.Rows[i].Cells[6].Value.ToString();
                    alt[i].Email = Liste.Rows[i].Cells[7].Value.ToString();
                }
                _db.tblHastaneDetaylar.AddRange(alt);
                _db.SaveChanges();
                MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir.");
                Close();


            }
            else
            {
                MessageBox.Show("Lütfen Listeye Kayıt Giriniz!!");
                return;
            }
            
        }

        private void Temizle()
        {
            TxtYetkili.Text = "";
            TxtTel.Text = "";
            TxtGsm.Text = "";
            TxtEmail.Text = "";
            CmbDepartman.SelectedIndex = -1;
        }
    }
}
