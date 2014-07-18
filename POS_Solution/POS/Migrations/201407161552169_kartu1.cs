namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kartu1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_kartu_stock",
                c => new
                    {
                        idKartuStock = c.Int(nullable: false, identity: true),
                        tanggal = c.DateTime(nullable: false),
                        masuk = c.Decimal(nullable: false, precision: 18, scale: 2),
                        keluar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        stockAkhir = c.Decimal(nullable: false, precision: 18, scale: 2),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        idTransaksi = c.String(),
                        idBarang_idBarang = c.Int(),
                        lokasi_idLokasi = c.Int(),
                    })
                .PrimaryKey(t => t.idKartuStock)
                .ForeignKey("dbo.tb_barang", t => t.idBarang_idBarang)
                .ForeignKey("dbo.tbl_lokasi", t => t.lokasi_idLokasi)
                .Index(t => t.idBarang_idBarang)
                .Index(t => t.lokasi_idLokasi);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_kartu_stock", "lokasi_idLokasi", "dbo.tbl_lokasi");
            DropForeignKey("dbo.tb_kartu_stock", "idBarang_idBarang", "dbo.tb_barang");
            DropIndex("dbo.tb_kartu_stock", new[] { "lokasi_idLokasi" });
            DropIndex("dbo.tb_kartu_stock", new[] { "idBarang_idBarang" });
            DropTable("dbo.tb_kartu_stock");
        }
    }
}
