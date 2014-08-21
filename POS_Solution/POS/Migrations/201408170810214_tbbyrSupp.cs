namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbbyrSupp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_bayar_hd", "idSupplier", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_bayar_hd", "idSupplier");
            AddForeignKey("dbo.tb_bayar_hd", "idSupplier", "dbo.tb_supplier", "idSupplier", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_bayar_hd", "idSupplier", "dbo.tb_supplier");
            DropIndex("dbo.tb_bayar_hd", new[] { "idSupplier" });
            DropColumn("dbo.tb_bayar_hd", "idSupplier");
        }
    }
}
