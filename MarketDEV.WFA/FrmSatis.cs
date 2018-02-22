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
using MarketEntity.Models;
using MarketBLL.Repository;
using MarketEntity.Classes;

namespace MarketDEV.WFA
{
    public partial class FrmSatis : DevExpress.XtraEditors.XtraForm
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        List<SepetModel> sepettekiUrunler = new List<SepetModel>();
        bool urunSepetteVarmi = false;
        decimal totalUcret = 0.0m;
        private void FrmSatis_Load(object sender, EventArgs e)
        {
            btnAlisverisiTamamla.Enabled = false;
            spinEditAdet.EditValue = 1;
        }

        void GridYenile()
        {
            gridControlSatis.DataSource = null;
            gridControlSatis.DataSource = sepettekiUrunler;
            totalUcret = 0.0m;
            foreach (SepetModel item in sepettekiUrunler)
            {
                totalUcret += item.Total;
            }
            lblTotalUcret.Text = totalUcret.ToString();
        }
        private void UrunStoktaVarmi()
        {
            UrunRepo dbUrunRepo = new UrunRepo();
            foreach (var item in sepettekiUrunler)
            {
                Urun urun = dbUrunRepo.GetAll().Find(x => x.Barkod == item.Barkod);
                if (urun.Stok < Convert.ToInt32(spinEditAdet.EditValue))
                    throw new Exception($"Bu üründen stokta {item.Adet} adet ürün bulunuyor! Satış yapmak için stokları yenileyiniz.");
            }
        }

        private void txtSatisBarkod_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (SepetModel item in sepettekiUrunler)
                {
                    if (item.Barkod == txtSatisBarkod.Text)
                        urunSepetteVarmi = true;
                    else
                        urunSepetteVarmi = false;
                }
                UrunRepo dbUrun = new UrunRepo();
                var urun = dbUrun.GetByID(txtSatisBarkod.Text);
                if (urun == null)
                {
                    DialogResult cevap = MessageBox.Show("Bu ürün sisteme eklenmemiş! Ürünler sayfasına gitmek ister misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (cevap == DialogResult.Yes)
                    {
                        FrmUrun urunFrm = new FrmUrun();
                        urunFrm.ShowDialog();
                        urunFrm.WindowState = FormWindowState.Maximized;
                    }
                    return;
                }
                if (!urunSepetteVarmi)
                {
                    SepetModel yeniUrun = new SepetModel()
                    {
                        UrunAdi = urun.UrunAdi,
                        Barkod = urun.Barkod,
                        KDV = urun.Kategori.KDV,
                        Adet = Convert.ToInt32(spinEditAdet.EditValue),
                        BirimFiyat = urun.SatisFiyati - Convert.ToDecimal(urun.Kategori.KDV / 100),
                    };
                    yeniUrun.Total = yeniUrun.Adet * (yeniUrun.BirimFiyat + Convert.ToDecimal(yeniUrun.KDV / 100));
                    sepettekiUrunler.Add(yeniUrun);
                }
                else
                {
                    foreach (var item in sepettekiUrunler)
                    {
                        if (item.Barkod == txtSatisBarkod.Text)
                        {
                            item.Adet += Convert.ToInt32(spinEditAdet.EditValue);
                            item.Total = item.Adet * (item.BirimFiyat + Convert.ToDecimal(item.KDV / 100));
                        }
                    }
                }

                GridYenile();
                btnAlisverisiTamamla.Enabled = true;
            }
        }

        private void btnAlisverisiTamamla_Click(object sender, EventArgs e)
        {
            try
            {
                UrunStoktaVarmi();
                int sepettekiUrunAdeti = 0;
                foreach (var item in sepettekiUrunler)
                {
                    sepettekiUrunAdeti += item.Adet;

                }

                DialogResult cevap =
                    MessageBox.Show($"Sepetinizdeki {sepettekiUrunAdeti} adet ürün için {totalUcret:c2} tutarındaki alışverişinizi tamamlamak istiyor musunuz?", "ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (cevap)
                {

                    case DialogResult.Yes:

                        MessageBox.Show("Siparişiniz kayıt edildi! Ödeme sayfası yükleniyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SiparisiKaydet();
                        break;
                    case DialogResult.No:
                        SiparisIptalEt();
                        MessageBox.Show("Siparişiniz iptal edilmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SiparisIptalEt()
        {
            sepettekiUrunler.Clear();
            GridYenile();
        }

        private void SiparisiKaydet()
        {

            FrmSatisTamamla siparisTamamlaForm = new FrmSatisTamamla();
            siparisTamamlaForm.TotalUcret = totalUcret;
            siparisTamamlaForm.Sepet = sepettekiUrunler;
            siparisTamamlaForm.ShowDialog();
        }

        private void sepettenÇıkartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunuSepettenCikart();

        }

        private void UrunuSepettenCikart()
        {
            if (gridView1.GetSelectedRows().Count() == 0) return;
            SepetModel seciliSepetModel = gridView1.GetFocusedRow() as SepetModel;

            for (int i = 0; i < sepettekiUrunler.Count; i++)
            {
                if (sepettekiUrunler[i].Barkod == seciliSepetModel.Barkod)
                    sepettekiUrunler.Remove(sepettekiUrunler[i]);
            }
            GridYenile();
        }

        private void ürünAdetiArttırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Count() == 0) return;
            SepetModel seciliSepetModel = gridView1.GetFocusedRow() as SepetModel;

            foreach (var item in sepettekiUrunler)
            {
                if (item.Barkod == seciliSepetModel.Barkod)
                    item.Adet++;
            }
            GridYenile();
        }

        private void ürünAdetiAzaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Count() == 0) return;
            SepetModel seciliSepetModel = gridView1.GetFocusedRow() as SepetModel;

            for (int i = 0; i < sepettekiUrunler.Count; i++)
            {
                if (sepettekiUrunler[i].Barkod == seciliSepetModel.Barkod)
                {
                    if (sepettekiUrunler[i].Adet > 1)
                        sepettekiUrunler[i].Adet--;
                    else
                    {
                        UrunuSepettenCikart();
                    }
                }
            }
            GridYenile();
        }
    }
}