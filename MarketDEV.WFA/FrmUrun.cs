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
using DevExpress.XtraBars;

namespace MarketDEV.WFA
{
    public partial class FrmUrun : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        public string islemim = string.Empty;
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            KategorileriComboyaDoldur();
            btnKaydet.Visibility = BarItemVisibility.Never;
        }

        private void KategoriyeGoreUrunleriGrideGetir(int katID)
        {
            UrunRepo dbUrun = new UrunRepo();
            gridControlUrunler.DataSource = dbUrun.GetAll().Where(x => x.KategoriID == katID).ToList();
        }

        private void KategorileriComboyaDoldur()
        {
            KategoriRepo dbKategori = new KategoriRepo();
            List<Kategori> kategorilerListesi = dbKategori.GetAll();
            LookUpKategori.Properties.DataSource = kategorilerListesi;
            LookUpKategori.Properties.ValueMember = "KategoriID";
            LookUpKategori.Properties.DisplayMember = "KategoriAdi";
        }

        private void btnKategoriyeGecis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKategori KategoriForm = new FrmKategori();
            KategoriForm.Show();
            this.Hide();

        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (islemim)
            {
                case "insert":
                    YeniKategoriEkle();
                    break;
                case "update":
                    KategoriGuncelle(gridViewUrunler.GetFocusedRow() as Urun);
                    break;
                default:
                    islemim = string.Empty;
                    break;
            }
            btnKaydet.Visibility = BarItemVisibility.Never;
            ribbonPageGroupIslemler.Visible = true;
            KategoriyeGoreUrunleriGrideGetir(Convert.ToInt32(LookUpKategori.EditValue));
        }

        private void KategoriGuncelle(Urun guncellenecekUrun)
        {
            UrunRepo dbUrun = new UrunRepo();
            guncellenecekUrun.UrunAdi = txtUrunAdi.Text;
            guncellenecekUrun.KategoriID = Convert.ToInt32(LookUpKategori.EditValue);
            guncellenecekUrun.AlisFiyati = spinEditAlisFiyati.Value;
            guncellenecekUrun.SatisFiyati = spinEditSatisFiyati.Value;
            // seciliUrun.UrunResmi
            dbUrun.Update();
            MessageBox.Show("Ürün güncellendi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void YeniKategoriEkle()
        {
            if (LookUpKategori.EditValue == null)
            {
                MessageBox.Show("Kategori seçimi yapınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtBarkod.Text == null || txtUrunAdi.Text == null)
            {
                MessageBox.Show("Ürün eklemek için bilgilerini giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UrunRepo dbUrun = new UrunRepo();
                Urun yeniUrun = new Urun()
                {
                    Barkod = txtBarkod.Text,
                    UrunAdi = txtUrunAdi.Text,
                    KategoriID = Convert.ToInt32(LookUpKategori.EditValue),
                    AlisFiyati = spinEditAlisFiyati.Value,
                    SatisFiyati = spinEditSatisFiyati.Value
                };
                dbUrun.Insert(yeniUrun);
                MessageBox.Show("Yeni Ürün Eklendir");
                KategoriyeGoreUrunleriGrideGetir(Convert.ToInt32(LookUpKategori.EditValue));

            }
        }

        void TextleriTemizle()
        {
            txtBarkod.Text = string.Empty;
            txtUrunAdi.Text = string.Empty;
            spinEditSatisFiyati.Value = 0;
            spinEditAlisFiyati.Value = 0;
        }
        private void LookUpKategori_EditValueChanged(object sender, EventArgs e)
        {

            int katID = Convert.ToInt32((sender as LookUpEdit).EditValue);
            KategoriyeGoreUrunleriGrideGetir(katID);
            TextleriTemizle();

        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewUrunler.GetSelectedRows().Length == 0) return;
            txtBarkod.Enabled = false;
            btnKaydet.Visibility = BarItemVisibility.Always;
            ribbonPageGroupIslemler.Visible = false;
            islemim = "update";
        }

        private void gridViewUrunler_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridViewUrunler.GetSelectedRows().Length == 0) return;
            Urun secilenUrun = gridViewUrunler.GetFocusedRow() as Urun;
            LookUpKategori.EditValue = Convert.ToInt32(secilenUrun.KategoriID);
            txtBarkod.Text = secilenUrun.Barkod;
            txtUrunAdi.Text= secilenUrun.UrunAdi;
            spinEditAlisFiyati.Value = secilenUrun.AlisFiyati;
            spinEditSatisFiyati.Value = secilenUrun.SatisFiyati;
        }

        private void urunPictureEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewUrunler.GetSelectedRows().Length == 0) return;
            Urun secilenUrun = gridViewUrunler.GetFocusedRow() as Urun;
            if(secilenUrun.Stok> 1 )
            {
               DialogResult cevap= MessageBox.Show("Seçtiğiniz ürünün birden çokstok değerleri bulunuyor. Stok sayfasına yönlendirilmek ister misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(cevap==DialogResult.Yes)
                {
                    this.Hide();
                    FrmStok stokFormu = new FrmStok();
                    stokFormu.ShowDialog();
                }
            }

        }

        private void btnYeniUrun_ItemClick(object sender, ItemClickEventArgs e)
        {
            TextleriTemizle();
            ribbonPageGroupIslemler.Visible = false;
            btnKaydet.Visibility = BarItemVisibility.Always;
            islemim = "insert";
        }
    }
}