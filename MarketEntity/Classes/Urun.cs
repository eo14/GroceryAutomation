using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Classes
{
    [Table("Urunler", Schema = "dbo")]
    public class Urun
    {
        [Key]
        public string Barkod { get; set; }

        [StringLength(300), MinLength(2)]
        public string UrunAdi { get; set; }
        public byte[] UrunResmi { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }

        [NotMapped]
        public int Stok { get; set; } = 1;
        public int KategoriID { get; set; }

        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }  //Navigation Property
        public virtual List<UrunSatisDetayi> UrunSatisDetaylari { get; set; }
        public virtual List<SiparisDetayi> SiparisDetaylari { get; set; }
    }
}
