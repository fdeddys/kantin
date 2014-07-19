namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class barangtambahkodeBarang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_barang", "kodeBarang", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_barang", "kodeBarang");
        }
    }
}
