using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Models
{
  public  class FisModeli
    {
        private decimal _toplamTutar = 0.0m;
        private decimal _kdvMiktari = 0.0m;
        public int SatisID { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyati { get; set; }
        public double KdvOrani { get; set; }
        public decimal KdvMiktari
        {

            get
            {
                return _kdvMiktari;
            }
            set
            {
                _kdvMiktari = ToplamTutar - (ToplamTutar * Convert.ToDecimal(KdvOrani / 100));
            }
        }
        public int Adet { get; set; }
        
        public decimal ToplamTutar { get

            {
                return _toplamTutar;
            }
            set
            {
                _toplamTutar = Adet * BirimFiyati;

            } }

    }
}
