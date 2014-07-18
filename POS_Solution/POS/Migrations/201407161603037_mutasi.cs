namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mutasi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_mutasi_hd",
                c => new
                    {
                        idMutasiHdr = c.Int(nullable: false, identity: true),
                        tanggal = c.DateTime(nullable: false),
                        approve = c.Boolean(nullable: false),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        lokasiAsal_idLokasi = c.Int(),
                        LokasiTujuan_idLokasi = c.Int(),
                    })
                .PrimaryKey(t => t.idMutasiHdr)
                .ForeignKey("dbo.tbl_lokasi", t => t.lokasiAsal_idLokasi)
                .ForeignKey("dbo.tbl_lokasi", t => t.LokasiTujuan_idLokasi)
                .Index(t => t.lokasiAsal_idLokasi)
                .Index(t => t.LokasiTujuan_idLokasi);
            
            CreateTable(
                "dbo.tb_mutasi_dtl",
                c => new
                    {
                        idMutasiDtl = c.Int(nullable: false, identity: true),
                        qty = c.Double(nullable: false),
                        nilaiBarang = c.Double(nullable: false),
                        barang_idBarang = c.Int(),
                        mutasiHdr_idMutasiHdr = c.Int(),
                    })
                .PrimaryKey(t => t.idMutasiDtl)
                .ForeignKey("dbo.tb_barang", t => t.barang_idBarang)
                .ForeignKey("dbo.tbl_mutasi_hd", t => t.mutasiHdr_idMutasiHdr)
                .Index(t => t.barang_idBarang)
                .Index(t => t.mutasiHdr_idMutasiHdr);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_mutasi_dtl", "mutasiHdr_idMutasiHdr", "dbo.tbl_mutasi_hd");
            DropForeignKey("dbo.tb_mutasi_dtl", "barang_idBarang", "dbo.tb_barang");
            DropForeignKey("dbo.tbl_mutasi_hd", "LokasiTujuan_idLokasi", "dbo.tbl_lokasi");
            DropForeignKey("dbo.tbl_mutasi_hd", "lokasiAsal_idLokasi", "dbo.tbl_lokasi");
            DropIndex("dbo.tb_mutasi_dtl", new[] { "mutasiHdr_idMutasiHdr" });
            DropIndex("dbo.tb_mutasi_dtl", new[] { "barang_idBarang" });
            DropIndex("dbo.tbl_mutasi_hd", new[] { "LokasiTujuan_idLokasi" });
            DropIndex("dbo.tbl_mutasi_hd", new[] { "lokasiAsal_idLokasi" });
            DropTable("dbo.tb_mutasi_dtl");
            DropTable("dbo.tbl_mutasi_hd");
        }
    }
}
