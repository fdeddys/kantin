namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class penjualandtlpenjualanHdr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_penjualanDtl", "penjualanHdr_idPenjualanHd", c => c.Int());
            CreateIndex("dbo.tb_penjualanDtl", "penjualanHdr_idPenjualanHd");
            AddForeignKey("dbo.tb_penjualanDtl", "penjualanHdr_idPenjualanHd", "dbo.tb_penjualanHd", "idPenjualanHd");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_penjualanDtl", "penjualanHdr_idPenjualanHd", "dbo.tb_penjualanHd");
            DropIndex("dbo.tb_penjualanDtl", new[] { "penjualanHdr_idPenjualanHd" });
            DropColumn("dbo.tb_penjualanDtl", "penjualanHdr_idPenjualanHd");
        }
    }
}
