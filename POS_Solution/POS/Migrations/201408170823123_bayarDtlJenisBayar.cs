namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bayarDtlJenisBayar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_bayar_dtl", "JenisBayarID", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_bayar_dtl", "JenisBayarID");
            AddForeignKey("dbo.tb_bayar_dtl", "JenisBayarID", "dbo.tb_jnsBayar", "JenisBayarID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_bayar_dtl", "JenisBayarID", "dbo.tb_jnsBayar");
            DropIndex("dbo.tb_bayar_dtl", new[] { "JenisBayarID" });
            DropColumn("dbo.tb_bayar_dtl", "JenisBayarID");
        }
    }
}
