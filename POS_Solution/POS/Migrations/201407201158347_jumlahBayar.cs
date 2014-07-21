namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jumlahBayar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_penjualanHd", "jumlahBayar", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_penjualanHd", "jumlahBayar");
        }
    }
}
