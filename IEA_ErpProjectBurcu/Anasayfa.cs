using IEA_ErpProjectBurcu.BilgiGiris.Doktorlar;
using IEA_ErpProjectBurcu.BilgiGiris.Firmalar;
using IEA_ErpProjectBurcu.BilgiGiris.Hastaneler;
using IEA_ErpProjectBurcu.Entity;
using IEA_ErpProjectBurcu.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProjectBurcu
{
    public partial class Anasayfa : Form
    {
        public static int Aktarma = -1;
        Formlar f = new Formlar();
        public Anasayfa()
        {
            InitializeComponent();
        }

     
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            

        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblMenuTxt.Text = btnBilgiGiris.Text;
            MenuGetir("Bilgi");
        }
        private void btnUrunIslem_Click(object sender, EventArgs e)
        {
            lblMenuTxt.Text = btnUrunIslem.Text;
            MenuGetir("Urun");
        }

        private void MenuGetir(string info)
        {
            tvMenu.Nodes.Clear();
            if (info == "Bilgi") 
            {
                tvMenu.Nodes.Add("Hastaneler");
                tvMenu.Nodes[0].Nodes.Add("Hastaneler Listesi");
                tvMenu.Nodes[0].Nodes.Add("Hastane Bilgi Girişi");

                tvMenu.Nodes.Add("Doktorlar");
                tvMenu.Nodes[1].Nodes.Add("Doktorlar Listesi");
                tvMenu.Nodes[1].Nodes.Add("Doktor Bilgi Girişi");

                tvMenu.Nodes.Add("Firmalar");
                tvMenu.Nodes[2].Nodes.Add("Firmalar Listesi");
                tvMenu.Nodes[2].Nodes.Add("Firma Bilgi Girişi");

                tvMenu.Nodes.Add("Personeller");
                tvMenu.Nodes[3].Nodes.Add("Personeller Listesi");
                tvMenu.Nodes[3].Nodes.Add("Personel Bilgi Girişi");
            }
            else if (info == "Urun") 
            {

            }
            
        }

        private void tvMenu_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (tvMenu.SelectedNode != null)
            {
                isim = tvMenu.SelectedNode.Text;
            }
            

            #region Hastaneler
            if (isim == "Hastaneler Listesi" && Application.OpenForms["HastanelerListesi"]==null)
            {
                f.HastanelerListesiAc();
            }
            else if (isim == "Hastane Bilgi Girişi" && Application.OpenForms["HastaneGiris"]==null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            #endregion

            #region Doktorlar
            if (isim == "Doktorlar Listesi")
            {
                f.DoktorlarListesiAc();
            }
            else if (isim == "Doktor Bilgi Girişi")
            {
                DoktorGiris frm = new DoktorGiris(new ErpPro102STekrarEntities());
                frm.MdiParent=Form.ActiveForm;
                frm.Show();
            }
            #endregion

            #region Firmalar
            if (isim == "Firmalar Listesi")
            {
                f.FirmalarListesiAc();
            }
            else if (isim == "Firma Bilgi Girişi")
            {
                FirmaGiris frm = new FirmaGiris(new ErpPro102STekrarEntities());
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            #endregion

            #region Personeller
            if (isim == "Personeller Listesi")
            {

            }
            else if (isim == "Personel Bilgi Girişi")
            {

            } 
            #endregion
        }

       
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
