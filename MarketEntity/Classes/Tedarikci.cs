using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Classes
{

    [Table("Tedarikciler", Schema = "dbo")]
    public class Tedarikci
    {

        [Key]
        public int TedarikciID { get; set; }
        [StringLength(300), MinLength(2)]
        public string TedarikciFirmaAdi { get; set; }
        [StringLength(100), MinLength(2)]
        public string TedarikciPersonelBilgisi { get; set; }

        [StringLength(10)]
        public string Tel { get; set; }

        [StringLength(400)]
        public string Adres { get; set; }

        [StringLength(30)]
        public string Ilce { get; set; }

        [StringLength(20)]
        public string Il { get; set; }

        public virtual List<Siparis> Siparisler { get; set; }
    }
}
