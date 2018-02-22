using MarketEntity.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDAL
{
    public class MarketContext : DbContext
    {
        public MarketContext()
            : base("name=MyCon")
        {

        }

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Tedarikci> Tedarikciler { get; set; }
        public virtual DbSet<OdemeSekli> OdemeSekilleri { get; set; }
        public virtual DbSet<UrunSatis> UrunSatislari { get; set; }
        public virtual DbSet<UrunSatisDetayi> UrunSatisDetaylari { get; set; }

        public virtual DbSet<Siparis> Siparisler { get; set; }
        public virtual DbSet<SiparisDetayi> SiparisDetaylari { get; set; }


    }
}
