namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class batalDetil : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_penjualanDtl", "batal", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_penjualanDtl", "batal");
        }
    }
}
