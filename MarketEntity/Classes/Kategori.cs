using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Classes
{

    [Table("Kategoriler", Schema = "dbo")]

    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [StringLength(50), MinLength(2)]
        public string KategoriAdi { get; set; }
        [StringLength(300), MinLength(2)]
        public string KategoriTanimi { get; set; }
        public double KDV { get; set; } = 18;

        public virtual List<Urun> Urunler { get; set; } //Navigation Property.
        public override string ToString()
        {
            return $"{KategoriAdi}";
        }
    }
}
