namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nofaktur : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_penjualanHd", "noFaktur", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_penjualanHd", "noFaktur");
        }
    }
}
