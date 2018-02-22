namespace MarketDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(maxLength: 50),
                        KategoriTanimi = c.String(maxLength: 300),
                        KDV = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Barkod = c.String(nullable: false, maxLength: 128),
                        UrunAdi = c.String(maxLength: 300),
                        UrunResmi = c.Binary(),
                        AlisFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SatisFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KategoriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Barkod)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriID, cascadeDelete: true)
                .Index(t => t.KategoriID);
            
            CreateTable(
                "dbo.UrunSatisDetaylari",
                c => new
                    {
                        SatisID = c.Int(nullable: false),
                        UrunBarkodu = c.String(nullable: false, maxLength: 128),
                        indirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Adet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SatisID, t.UrunBarkodu })
                .ForeignKey("dbo.Urunler", t => t.UrunBarkodu, cascadeDelete: true)
                .ForeignKey("dbo.UrunSatislar", t => t.SatisID, cascadeDelete: true)
                .Index(t => t.SatisID)
                .Index(t => t.UrunBarkodu);
            
            CreateTable(
                "dbo.UrunSatislar",
                c => new
                    {
                        SatisID = c.Int(nullable: false, identity: true),
                        SatisTarihi = c.DateTime(nullable: false),
                        OdemeSekliID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SatisID)
                .ForeignKey("dbo.OdemeSekilleri", t => t.OdemeSekliID, cascadeDelete: true)
                .Index(t => t.OdemeSekliID);
            
            CreateTable(
                "dbo.OdemeSekilleri",
                c => new
                    {
                        OdemeSekliID = c.Int(nullable: false, identity: true),
                        OdemeTuru = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OdemeSekliID);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        SiparisID = c.Int(nullable: false, identity: true),
                        TedarikciID = c.Int(nullable: false),
                        OdemeSekliID = c.Int(nullable: false),
                        SiparisVerilmeTarihi = c.DateTime(nullable: false),
                        SiparisTeslimAlindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SiparisID)
                .ForeignKey("dbo.OdemeSekilleri", t => t.OdemeSekliID, cascadeDelete: true)
                .ForeignKey("dbo.Tedarikciler", t => t.TedarikciID, cascadeDelete: true)
                .Index(t => t.TedarikciID)
                .Index(t => t.OdemeSekliID);
            
            CreateTable(
                "dbo.SiparisDetaylari",
                c => new
                    {
                        SiparisID = c.Int(nullable: false),
                        UrunBarkodu = c.String(nullable: false, maxLength: 128),
                        Indirim = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SiparisID, t.UrunBarkodu })
                .ForeignKey("dbo.Siparisler", t => t.SiparisID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunBarkodu, cascadeDelete: true)
                .Index(t => t.SiparisID)
                .Index(t => t.UrunBarkodu);
            
            CreateTable(
                "dbo.Tedarikciler",
                c => new
                    {
                        TedarikciID = c.Int(nullable: false, identity: true),
                        TedarikciFirmaAdi = c.String(maxLength: 300),
                        TedarikciPersonelBilgisi = c.String(maxLength: 100),
                        Tel = c.String(maxLength: 10),
                        Adres = c.String(maxLength: 400),
                        Ilce = c.String(maxLength: 30),
                        Il = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.TedarikciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UrunSatisDetaylari", "SatisID", "dbo.UrunSatislar");
            DropForeignKey("dbo.UrunSatislar", "OdemeSekliID", "dbo.OdemeSekilleri");
            DropForeignKey("dbo.Siparisler", "TedarikciID", "dbo.Tedarikciler");
            DropForeignKey("dbo.SiparisDetaylari", "UrunBarkodu", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetaylari", "SiparisID", "dbo.Siparisler");
            DropForeignKey("dbo.Siparisler", "OdemeSekliID", "dbo.OdemeSekilleri");
            DropForeignKey("dbo.UrunSatisDetaylari", "UrunBarkodu", "dbo.Urunler");
            DropForeignKey("dbo.Urunler", "KategoriID", "dbo.Kategoriler");
            DropIndex("dbo.SiparisDetaylari", new[] { "UrunBarkodu" });
            DropIndex("dbo.SiparisDetaylari", new[] { "SiparisID" });
            DropIndex("dbo.Siparisler", new[] { "OdemeSekliID" });
            DropIndex("dbo.Siparisler", new[] { "TedarikciID" });
            DropIndex("dbo.UrunSatislar", new[] { "OdemeSekliID" });
            DropIndex("dbo.UrunSatisDetaylari", new[] { "UrunBarkodu" });
            DropIndex("dbo.UrunSatisDetaylari", new[] { "SatisID" });
            DropIndex("dbo.Urunler", new[] { "KategoriID" });
            DropTable("dbo.Tedarikciler");
            DropTable("dbo.SiparisDetaylari");
            DropTable("dbo.Siparisler");
            DropTable("dbo.OdemeSekilleri");
            DropTable("dbo.UrunSatislar");
            DropTable("dbo.UrunSatisDetaylari");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
