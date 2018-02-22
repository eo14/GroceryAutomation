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

namespace MarketDEV.WFA
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            KategoriRepo dbKategori = new KategoriRepo();
            List<Kategori> kategorilerListesi = dbKategori.GetAll();
            lookUpStokKategori.Properties.DataSource = kategorilerListesi;
            lookUpStokKategori.Properties.ValueMember = "KategoriID";
            lookUpStokKategori.Properties.DisplayMember = "KategoriAdi";
        }

        private void lookUpEditSTOKKategori_EditValueChanged(object sender, EventArgs e)
        {
            int katID = Convert.ToInt32((sender as LookUpEdit).EditValue);
            KategoriyeGoreUrunleriGrideGetir(katID);

        }
        List<Urun> urunler = new List<Urun>();
        private void KategoriyeGoreUrunleriGrideGetir(int katID)
        {
            UrunRepo dbUrun = new UrunRepo();
            gridControlStokUrunler.DataSource = null;
            urunler = dbUrun.GetAll().Where(x => x.KategoriID == katID).ToList();
            urunler.ForEach(x=> {
                x.Stok = dbUrun.StokGetir(x.Barkod);
            });
            gridControlStokUrunler.DataSource = urunler;
        }

        private void gridViewStokUrunler_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridViewStokUrunler.GetSelectedRows().Length == 0) return;
            Urun secilenUrun = gridViewStokUrunler.GetFocusedRow() as Urun;
     
        }
     


    }
}