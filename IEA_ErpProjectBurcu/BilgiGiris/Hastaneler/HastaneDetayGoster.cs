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
    public partial class HastaneDetayGoster : Form
    {
        private readonly ErpPro102STekrarEntities _db;
        private int gid = -1;
        public HastaneDetayGoster(ErpPro102STekrarEntities db)
        {
            _db = db;
            InitializeComponent();
        }

        private void HastaneDetayGoster_Load(object sender, EventArgs e)
        {
            Listele(gid);
        }

        public void Listele(int gid)
        {
            int i = 0;
            if (gid > 0) 
            {
                var srg = _db.tblHastaneDetaylar.Where(s => s.GirisId == gid).ToList();
                foreach (var s in srg)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = i + 1;
                    Liste.Rows[i].Cells[1].Value = s.YetkiliAdi;
                    Liste.Rows[i].Cells[2].Value = s.tblDepartmanlar.Adi;
                    Liste.Rows[i].Cells[3].Value = s.Tel;
                    Liste.Rows[i].Cells[4].Value = s.Gsm;
                    Liste.Rows[i].Cells[5].Value = s.Email;
                    i++;
                }
                Liste.AllowUserToAddRows= false;
                Liste.AllowUserToDeleteRows= false;
                Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
                Liste.ReadOnly = true;
            }
           

        }
    }
}
