namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class penjualan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_penjualanDtl",
                c => new
                    {
                        idPenjualanDtl = c.Int(nullable: false, identity: true),
                        jumlah = c.Double(nullable: false),
                        harga = c.Double(nullable: false),
                        barang_idBarang = c.Int(),
                    })
                .PrimaryKey(t => t.idPenjualanDtl)
                .ForeignKey("dbo.tb_barang", t => t.barang_idBarang)
                .Index(t => t.barang_idBarang);
            
            CreateTable(
                "dbo.tb_penjualanHd",
                c => new
                    {
                        idPenjualanHd = c.Int(nullable: false, identity: true),
                        tanggalJual = c.DateTime(nullable: false),
                        totalBelanja = c.Double(nullable: false),
                        isBayar = c.Boolean(nullable: false),
                        lastUpdate = c.DateTime(nullable: false),
                        batal = c.Boolean(nullable: false),
                        kasir_IdKasir = c.Int(),
                        lokasi_idLokasi = c.Int(),
                    })
                .PrimaryKey(t => t.idPenjualanHd)
                .ForeignKey("dbo.tbl_kasir", t => t.kasir_IdKasir)
                .ForeignKey("dbo.tbl_lokasi", t => t.lokasi_idLokasi)
                .Index(t => t.kasir_IdKasir)
                .Index(t => t.lokasi_idLokasi);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_penjualanHd", "lokasi_idLokasi", "dbo.tbl_lokasi");
            DropForeignKey("dbo.tb_penjualanHd", "kasir_IdKasir", "dbo.tbl_kasir");
            DropForeignKey("dbo.tb_penjualanDtl", "barang_idBarang", "dbo.tb_barang");
            DropIndex("dbo.tb_penjualanHd", new[] { "lokasi_idLokasi" });
            DropIndex("dbo.tb_penjualanHd", new[] { "kasir_IdKasir" });
            DropIndex("dbo.tb_penjualanDtl", new[] { "barang_idBarang" });
            DropTable("dbo.tb_penjualanHd");
            DropTable("dbo.tb_penjualanDtl");
        }
    }
}
