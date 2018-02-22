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
using MarketBLL.Repository;
using MarketEntity.Classes;
using DevExpress.XtraEditors.Controls;

namespace MarketDEV.WFA
{
    public partial class FrmSiparis : DevExpress.XtraEditors.XtraForm
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            UrunRepo dbUrun = new UrunRepo();
            checkedComboBoxUrunler.Properties.DataSource = dbUrun.GetAll();
            checkedComboBoxUrunler.Properties.DisplayMember = "UrunAdi";
            checkedComboBoxUrunler.Properties.ValueMember = "Barkod";
            TedarikciRepo dbTedarikci = new TedarikciRepo();
            lookUpTedarikciler.Properties.DataSource = dbTedarikci.GetAll();
            lookUpTedarikciler.Properties.DisplayMember = "TedarikciFirmaAdi";
            lookUpTedarikciler.Properties.ValueMember = "TedarikciID";
            GrideSiparisleriGetir();
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            try
            {
                int adet = Convert.ToInt32(spinEditMiktar.EditValue);
                List<SiparisDetayi> detayListesi = new List<SiparisDetayi>();
                if (Convert.ToInt32(lookUpTedarikciler.EditValue) == 0)
                {
                    throw new Exception("Sipariş vermek için TEDARİKÇİ seçimi yapmanız gerekir!");
                }

                Siparis yeniSiparis = new Siparis()
                {
                    TedarikciID = Convert.ToInt32(lookUpTedarikciler.EditValue),
                    OdemeSekliID = 1,
                    SiparisVerilmeTarihi = DateTime.Now,
                    SiparisTeslimAlindiMi = false
                };

                foreach (CheckedListBoxItem item in checkedComboBoxUrunler.Properties.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                    {

                        SiparisDetayi yeniSiparisDetayi = new SiparisDetayi()
                        {
                            SiparisID = yeniSiparis.SiparisID,
                            UrunBarkodu = item.Value.ToString(),
                            Adet = Convert.ToInt32(spinEditMiktar.EditValue)
                        };
                        detayListesi.Add(yeniSiparisDetayi);
                    }
                }
                FrmSiparisOdemesiTamamla siparisTamamlaForm = new FrmSiparisOdemesiTamamla();
                siparisTamamlaForm.yeniSiparis = yeniSiparis;
                siparisTamamlaForm.siparisVerilenUrunler = detayListesi;
                siparisTamamlaForm.ShowDialog();


                GrideSiparisleriGetir();
                GrideSiparisinDetaylariniGetir(yeniSiparis.SiparisID);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GrideSiparisleriGetir()
        {
            SiparisRepo dbRepoSiparis = new SiparisRepo();
            gridControlSiparis.DataSource = dbRepoSiparis.GetAll();
            gridControlSiparisTeslim.DataSource = dbRepoSiparis.GetAll();
        }

        private void GrideSiparisinDetaylariniGetir(int siparisID)
        {
            SiparisDetayiRepo dbSiparisDetayi = new SiparisDetayiRepo();
            gridControlSiparisDetay.DataSource = dbSiparisDetayi.GetAll().Where(x => x.SiparisID == siparisID);
        }

        private void gridViewSiparis_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Siparis secilenSiparis = gridViewSiparis.GetFocusedRow() as Siparis;
            GrideSiparisinDetaylariniGetir(secilenSiparis.SiparisID);
        }

        private void btnSiparisIptalEt_Click(object sender, EventArgs e)
        {
            //Transaction işlemi yapılacak.

            Siparis secilenSiparis = gridViewSiparisTeslim.GetFocusedRow() as Siparis;
            DialogResult cevap = MessageBox.Show("Seçtiğiniz siparişi iptal etmek istediğinize emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                SiparisRepo dbRepoSiparis= new SiparisRepo();
                dbRepoSiparis.dbMarketContextSiparisIptalEt(secilenSiparis);
                MessageBox.Show("sipariş silinmiştir.");
                GrideSiparisleriGetir();
                gridControlSiparisDetay.DataSource = null;
            }
            else
            {
                MessageBox.Show("Siparişin iptal işlemi reddedildi.");
            }
        }

        private void btnSiparisTeslimAlindi_Click(object sender, EventArgs e)
        {
            Siparis secilenSiparis = gridViewSiparisTeslim.GetFocusedRow() as Siparis;
            SiparisRepo dbRepoSiparis = new SiparisRepo();
            secilenSiparis.SiparisTeslimAlindiMi = true;
            dbRepoSiparis.Update();
            SiparisDetayiRepo dbRepoDetay = new SiparisDetayiRepo();
            List<SiparisDetayi> liste = new List<SiparisDetayi>();
            liste = dbRepoDetay.GetAll().Where(x => x.SiparisID == secilenSiparis.SiparisID).ToList();
            UrunRepo dbUrunReposu = new UrunRepo();
            liste.ForEach(
                x =>
                MessageBox.Show(dbUrunReposu.StokGetir(x.UrunBarkodu).ToString())
               );
            MessageBox.Show("Teslim alınan siparişler stoğa işlendi.");
        }
    }
}
