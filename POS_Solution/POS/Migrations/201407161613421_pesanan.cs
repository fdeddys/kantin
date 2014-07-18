namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pesanan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_pesan_dtl",
                c => new
                    {
                        idPesanDtl = c.Int(nullable: false, identity: true),
                        jumlah = c.Double(nullable: false),
                        isTerima = c.Boolean(nullable: false),
                        barang_idBarang = c.Int(),
                        pesanHdr_idPesanHdr = c.Int(),
                        satuan_IdSatuan = c.Int(),
                    })
                .PrimaryKey(t => t.idPesanDtl)
                .ForeignKey("dbo.tb_barang", t => t.barang_idBarang)
                .ForeignKey("dbo.tb_pesan_hd", t => t.pesanHdr_idPesanHdr)
                .ForeignKey("dbo.tb_satuan", t => t.satuan_IdSatuan)
                .Index(t => t.barang_idBarang)
                .Index(t => t.pesanHdr_idPesanHdr)
                .Index(t => t.satuan_IdSatuan);
            
            CreateTable(
                "dbo.tb_pesan_hd",
                c => new
                    {
                        idPesanHdr = c.Int(nullable: false, identity: true),
                        tglPesan = c.DateTime(nullable: false),
                        tempo = c.Int(nullable: false),
                        catatan = c.String(),
                        approve = c.Boolean(nullable: false),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idPesanHdr);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_pesan_dtl", "satuan_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_pesan_dtl", "pesanHdr_idPesanHdr", "dbo.tb_pesan_hd");
            DropForeignKey("dbo.tb_pesan_dtl", "barang_idBarang", "dbo.tb_barang");
            DropIndex("dbo.tb_pesan_dtl", new[] { "satuan_IdSatuan" });
            DropIndex("dbo.tb_pesan_dtl", new[] { "pesanHdr_idPesanHdr" });
            DropIndex("dbo.tb_pesan_dtl", new[] { "barang_idBarang" });
            DropTable("dbo.tb_pesan_hd");
            DropTable("dbo.tb_pesan_dtl");
        }
    }
}
