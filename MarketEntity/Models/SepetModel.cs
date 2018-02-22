using MarketEntity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Models
{
    public class SepetModel
    {
        public string Barkod { get; set; }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public double KDV { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Total { get; set; }
    }
}
