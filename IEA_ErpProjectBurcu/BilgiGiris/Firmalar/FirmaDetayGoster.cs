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
    public partial class FirmaDetayGoster : Form
    {
        private ErpPro102STekrarEntities _db;
        public int secimId = -1;
        public FirmaDetayGoster(ErpPro102STekrarEntities db)
        {
            _db = db;
            InitializeComponent();
        }

        private void FirmaDetayGoster_Load(object sender, EventArgs e)
        {
            var list=_db.tblFirmaDetaylar.Where(x=>x.GirisId==secimId).ToList();
            int i = 0;
            foreach(var k in list)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i+1;
                Liste.Rows[i].Cells[1].Value = k.YetkiliAdi;
                Liste.Rows[i].Cells[2].Value = k.tblDepartmanlar.Adi;
                Liste.Rows[i].Cells[3].Value = k.Tel;
                Liste.Rows[i].Cells[4].Value = k.Gsm;
                Liste.Rows[i].Cells[5].Value = k.Email;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }
    }
}
