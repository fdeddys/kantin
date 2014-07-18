namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_barang", "lastUpdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_barang", "lastUpdate");
        }
    }
}
