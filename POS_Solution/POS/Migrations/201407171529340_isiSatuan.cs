namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isiSatuan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_barang", "isi", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_barang", "isi");
        }
    }
}
