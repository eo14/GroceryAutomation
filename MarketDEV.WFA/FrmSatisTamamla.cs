using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;
using MarketBLL.Repository;
using MarketEntity.Classes;
using MarketEntity.Models;
using MarketDEV.WFA.ReportWizard;

namespace MarketDEV.WFA
{
    public partial class FrmSatisTamamla : DevExpress.XtraEditors.XtraForm
    {
        public FrmSatisTamamla()
        {
            InitializeComponent();
        }
        public List<SepetModel> Sepet { get; set; }
        public decimal TotalUcret { get; set; }
        private void FrmSiparisTamamla_Load(object sender, EventArgs e)
        {
            OdemeSekliRepo dbOdemeSekli = new OdemeSekliRepo();
            List<OdemeSekli> odemeSekliListesi = dbOdemeSekli.GetAll();
            lookUpOdemeSekli.Properties.DataSource = odemeSekliListesi;
            lookUpOdemeSekli.Properties.ValueMember = "OdemeSekliID";
            lookUpOdemeSekli.Properties.DisplayMember = "OdemeTuru";
            TabControlSiparisTamamla.Visible = false;
            xtraTabPageKrediKarti.PageVisible = false;
            xtraTabPageNakitOdeme.PageVisible = false;
            lblBeklenenUcret.Text += TotalUcret.ToString();
            btnNakitOde.Visible = true;
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
        decimal tutar = 0.0m, paraUstu = 0.0m;
        private void btnOde_Click(object sender, EventArgs e)
        {
            tutar = Convert.ToDecimal(textEditOdenenTutar.Text);

            if (tutar >= TotalUcret)
            {
                paraUstu = tutar - TotalUcret;
                SatisiVeriTabaninaKaydet();
            }
            else
            {
                MessageBox.Show($" Ödediğiniz toplam ücretten {TotalUcret - tutar:c2}  lira eksiktir!. Lütfen doğru ücret tutarını giriniz! ");
            }

        }

        private void SatisiVeriTabaninaKaydet()
        {
            //Transaction işlemi
            try
            {
                //yeniSatis oluştur
                UrunSatis yeniSatis = new UrunSatis()
                {
                    SatisTarihi = DateTime.Now,
                    OdemeSekliID = Convert.ToInt32(lookUpOdemeSekli.EditValue)
                };

                //satışa ait detayları oluştur.
                List<UrunSatisDetayi> satilanUrunListesi = new List<UrunSatisDetayi>();
                Sepet.ForEach(x =>
                satilanUrunListesi.Add(new UrunSatisDetayi()
                {
                    SatisID = yeniSatis.SatisID,
                    UrunBarkodu = x.Barkod,
                    Adet = x.Adet
                }));

                UrunSatisRepo dburunSatisRepo = new UrunSatisRepo();
                bool satisKaydedildiMi = dburunSatisRepo.dbMarketContextTranIslemiSatisveDetayKaydet(yeniSatis, satilanUrunListesi);
                if (satisKaydedildiMi)
                {
                    MessageBox.Show("SATIŞ GERÇEKLEŞTİ. Ürünlerinizi iyi günlerde kullanın.");
                    txtFis.Text = String.Empty;
                    btnNakitOde.Visible = false;

                    //
                    List<FisModeli> fisUrunlerListesi = new List<FisModeli>();
                    foreach (var item in satilanUrunListesi)
                    {
                        fisUrunlerListesi.Add(new FisModeli()
                        {
                            SatisID=item.SatisID,
                            Adet=item.Adet,
                            //BirimFiyati = item.Urun.SatisFiyati,
                            //KdvOrani=item.Urun.Kategori.KDV,
                            //UrunAdi=item.Urun.UrunAdi
                        });
                    }
                    FisOlustur(yeniSatis, fisUrunlerListesi);
                    txtFis.Text = String.Empty;
                    btnNakitOde.Visible = false;
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void FisOlustur(UrunSatis satis, List<FisModeli> fisUrunlerListesi)
        {
            FisReport Fis = new FisReport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Fis.Parameters)
            {
                p.Visible = false;
            }
            Fis.AlisverisFisi(satis, fisUrunlerListesi);
            DocViewAlisverisFisi.DocumentSource = Fis;
            Fis.CreateDocument();
        }

    }
}