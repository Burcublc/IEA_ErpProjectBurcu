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

namespace IEA_ErpProjectBurcu.BilgiGiris.Doktorlar
{
    public partial class DoktorlarListesi : Form
    {
        private readonly ErpPro102STekrarEntities _db;
        private int secimId = -1;
        Formlar f = new Formlar();
        public bool Secim = false;
        public DoktorlarListesi(ErpPro102STekrarEntities db)
        {
            _db = db;
            InitializeComponent();
        }

        private void DoktorlarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            int i = 0;
            Liste.Rows.Clear();
            var srg = _db.tblDoktorlar.ToList();
            foreach (var s in srg)
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
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = Convert.ToInt32(Liste.CurrentRow.Cells[1].Value);
            if (!Secim)
            {
                f.DoktorGirisAc(secimId);
                Close();
            }
            else if(Secim && Application.OpenForms["Doktor Giris"] as DoktorGiris != null)//doktor sayfası varsa
            {
                DoktorGiris frm = Application.OpenForms["DoktorGiris"] as DoktorGiris;
                frm.Ac(secimId);
                Close();
            }
            else if (secimId > 0 && Secim && Application.OpenForms["Doktor Giris"] as DoktorGiris == null)//doktor sayfası yok
            {
                Anasayfa.Aktarma = secimId;
                Close();
            }

        }
    }
}
