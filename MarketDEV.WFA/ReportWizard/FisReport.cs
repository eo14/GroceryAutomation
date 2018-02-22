using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using MarketEntity.Models;
using MarketEntity.Classes;

namespace MarketDEV.WFA.ReportWizard
{
    public partial class FisReport : DevExpress.XtraReports.UI.XtraReport
    {
        public FisReport()
        {
            InitializeComponent();
        }

        public void AlisverisFisi( UrunSatis satis,List<FisModeli> satisListesi)
        {
            pFisNo.Value= satis.SatisID;
            pTarih.Value= DateTime.Now;
            objectDataSource2.DataSource = satisListesi;


        }
    }
}
