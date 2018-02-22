using MarketDAL;
using MarketEntity.Classes;
using MarketEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketBLL.Repository
{

    public class KategoriRepo : RepositoryBase<Kategori, int> { }
    public class UrunRepo : RepositoryBase<Urun, string>
    {
        public int StokGetir(string barkod)
        {
            int fark = 0;

            List<UrunSatisDetayi> urunSatisDetayListesi = new UrunSatisDetayiRepo().GetAll();

            List<SiparisDetayi> siparisDetayListesi = new SiparisDetayiRepo().GetAll();
            int satilanAdet = 0, siparisAdet = 0;
            int mevcutStok = (new UrunRepo().GetAll().Find(x => x.Barkod == barkod) as Urun).Stok;
            foreach (UrunSatisDetayi item in urunSatisDetayListesi)
            {
                if (item.UrunBarkodu == barkod)
                    satilanAdet += item.Adet;
            }
            foreach (SiparisDetayi item in siparisDetayListesi)
            {
                if (item.Siparis.SiparisTeslimAlindiMi != true) break;
                if (item.UrunBarkodu == barkod)
                    siparisAdet += item.Adet;
            }
            if (siparisAdet > satilanAdet)
            {
                fark = siparisAdet - satilanAdet;
                fark += mevcutStok;
            }
            else if (satilanAdet >= siparisAdet)
            {
                fark = siparisAdet - satilanAdet;
                fark += mevcutStok;
            }
            if (fark == 0)
            {
                fark = mevcutStok;
            }
            return fark;
        }
    }
    public class OdemeSekliRepo : RepositoryBase<OdemeSekli, int> { }
    public class SiparisRepo : RepositoryBase<Siparis, int>
    {
        public bool dbMarketContextTranIslemiSiparisveDetayKaydet(Siparis yeniSiparis, List<SiparisDetayi> SiparisDetayListesi)
        {
            MarketContext db = new MarketContext();
            bool durum = false;
            using (var tran = db.Database.BeginTransaction())
            {

                try
                {
                    db.Siparisler.Add(yeniSiparis);
                    db.SaveChanges();

                    foreach (SiparisDetayi item in SiparisDetayListesi)
                    {
                        item.SiparisID = yeniSiparis.SiparisID;
                        db.SiparisDetaylari.Add(item);
                    }
                    db.SaveChanges();
                    tran.Commit();
                    durum = true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            return durum;
        }

        public bool dbMarketContextSiparisIptalEt(Siparis siparis)
        {
            List<SiparisDetayi> siparisDetaylari = new SiparisDetayiRepo().GetAll().Where(x => x.SiparisID == siparis.SiparisID).ToList();
            bool iptalDurumu = false;
            MarketContext db = new MarketContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (SiparisDetayi item in siparisDetaylari)
                    {
                        db.SiparisDetaylari.Remove(item);
                        db.SaveChanges();
                    }

                    db.Siparisler.Remove(siparis);
                    db.SaveChanges();
                    iptalDurumu = true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }

            }

            return iptalDurumu;
        }

    }

    public class SiparisDetayiRepo : RepositoryBase<SiparisDetayi, int> { }

    public class TedarikciRepo : RepositoryBase<Tedarikci, int> { }

    public class UrunSatisRepo : RepositoryBase<UrunSatis, int>
    {

        public bool dbMarketContextTranIslemiSatisveDetayKaydet(UrunSatis yeniSatis, List<UrunSatisDetayi> SatisDetayListesi)
        {
            MarketContext db = new MarketContext();
            bool durum = false;
            using (var tran = db.Database.BeginTransaction())
            {

                try
                {
                    db.UrunSatislari.Add(yeniSatis);
                    db.SaveChanges();

                    foreach (UrunSatisDetayi item in SatisDetayListesi)
                    {
                        item.SatisID = yeniSatis.SatisID;
                        db.UrunSatisDetaylari.Add(item);
                    }
                    db.SaveChanges();
                    tran.Commit();
                    durum = true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            return durum;
        }


    }
    public class UrunSatisDetayiRepo : RepositoryBase<UrunSatisDetayi, int> { }



}
