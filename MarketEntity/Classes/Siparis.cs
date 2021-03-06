﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEntity.Classes
{
    [Table("Siparisler", Schema = "dbo")]

    public class Siparis
    {

        [Key]
        public int SiparisID { get; set; }
        public int TedarikciID { get; set; }
        public  int OdemeSekliID { get; set; }

        public DateTime SiparisVerilmeTarihi { get; set; }
        public bool SiparisTeslimAlindiMi { get; set; }

        [ForeignKey("TedarikciID")]
        public virtual Tedarikci Tedarikci { get; set; }

        [ForeignKey("OdemeSekliID")]
        public virtual OdemeSekli OdemeSekli { get; set; }
        public virtual List<SiparisDetayi> SiparisDetaylari { get; set; }


    }
}
