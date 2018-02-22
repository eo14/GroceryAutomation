using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MarketEntity.Classes;
using MarketBLL.Repository;

namespace MarketDEV.WFA
{
    public partial class FrmSiparisOdemesiTamamla : DevExpress.XtraEditors.XtraForm
    {
        public FrmSiparisOdemesiTamamla()
        {
            InitializeComponent();
        }
        public decimal TotalUcret { get; set; }
        public Siparis yeniSiparis { get; set; }
        public List<SiparisDetayi> siparisVerilenUrunler { get; set; }

        decimal tutar = 0.0m, paraUstu = 0.0m;
       
        private void btnNakitOde_Click(object sender, EventArgs e)
        {

            tutar = Convert.ToDecimal(textEditOdenenTutar.Text);

            if (tutar >= TotalUcret)
            {
                paraUstu = tutar - TotalUcret;
                SiparisiVeritabaninaKaydet();
                MessageBox.Show("Para Üstü: " + paraUstu.ToString());
            }
            else
            {
                MessageBox.Show($" Ödediğiniz toplam ücretten {TotalUcret - tutar:c2}  lira eksiktir!. Lütfen doğru ücret tutarını giriniz! ");
            }
        }

        private void SiparisiVeritabaninaKaydet()
        {
            try
            {
                //Transaction
                SiparisRepo dbSiparisRepo = new SiparisRepo();
                bool siparisKaydedildiMi = dbSiparisRepo.dbMarketContextTranIslemiSiparisveDetayKaydet(yeniSiparis, siparisVerilenUrunler);
                if (siparisKaydedildiMi)
                    MessageBox.Show("Siparişiniz kaydedildi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmSiparisOdemesiTamamla_Load(object sender, EventArgs e)
        {
            UrunRepo dbUrunRepo = new UrunRepo();
            foreach (SiparisDetayi item in siparisVerilenUrunler)
            {
                Urun urun = dbUrunRepo.GetAll().Find(x => x.Barkod == item.UrunBarkodu) as Urun;
                TotalUcret += item.Adet * urun.SatisFiyati;
            }

            OdemeSekliRepo dbOdemeSekli = new OdemeSekliRepo();
            List<OdemeSekli> odemeSekliListesi = dbOdemeSekli.GetAll();
            lookUpOdemeSekli.Properties.DataSource = odemeSekliListesi;
            lookUpOdemeSekli.Properties.ValueMember = "OdemeSekliID";
            lookUpOdemeSekli.Properties.DisplayMember = "OdemeTuru";
            TabControlSiparisTamamla.Visible = false;
            xtraTabPageKrediKarti.PageVisible = false;
            xtraTabPageNakitOdeme.PageVisible = false;
            lblBeklenenUcret.Text += TotalUcret.ToString();
           
        }

        private void lookUpOdemeSekli_EditValueChanged(object sender, EventArgs e)
        {
            TabControlSiparisTamamla.Visible = true;
            switch (Convert.ToInt32(lookUpOdemeSekli.EditValue))
            {
                case 1:

                    xtraTabPageKrediKarti.PageVisible = false;
                    xtraTabPageNakitOdeme.PageVisible = true;
                    break;
                case 2:
                    xtraTabPageKrediKarti.PageVisible = true;
                    xtraTabPageNakitOdeme.PageVisible = false;
                    break;
                default:
                    xtraTabPageKrediKarti.PageVisible = false;
                    xtraTabPageNakitOdeme.PageVisible = false;
                    break;

            }

        }
    }
}