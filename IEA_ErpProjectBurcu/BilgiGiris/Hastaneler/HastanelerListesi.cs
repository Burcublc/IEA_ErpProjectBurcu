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

namespace IEA_ErpProjectBurcu.BilgiGiris.Hastaneler
{
    public partial class HastanelerListesi : Form
    {
        private readonly ErpPro102STekrarEntities _db;
        Formlar f = new Formlar();
        public bool Secim=false;
        private int secimId = -1;
        public HastanelerListesi(ErpPro102STekrarEntities db)
        {
            _db = db;
            InitializeComponent();           
        }

        private void HastanelerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        tblHastaneler[] srg;
        private void Listele()
        {
            int i = 0;
            srg = (from x in _db.tblHastaneler where x.Adi.Contains(txtHastaneAdi.Text) select x).ToArray();
            Liste.Rows.Clear();
            foreach (var s in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value =i+1;
                Liste.Rows[i].Cells[1].Value =s.Id;
                Liste.Rows[i].Cells[2].Value =s.Adi;
                Liste.Rows[i].Cells[3].Value =s.tblHastaneTipleri.TipAdi;
                Liste.Rows[i].Cells[4].Value =s.Sehirler.name.ToString();
                Liste.Rows[i].Cells[5].Value =s.Telefon;
                i++;
            }
            Liste.AllowUserToAddRows=false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtHastaneAdi_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = Convert.ToInt32(Liste.CurrentRow.Cells[1].Value);

                if (secimId > 0 && Secim && Application.OpenForms["HastaneGiris"] == null) //hastane sayfası yok
                {
                    Anasayfa.Aktarma = secimId;
                    Close();
                }
                if (Secim && Application.OpenForms["HastaneGiris"] != null) //hastane sayfası var
                {
                    HastaneGiris frm = Application.OpenForms["HastaneGiris"] as HastaneGiris;
                    frm.Ac(secimId);
                    Close();
                }
                else if (!Secim)
                {
                    f.HastaneGirisAc(secimId);
                    Close();
                }
            }
        }
    }
}
