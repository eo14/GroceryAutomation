using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Classes
{
    [Table("SiparisDetaylari", Schema = "dbo")]

    public   class SiparisDetayi
    {
        [Key]
        [Column(Order = 1)]
        public int SiparisID { get; set; }
        [Key]
        [Column(Order = 2)]
        public string UrunBarkodu { get; set; }
        public int Indirim { get; set; }
        public int Adet { get; set; }

        public decimal urunAlisFiyati { get; set; }

        [ForeignKey("UrunBarkodu")]
        public virtual Urun Urun { get; set; } //Navigation Property

        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; } //Navigation Property

    }
}
