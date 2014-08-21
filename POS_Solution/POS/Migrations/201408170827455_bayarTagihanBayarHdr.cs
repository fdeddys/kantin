namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bayarTagihanBayarHdr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_bayar_tagihan", "BayarHdrID", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_bayar_tagihan", "BayarHdrID");
            AddForeignKey("dbo.tb_bayar_tagihan", "BayarHdrID", "dbo.tb_bayar_hd", "BayarHdrID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_bayar_tagihan", "BayarHdrID", "dbo.tb_bayar_hd");
            DropIndex("dbo.tb_bayar_tagihan", new[] { "BayarHdrID" });
            DropColumn("dbo.tb_bayar_tagihan", "BayarHdrID");
        }
    }
}
