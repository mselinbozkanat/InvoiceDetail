namespace FaturaProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Birim",
                c => new
                    {
                        BirimID = c.Int(nullable: false, identity: true),
                        BirimAd = c.String(),
                    })
                .PrimaryKey(t => t.BirimID);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(),
                        UrunKodu = c.String(),
                        BirimID = c.Int(nullable: false),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.UrunID)
                .ForeignKey("dbo.Birim", t => t.BirimID, cascadeDelete: true)
                .Index(t => t.BirimID);
            
            CreateTable(
                "dbo.FaturaDetay",
                c => new
                    {
                        FaturaID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ToplamFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KDVliFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FaturaToplam = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => new { t.FaturaID, t.UrunID })
                .ForeignKey("dbo.FaturaMaster", t => t.FaturaID, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.FaturaID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.FaturaMaster",
                c => new
                    {
                        FaturaID = c.Int(nullable: false, identity: true),
                        MusteriID = c.Int(nullable: false),
                        FaturaTarihi = c.DateTime(nullable: false),
                        IrsaliyeNo = c.Int(nullable: false),
                        OdemeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FaturaID)
                .ForeignKey("dbo.Musteri", t => t.MusteriID, cascadeDelete: true)
                .Index(t => t.MusteriID);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriUnvani = c.String(),
                        IlceID = c.Int(nullable: false),
                        MusteriAdresi = c.String(),
                    })
                .PrimaryKey(t => t.MusteriID)
                .ForeignKey("dbo.Ilce", t => t.IlceID, cascadeDelete: true)
                .Index(t => t.IlceID);
            
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        IlceID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                        IlID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IlceID)
                .ForeignKey("dbo.Il", t => t.IlID, cascadeDelete: true)
                .Index(t => t.IlID);
            
            CreateTable(
                "dbo.Il",
                c => new
                    {
                        IlID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.IlID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FaturaDetay", "UrunID", "dbo.Urun");
            DropForeignKey("dbo.Musteri", "IlceID", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "IlID", "dbo.Il");
            DropForeignKey("dbo.FaturaMaster", "MusteriID", "dbo.Musteri");
            DropForeignKey("dbo.FaturaDetay", "FaturaID", "dbo.FaturaMaster");
            DropForeignKey("dbo.Urun", "BirimID", "dbo.Birim");
            DropIndex("dbo.Ilce", new[] { "IlID" });
            DropIndex("dbo.Musteri", new[] { "IlceID" });
            DropIndex("dbo.FaturaMaster", new[] { "MusteriID" });
            DropIndex("dbo.FaturaDetay", new[] { "UrunID" });
            DropIndex("dbo.FaturaDetay", new[] { "FaturaID" });
            DropIndex("dbo.Urun", new[] { "BirimID" });
            DropTable("dbo.Il");
            DropTable("dbo.Ilce");
            DropTable("dbo.Musteri");
            DropTable("dbo.FaturaMaster");
            DropTable("dbo.FaturaDetay");
            DropTable("dbo.Urun");
            DropTable("dbo.Birim");
        }
    }
}
