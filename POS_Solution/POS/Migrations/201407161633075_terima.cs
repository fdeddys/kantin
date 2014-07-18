namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class terima : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_terima_dtl",
                c => new
                    {
                        idTerimaDtl = c.Int(nullable: false, identity: true),
                        jumlah = c.Double(nullable: false),
                        disc1 = c.Double(nullable: false),
                        disc2 = c.Double(nullable: false),
                        pesanDtl_idPesanDtl = c.Int(),
                        terimaHdr_idTerimaHdr = c.Int(),
                    })
                .PrimaryKey(t => t.idTerimaDtl)
                .ForeignKey("dbo.tb_pesan_dtl", t => t.pesanDtl_idPesanDtl)
                .ForeignKey("dbo.tb_terima_hd", t => t.terimaHdr_idTerimaHdr)
                .Index(t => t.pesanDtl_idPesanDtl)
                .Index(t => t.terimaHdr_idTerimaHdr);
            
            CreateTable(
                "dbo.tb_terima_hd",
                c => new
                    {
                        idTerimaHdr = c.Int(nullable: false, identity: true),
                        noTerima = c.String(),
                        tglTerima = c.DateTime(nullable: false),
                        tempo = c.Int(nullable: false),
                        catatan = c.String(),
                        noFaktur = c.String(),
                        total = c.Double(nullable: false),
                        isPpn = c.Boolean(nullable: false),
                        discGlobal = c.Double(nullable: false),
                        approve = c.Boolean(nullable: false),
                        isTarikPembayaran = c.Boolean(nullable: false),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        supplier_idSupplier = c.Int(),
                    })
                .PrimaryKey(t => t.idTerimaHdr)
                .ForeignKey("dbo.tb_supplier", t => t.supplier_idSupplier)
                .Index(t => t.supplier_idSupplier);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_terima_dtl", "terimaHdr_idTerimaHdr", "dbo.tb_terima_hd");
            DropForeignKey("dbo.tb_terima_hd", "supplier_idSupplier", "dbo.tb_supplier");
            DropForeignKey("dbo.tb_terima_dtl", "pesanDtl_idPesanDtl", "dbo.tb_pesan_dtl");
            DropIndex("dbo.tb_terima_hd", new[] { "supplier_idSupplier" });
            DropIndex("dbo.tb_terima_dtl", new[] { "terimaHdr_idTerimaHdr" });
            DropIndex("dbo.tb_terima_dtl", new[] { "pesanDtl_idPesanDtl" });
            DropTable("dbo.tb_terima_hd");
            DropTable("dbo.tb_terima_dtl");
        }
    }
}
