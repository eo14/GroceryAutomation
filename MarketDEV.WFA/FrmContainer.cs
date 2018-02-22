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

namespace MarketDEV.WFA
{
    public partial class FrmContainer : DevExpress.XtraEditors.XtraForm
    {
        public FrmContainer()
        {
            InitializeComponent();
        }

        private void navBarKategorileriYonet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmKategori kategoriFormu = new FrmKategori();
            kategoriFormu.MdiParent = this;
            kategoriFormu.LayoutMdi(MdiLayout.TileVertical);
            kategoriFormu.WindowState = FormWindowState.Maximized;
            kategoriFormu.Show();
        }

        private void navBarItemUrunleriYonet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmUrun urunFormu = new FrmUrun();
            urunFormu.MdiParent = this;
            urunFormu.LayoutMdi(MdiLayout.TileVertical);
            urunFormu.WindowState = FormWindowState.Maximized;
            urunFormu.Show();
        }

        private void navBarItemStoklariYonet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmStok stokFormu = new FrmStok();
            stokFormu.MdiParent = this;
            stokFormu.LayoutMdi(MdiLayout.TileVertical);
            stokFormu.WindowState = FormWindowState.Maximized;
            stokFormu.Show();
        }

        private void navBarItemSatisYonetimi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmSatis satisFormu = new FrmSatis();
            satisFormu.MdiParent = this;
            satisFormu.LayoutMdi(MdiLayout.TileVertical);
            satisFormu.WindowState = FormWindowState.Maximized;
            satisFormu.Show();

        }

        private void navBarItemTedarikcileriYonet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmTedarikci tedarikciFormu = new FrmTedarikci();
            tedarikciFormu.MdiParent = this;
            tedarikciFormu.LayoutMdi(MdiLayout.TileVertical);
            tedarikciFormu.WindowState = FormWindowState.Maximized;
            tedarikciFormu.Show();
        }

        private void navBarItemSiparisleriYonet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmSiparis siparisFormu = new FrmSiparis();
            siparisFormu.MdiParent = this;
            siparisFormu.LayoutMdi(MdiLayout.TileVertical);
            siparisFormu.WindowState = FormWindowState.Maximized;
            siparisFormu.Show();
        }
    }
}