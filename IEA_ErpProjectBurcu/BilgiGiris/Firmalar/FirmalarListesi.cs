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

namespace IEA_ErpProjectBurcu.BilgiGiris.Firmalar
{
    public partial class FirmalarListesi : Form
    {
        private readonly ErpPro102STekrarEntities _db;
        Formlar f = new Formlar();
        public bool Secim=false;
        private int secimId = -1;
        public FirmalarListesi(ErpPro102STekrarEntities db)
        {
            _db = db;
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FirmalarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            int i = 0;
            var list = _db.tblFirmalar.ToList();
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
            Liste.AllowUserToAddRows= false;
            Liste.AllowUserToDeleteRows= false;
            Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = Convert.ToInt32(Liste.CurrentRow.Cells[1].Value);
            if (!Secim)
            {
                f.FirmaGirisAc(secimId);
                Close();
            }
            else if (Secim && Application.OpenForms["Firma Giris"] as FirmaGiris != null)//firma sayfası varsa
            {
                FirmaGiris frm = Application.OpenForms["Firma Giris"] as FirmaGiris;
                frm.Ac(secimId);
                Close();
            }
            else if (secimId > 0 && Secim && Application.OpenForms["Firma Giris"] as FirmaGiris == null)//firma sayfası yoksa
            {
                Anasayfa.Aktarma = secimId;
                Close();
            }

        }
    }
}
