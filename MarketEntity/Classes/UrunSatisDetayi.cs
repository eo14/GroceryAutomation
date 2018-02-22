using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Classes
{

    [Table("UrunSatisDetaylari", Schema = "dbo")]

    public class UrunSatisDetayi
    {
        [Key]
        [Column(Order = 1)]

        public int SatisID { get; set; }
        [Key]
        [Column(Order =2)]
        public string UrunBarkodu { get; set; }

        public decimal indirim { get; set; }
        public int Adet { get; set; }

        [ForeignKey("UrunBarkodu")]
        public virtual Urun Urun { get; set; }

        [ForeignKey("SatisID")]
        public virtual UrunSatis UrunSatis { get; set; }

    }
}
