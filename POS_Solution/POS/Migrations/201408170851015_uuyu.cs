namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uuyu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_bayar_tagihan", "TerimaHdrID", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_bayar_tagihan", "TerimaHdrID");
            AddForeignKey("dbo.tb_bayar_tagihan", "TerimaHdrID", "dbo.tb_terima_hd", "idTerimaHdr", cascadeDelete: true );
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_bayar_tagihan", "TerimaHdrID", "dbo.tb_terima_hd");
            DropIndex("dbo.tb_bayar_tagihan", new[] { "TerimaHdrID" });
            DropColumn("dbo.tb_bayar_tagihan", "TerimaHdrID");
        }
    }
}
