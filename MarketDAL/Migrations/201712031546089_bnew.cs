namespace MarketDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bnew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SiparisDetaylari", "urunAlisFiyati", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SiparisDetaylari", "urunAlisFiyati");
        }
    }
}
