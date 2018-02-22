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
    public partial class FrmTedarikci : DevExpress.XtraEditors.XtraForm
    {
        public FrmTedarikci()
        {
            InitializeComponent();
        }
        string islem = string.Empty;
        private void FrmTedarikci_Load(object sender, EventArgs e)
        {
            btnKaydet.Visible = false;
            TedarikcileriGetir();
        }

        void TextleriTemizle()
        {
            txtFirmaAdi.Text = string.Empty;
            txtPersonelBilgisi.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtIl.Text = string.Empty;
            txtIlce.Text = string.Empty;
            txtAdres.Text = string.Empty;
        }
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            TextleriTemizle();
            btnYeniKayit.Visible = false;
            btnTedarikciGuncelle.Visible = false;
            btnTedarikciSil.Visible = false;
            btnKaydet.Visible = true;
            islem = "insert";

        }

        private void btnTedarikciGuncelle_Click(object sender, EventArgs e)
        {
            if (gridViewTedarikci.GetSelectedRows().Length == 0) return;
            btnYeniKayit.Visible = false;
            btnTedarikciGuncelle.Visible = false;
            btnTedarikciSil.Visible = false;
            btnKaydet.Visible = true;
            islem = "update";
        }

        private void btnTedarikciSil_Click(object sender, EventArgs e)
        {
            if (gridViewTedarikci.GetSelectedRows().Length == 0) return;
            btnYeniKayit.Visible = false;
            btnTedarikciGuncelle.Visible = false;
            btnTedarikciSil.Visible = false;
            btnKaydet.Visible = true;
            Tedarikci secilenTedarikci = gridViewTedarikci.GetFocusedRow() as Tedarikci;
            islem = "delete";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TedarikciRepo dbTedarikci = new TedarikciRepo();
            switch (islem)
            {
                case "insert":
                    Tedarikci yeniTedarikci = new Tedarikci()
                    {
                        TedarikciFirmaAdi = txtFirmaAdi.Text,
                        TedarikciPersonelBilgisi = txtPersonelBilgisi.Text,
                        Tel = txtTelefon.Text,
                        Adres = txtAdres.Text,
                        Ilce = txtIlce.Text,
                        Il = txtIl.Text
                    };
                    dbTedarikci.Insert(yeniTedarikci);
                    MessageBox.Show("Yeni Tedarikçi Eklendi!");
                    TedarikcileriGetir();
                    break;
                case "update":
                    Tedarikci secilenTedarikci = gridViewTedarikci.GetFocusedRow() as Tedarikci;
                    secilenTedarikci.TedarikciFirmaAdi = txtFirmaAdi.Text;
                    secilenTedarikci.TedarikciPersonelBilgisi = txtPersonelBilgisi.Text;
                    secilenTedarikci.Tel = txtTelefon.Text;
                    secilenTedarikci.Adres = txtAdres.Text;
                    secilenTedarikci.Ilce = txtIlce.Text;
                    secilenTedarikci.Il = txtIl.Text;
                    dbTedarikci.Update();
                    MessageBox.Show("Tedarikçi Güncellendi!");
                    TedarikcileriGetir();
                    break;
                case "delete":
                    Tedarikci seciliTedarikci = gridViewTedarikci.GetFocusedRow() as Tedarikci;
                    SiparisRepo dbSiparis = new SiparisRepo();
                    List<Siparis> tedarikcininSiparisListesi = new List<Siparis>();
                    tedarikcininSiparisListesi = dbSiparis.GetAll().Where(x => x.TedarikciID == seciliTedarikci.TedarikciID).ToList();
                    if (tedarikcininSiparisListesi.Count > 0)
                    {
                        MessageBox.Show($"{seciliTedarikci.TedarikciFirmaAdi} - {seciliTedarikci.TedarikciPersonelBilgisi}  isimli firmanın siparis işlemleri bulunuyor. Bu tedarikçi firmayı silemezsiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        dbTedarikci.Delete(seciliTedarikci);
                        MessageBox.Show($"{seciliTedarikci.TedarikciFirmaAdi} artık silinmiştir.");
                        TedarikcileriGetir();
                    }
                    break;
            }
            btnKaydet.Visible = false;
            btnYeniKayit.Visible = true;
            btnTedarikciGuncelle.Visible = true;
            btnTedarikciSil.Visible = true;
        }

        private void TedarikcileriGetir()
        {
            TedarikciRepo dbTedarikci = new TedarikciRepo();
            gridControlTedarikci.DataSource = dbTedarikci.GetAll();
        }

        private void gridViewTedarikci_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridViewTedarikci.GetSelectedRows().Length == 0) return;
            Tedarikci gridSecilenTedarikci = gridViewTedarikci.GetFocusedRow() as Tedarikci;
            txtFirmaAdi.Text = gridSecilenTedarikci.TedarikciFirmaAdi;
            txtPersonelBilgisi.Text = gridSecilenTedarikci.TedarikciPersonelBilgisi;
            txtTelefon.Text = gridSecilenTedarikci.Tel;
            txtAdres.Text = gridSecilenTedarikci.Adres;
            txtIlce.Text = gridSecilenTedarikci.Ilce;
            txtIl.Text = gridSecilenTedarikci.Il;
        }
    }
}