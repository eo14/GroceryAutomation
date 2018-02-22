using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Classes
{

    [Table("OdemeSekilleri", Schema = "dbo")]

    public class OdemeSekli
    {

        [Key]
        public int OdemeSekliID { get; set; }
        public OdemeTurleri OdemeTuru { get; set; }
        public virtual List<UrunSatis> UrunSatislar { get; set; }
        public virtual List<Siparis> Siparisler { get; set; }


    }
    public enum OdemeTurleri
    {
        Nakit = 0,
        KrediKarti = 1
    }
}
