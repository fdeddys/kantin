namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_supplier",
                c => new
                    {
                        idSupplier = c.Int(nullable: false, identity: true),
                        namaSupplier = c.String(maxLength: 100),
                        alamat = c.String(maxLength: 300),
                        kota = c.String(maxLength: 50),
                        telp = c.String(maxLength: 30),
                        fax = c.String(maxLength: 30),
                        cPerson = c.String(maxLength: 50),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idSupplier);
            
            AddColumn("dbo.tb_pesan_hd", "supplier_idSupplier", c => c.Int());
            CreateIndex("dbo.tb_pesan_hd", "supplier_idSupplier");
            AddForeignKey("dbo.tb_pesan_hd", "supplier_idSupplier", "dbo.tb_supplier", "idSupplier");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_pesan_hd", "supplier_idSupplier", "dbo.tb_supplier");
            DropIndex("dbo.tb_pesan_hd", new[] { "supplier_idSupplier" });
            DropColumn("dbo.tb_pesan_hd", "supplier_idSupplier");
            DropTable("dbo.tb_supplier");
        }
    }
}
