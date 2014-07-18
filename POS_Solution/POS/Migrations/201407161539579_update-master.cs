namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemaster : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_barang", "isStock", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_barang", "minStock", c => c.Int(nullable: false));
            AddColumn("dbo.tb_barang", "SatuanBesar_IdSatuan", c => c.Int());
            AddColumn("dbo.tb_barang", "SatuanKecil_IdSatuan", c => c.Int());
            CreateIndex("dbo.tb_barang", "SatuanBesar_IdSatuan");
            CreateIndex("dbo.tb_barang", "SatuanKecil_IdSatuan");
            AddForeignKey("dbo.tb_barang", "SatuanBesar_IdSatuan", "dbo.tb_satuan", "IdSatuan");
            AddForeignKey("dbo.tb_barang", "SatuanKecil_IdSatuan", "dbo.tb_satuan", "IdSatuan");
            DropColumn("dbo.tb_barang", "stock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_barang", "stock", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.tb_barang", "SatuanKecil_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_barang", "SatuanBesar_IdSatuan", "dbo.tb_satuan");
            DropIndex("dbo.tb_barang", new[] { "SatuanKecil_IdSatuan" });
            DropIndex("dbo.tb_barang", new[] { "SatuanBesar_IdSatuan" });
            DropColumn("dbo.tb_barang", "SatuanKecil_IdSatuan");
            DropColumn("dbo.tb_barang", "SatuanBesar_IdSatuan");
            DropColumn("dbo.tb_barang", "minStock");
            DropColumn("dbo.tb_barang", "isStock");
        }
    }
}
