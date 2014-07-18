namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjust : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_adjusment_dtl",
                c => new
                    {
                        idAdjusmentDtl = c.Int(nullable: false, identity: true),
                        qty = c.Double(nullable: false),
                        nilaiBarang = c.Double(nullable: false),
                        adjustmentHdr_idAdjusmentHdr = c.Int(),
                        barang_idBarang = c.Int(),
                    })
                .PrimaryKey(t => t.idAdjusmentDtl)
                .ForeignKey("dbo.tb_adjusement_hd", t => t.adjustmentHdr_idAdjusmentHdr)
                .ForeignKey("dbo.tb_barang", t => t.barang_idBarang)
                .Index(t => t.adjustmentHdr_idAdjusmentHdr)
                .Index(t => t.barang_idBarang);
            
            CreateTable(
                "dbo.tb_adjusement_hd",
                c => new
                    {
                        idAdjusmentHdr = c.Int(nullable: false, identity: true),
                        noAdjusment = c.String(),
                        catatan = c.String(maxLength: 100),
                        approve = c.Boolean(nullable: false),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        lokasi_idLokasi = c.Int(),
                    })
                .PrimaryKey(t => t.idAdjusmentHdr)
                .ForeignKey("dbo.tbl_lokasi", t => t.lokasi_idLokasi)
                .Index(t => t.lokasi_idLokasi);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_adjusment_dtl", "barang_idBarang", "dbo.tb_barang");
            DropForeignKey("dbo.tb_adjusment_dtl", "adjustmentHdr_idAdjusmentHdr", "dbo.tb_adjusement_hd");
            DropForeignKey("dbo.tb_adjusement_hd", "lokasi_idLokasi", "dbo.tbl_lokasi");
            DropIndex("dbo.tb_adjusement_hd", new[] { "lokasi_idLokasi" });
            DropIndex("dbo.tb_adjusment_dtl", new[] { "barang_idBarang" });
            DropIndex("dbo.tb_adjusment_dtl", new[] { "adjustmentHdr_idAdjusmentHdr" });
            DropTable("dbo.tb_adjusement_hd");
            DropTable("dbo.tb_adjusment_dtl");
        }
    }
}
