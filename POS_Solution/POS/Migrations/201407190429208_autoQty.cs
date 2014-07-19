namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class autoQty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_parameter", "autoQtySales", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_parameter", "autoQtySales");
        }
    }
}
