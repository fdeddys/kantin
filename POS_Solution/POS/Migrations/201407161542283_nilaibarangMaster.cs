namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nilaibarangMaster : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_barang", "nilaiBarang", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_barang", "nilaiBarang");
        }
    }
}
