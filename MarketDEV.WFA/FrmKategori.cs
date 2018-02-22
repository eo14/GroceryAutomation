using MarketBLL.Repository;
using MarketEntity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace MarketDEV.WFA
{
    public partial class FrmKategori : DevExpress.XtraEditors.XtraForm
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
            gridViewKategori.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewKategori.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridViewKategori.OptionsSelection.EnableAppearanceHideSelection = false;
        }

        private void KategorileriGetir()
        {
            KategoriRepo dbKategori = new KategoriRepo();
            gridControlKategori.DataSource = dbKategori.GetAll();

        }
        private void btnKategoriKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtKategoriAdi.Text == null || txtKategoriTanimi.Text == null)
            {
                MessageBox.Show("Kategori eklemek için gerekli bilgileri doldurunuz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                KategoriRepo dbKategori = new KategoriRepo();
                double kdv = Convert.ToDouble(spinEditKDV.EditValue);
                dbKategori.Insert(new Kategori()
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    KategoriTanimi = txtKategoriTanimi.Text,
                    KDV = kdv != 0 ? kdv : 18
                });

                MessageBox.Show("Yeni kategori eklenmiştir.");
                KategorileriGetir();
                TextleriTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TextleriTemizle()
        {
            txtKategoriAdi.Text = string.Empty;
            txtKategoriTanimi.Text = string.Empty;
            spinEditKDV.EditValue = 0;
        }

        private void btnUrunlereGecis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrun Urunformu = new FrmUrun();
            Urunformu.Show();
            this.Hide();
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewKategori.GetSelectedRows().Length == 0) return;
            Kategori seciliKategori =  gridViewKategori.GetFocusedRow() as Kategori;
            KategoriRepo dbKategori = new KategoriRepo();
            seciliKategori.KategoriAdi = txtKategoriAdi.Text;
            seciliKategori.KategoriTanimi = txtKategoriTanimi.Text;
            seciliKategori.KDV =Convert.ToDouble(spinEditKDV.EditValue);
            dbKategori.Update();
            MessageBox.Show("kategori Güncellendi.");
            KategorileriGetir();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewKategori.GetSelectedRows().Length == 0) return;
            Kategori seciliKategori = gridViewKategori.GetFocusedRow() as Kategori;
            txtKategoriAdi.Text = seciliKategori.KategoriAdi;
            txtKategoriTanimi.Text = seciliKategori.KategoriTanimi;
            spinEditKDV.EditValue = seciliKategori.KDV;

        }
        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewKategori.GetSelectedRows().Length == 0) return;
            Kategori seciliKategori = gridViewKategori.GetFocusedRow() as Kategori;
            UrunRepo dbUrun = new UrunRepo();
            List<Urun> seciliKatUrunleri = dbUrun.GetAll().Where(x => x.KategoriID == seciliKategori.KategoriID).ToList();
            if (seciliKatUrunleri.Count > 0)
                MessageBox.Show($"Ürünleri olan bu kategoriyi silemezsiniz.");
            else
            {
                KategoriRepo dbKategori = new KategoriRepo();
                dbKategori.Delete(seciliKategori);
                MessageBox.Show("Kategori silinmiştir.");
            }
            KategorileriGetir();
        }

        private void gridViewKategori_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridViewKategori.GetSelectedRows().Length == 0) return;
             Kategori seciliKategori= gridViewKategori.GetFocusedRow() as Kategori;
            txtKategoriAdi.Text = seciliKategori.KategoriAdi;
            txtKategoriTanimi.Text = seciliKategori.KategoriTanimi;
            spinEditKDV.EditValue = seciliKategori.KDV;
        }

      
    }
}
