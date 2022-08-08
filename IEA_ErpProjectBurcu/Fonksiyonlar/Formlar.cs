using IEA_ErpProjectBurcu.BilgiGiris.Hastaneler;
using IEA_ErpProjectBurcu.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEA_ErpProjectBurcu.Entity;
using System.Windows.Forms;
using IEA_ErpProjectBurcu.BilgiGiris.Doktorlar;
using IEA_ErpProjectBurcu.BilgiGiris.Firmalar;

namespace IEA_ErpProjectBurcu.Fonksiyonlar
{
    public class Formlar
    {
        private readonly ErpPro102STekrarEntities _db = new ErpPro102STekrarEntities();
        public void HastaneDetayAc(int id)
        {
            HastaneDetayEkle frm = new HastaneDetayEkle();
            frm.Ac(id);
            frm.ShowDialog();
        }
        public void HastaneDetayGosterAc(int id)
        {
            HastaneDetayGoster frm = new HastaneDetayGoster(new ErpPro102STekrarEntities());
            frm.Listele(id);
            frm.ShowDialog();
        }
        public void HastaneGirisAc(int id)
        {
            HastaneGiris frm = new HastaneGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }
        public int HastanelerListesiAc(bool secim = false)
        {
            HastanelerListesi frm = new HastanelerListesi(new ErpPro102STekrarEntities());
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            return Anasayfa.Aktarma;
        }
        public int DoktorlarListesiAc(bool secim = false)
        {
            DoktorlarListesi frm = new DoktorlarListesi(new ErpPro102STekrarEntities());
            if (secim) //true ise(Doktor Bilgi Girişinden geliyor)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {//false ise(Anasayfadan geliyo)
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            return Anasayfa.Aktarma;
        }
        public void DoktorGirisAc(int id)
        {
            DoktorGiris frm = new DoktorGiris(new ErpPro102STekrarEntities());
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);

        }
        public int FirmalarListesiAc(bool secim = false)
        {
            FirmalarListesi frm = new FirmalarListesi(new ErpPro102STekrarEntities());
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            return Anasayfa.Aktarma;

        }
        public void FirmaGirisAc(int id)
        {
            FirmaGiris frm=new FirmaGiris(new ErpPro102STekrarEntities());
            frm.MdiParent=Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }
    }

}
