namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_barang",
                c => new
                    {
                        idBarang = c.Int(nullable: false, identity: true),
                        namaBarang = c.String(maxLength: 50),
                        stock = c.Boolean(nullable: false),
                        hargaJual = c.Double(nullable: false),
                        UserUpdate = c.String(),
                        GroupBarang_idGroup = c.Int(),
                        Merk_IdMerk = c.Int(),
                        Satuan_IdSatuan = c.Int(),
                    })
                .PrimaryKey(t => t.idBarang)
                .ForeignKey("dbo.tb_Group", t => t.GroupBarang_idGroup)
                .ForeignKey("dbo.tb_Merk", t => t.Merk_IdMerk)
                .ForeignKey("dbo.tb_satuan", t => t.Satuan_IdSatuan)
                .Index(t => t.GroupBarang_idGroup)
                .Index(t => t.Merk_IdMerk)
                .Index(t => t.Satuan_IdSatuan);
            
            CreateTable(
                "dbo.tb_barcode",
                c => new
                    {
                        BarcodeId = c.Int(nullable: false, identity: true),
                        barcodeIsi = c.String(maxLength: 100),
                        Barang_idBarang = c.Int(),
                    })
                .PrimaryKey(t => t.BarcodeId)
                .ForeignKey("dbo.tb_barang", t => t.Barang_idBarang)
                .Index(t => t.Barang_idBarang);
            
            CreateTable(
                "dbo.tb_Group",
                c => new
                    {
                        idGroup = c.Int(nullable: false, identity: true),
                        namaGroup = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.idGroup);
            
            CreateTable(
                "dbo.tb_Merk",
                c => new
                    {
                        IdMerk = c.Int(nullable: false, identity: true),
                        namaMerk = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.IdMerk);
            
            CreateTable(
                "dbo.tb_satuan",
                c => new
                    {
                        IdSatuan = c.Int(nullable: false, identity: true),
                        NamaSatuan = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.IdSatuan);
            
            CreateTable(
                "dbo.tbl_kasir",
                c => new
                    {
                        IdKasir = c.Int(nullable: false, identity: true),
                        KodeKasir = c.String(maxLength: 20),
                        NamaKasir = c.String(maxLength: 50),
                        Aktif = c.Boolean(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.IdKasir);
            
            CreateTable(
                "dbo.tbl_logger",
                c => new
                    {
                        idLogger = c.Int(nullable: false, identity: true),
                        NamaUser = c.String(maxLength: 50),
                        Waktu = c.String(maxLength: 20),
                        NamaPos = c.String(maxLength: 50),
                        Sukses = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idLogger);
            
            CreateTable(
                "dbo.tb_parameter",
                c => new
                    {
                        IdParameter = c.Int(nullable: false, identity: true),
                        KodeGudangMasuk = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.IdParameter);
            
            CreateTable(
                "dbo.tbl_lokasi",
                c => new
                    {
                        idLokasi = c.Int(nullable: false, identity: true),
                        NamaLokasi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.idLokasi);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_barang", "Satuan_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_barang", "Merk_IdMerk", "dbo.tb_Merk");
            DropForeignKey("dbo.tb_barang", "GroupBarang_idGroup", "dbo.tb_Group");
            DropForeignKey("dbo.tb_barcode", "Barang_idBarang", "dbo.tb_barang");
            DropIndex("dbo.tb_barcode", new[] { "Barang_idBarang" });
            DropIndex("dbo.tb_barang", new[] { "Satuan_IdSatuan" });
            DropIndex("dbo.tb_barang", new[] { "Merk_IdMerk" });
            DropIndex("dbo.tb_barang", new[] { "GroupBarang_idGroup" });
            DropTable("dbo.tbl_lokasi");
            DropTable("dbo.tb_parameter");
            DropTable("dbo.tbl_logger");
            DropTable("dbo.tbl_kasir");
            DropTable("dbo.tb_satuan");
            DropTable("dbo.tb_Merk");
            DropTable("dbo.tb_Group");
            DropTable("dbo.tb_barcode");
            DropTable("dbo.tb_barang");
        }
    }
}
