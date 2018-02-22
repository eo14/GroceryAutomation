using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Classes
{

    [Table("UrunSatislar", Schema = "dbo")]

    public class UrunSatis
    {
        [Key]
        public int SatisID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public int OdemeSekliID { get; set; }

        [ForeignKey("OdemeSekliID")]
        public virtual OdemeSekli OdemeSekli { get; set; }
        public virtual List<UrunSatisDetayi> UrunSatisDetaylari { get; set; }

    }
}
