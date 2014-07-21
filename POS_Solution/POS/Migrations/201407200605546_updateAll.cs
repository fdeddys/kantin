namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_adjustment_dtl",
                c => new
                    {
                        idAdjusmentDtl = c.Int(nullable: false, identity: true),
                        BarangID = c.Int(nullable: false),
                        qty = c.Double(nullable: false),
                        nilaiBarang = c.Double(nullable: false),
                        adjustmentHdr_idAdjusmentHdr = c.Int(),
                    })
                .PrimaryKey(t => t.idAdjusmentDtl)
                .ForeignKey("dbo.tb_adjustment_hd", t => t.adjustmentHdr_idAdjusmentHdr)
                .ForeignKey("dbo.tb_barang", t => t.BarangID, cascadeDelete: true)
                .Index(t => t.BarangID)
                .Index(t => t.adjustmentHdr_idAdjusmentHdr);
            
            CreateTable(
                "dbo.tb_adjustment_hd",
                c => new
                    {
                        idAdjusmentHdr = c.Int(nullable: false, identity: true),
                        noAdjusment = c.String(),
                        catatan = c.String(maxLength: 100),
                        LokasiID = c.Int(nullable: false),
                        approve = c.Boolean(nullable: false),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idAdjusmentHdr)
                .ForeignKey("dbo.tbl_lokasi", t => t.LokasiID, cascadeDelete: true)
                .Index(t => t.LokasiID);
            
            CreateTable(
                "dbo.tbl_lokasi",
                c => new
                    {
                        LokasiID = c.Int(nullable: false, identity: true),
                        NamaLokasi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.LokasiID);
            
            CreateTable(
                "dbo.tb_barang",
                c => new
                    {
                        BarangID = c.Int(nullable: false, identity: true),
                        namaBarang = c.String(maxLength: 50),
                        isStock = c.Boolean(nullable: false),
                        hargaJual = c.Double(nullable: false),
                        nilaiBarang = c.Double(nullable: false),
                        minStock = c.Int(nullable: false),
                        isi = c.Int(nullable: false),
                        UserUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        kodeBarang = c.String(),
                        GroupBarang_idGroup = c.Int(),
                        Merk_IdMerk = c.Int(),
                        SatuanBesar_IdSatuan = c.Int(),
                        SatuanKecil_IdSatuan = c.Int(),
                    })
                .PrimaryKey(t => t.BarangID)
                .ForeignKey("dbo.tb_Group", t => t.GroupBarang_idGroup)
                .ForeignKey("dbo.tb_Merk", t => t.Merk_IdMerk)
                .ForeignKey("dbo.tb_satuan", t => t.SatuanBesar_IdSatuan)
                .ForeignKey("dbo.tb_satuan", t => t.SatuanKecil_IdSatuan)
                .Index(t => t.GroupBarang_idGroup)
                .Index(t => t.Merk_IdMerk)
                .Index(t => t.SatuanBesar_IdSatuan)
                .Index(t => t.SatuanKecil_IdSatuan);
            
            CreateTable(
                "dbo.tb_barcode",
                c => new
                    {
                        BarcodeId = c.Int(nullable: false, identity: true),
                        BarangID = c.Int(nullable: false),
                        barcodeIsi = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.BarcodeId)
                .ForeignKey("dbo.tb_barang", t => t.BarangID, cascadeDelete: true)
                .Index(t => t.BarangID);
            
            CreateTable(
                "dbo.tb_Group",
                c => new
                    {
                        idGroup = c.Int(nullable: false, identity: true),
                        namaGroup = c.String(maxLength: 50),
                        BarangID = c.Int(nullable: false),
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
                "dbo.tb_kartu_stock",
                c => new
                    {
                        idKartuStock = c.Int(nullable: false, identity: true),
                        BarangID = c.Int(nullable: false),
                        tanggal = c.DateTime(nullable: false),
                        masuk = c.Decimal(nullable: false, precision: 18, scale: 2),
                        keluar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        stockAkhir = c.Decimal(nullable: false, precision: 18, scale: 2),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        LokasiID = c.Int(nullable: false),
                        idTransaksi = c.String(),
                    })
                .PrimaryKey(t => t.idKartuStock)
                .ForeignKey("dbo.tb_barang", t => t.BarangID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_lokasi", t => t.LokasiID, cascadeDelete: true)
                .Index(t => t.BarangID)
                .Index(t => t.LokasiID);
            
            CreateTable(
                "dbo.tbl_kasir",
                c => new
                    {
                        KasirID = c.Int(nullable: false, identity: true),
                        KodeKasir = c.String(maxLength: 20),
                        NamaKasir = c.String(maxLength: 50),
                        Aktif = c.Boolean(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.KasirID);
            
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
                "dbo.tb_mutasi_dtl",
                c => new
                    {
                        idMutasiDtl = c.Int(nullable: false, identity: true),
                        BarangID = c.Int(nullable: false),
                        qty = c.Double(nullable: false),
                        nilaiBarang = c.Double(nullable: false),
                        mutasiHdr_idMutasiHdr = c.Int(),
                    })
                .PrimaryKey(t => t.idMutasiDtl)
                .ForeignKey("dbo.tb_barang", t => t.BarangID, cascadeDelete: true)
                .ForeignKey("dbo.tb_mutasi_hd", t => t.mutasiHdr_idMutasiHdr)
                .Index(t => t.BarangID)
                .Index(t => t.mutasiHdr_idMutasiHdr);
            
            CreateTable(
                "dbo.tb_mutasi_hd",
                c => new
                    {
                        idMutasiHdr = c.Int(nullable: false, identity: true),
                        tanggal = c.DateTime(nullable: false),
                        LokasiAsalID = c.Int(nullable: false),
                        LokasiTujuanID = c.Int(nullable: false),
                        approve = c.Boolean(nullable: false),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idMutasiHdr);
            
            CreateTable(
                "dbo.tb_parameter",
                c => new
                    {
                        IdParameter = c.Int(nullable: false, identity: true),
                        KodeGudangMasuk = c.String(maxLength: 3),
                        autoQtySales = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdParameter);
            
            CreateTable(
                "dbo.tb_penjualanDtl",
                c => new
                    {
                        penjualanDtlID = c.Int(nullable: false, identity: true),
                        PenjualanHdrID = c.Int(nullable: false),
                        BarangID = c.Int(nullable: false),
                        jumlah = c.Double(nullable: false),
                        harga = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.penjualanDtlID)
                .ForeignKey("dbo.tb_barang", t => t.BarangID, cascadeDelete: true)
                .ForeignKey("dbo.tb_penjualanHd", t => t.PenjualanHdrID, cascadeDelete: true)
                .Index(t => t.PenjualanHdrID)
                .Index(t => t.BarangID);
            
            CreateTable(
                "dbo.tb_penjualanHd",
                c => new
                    {
                        PenjualanHdrID = c.Int(nullable: false, identity: true),
                        tanggalJual = c.DateTime(nullable: false),
                        KasirID = c.Int(nullable: false),
                        LokasiID = c.Int(nullable: false),
                        totalBelanja = c.Double(nullable: false),
                        isBayar = c.Boolean(nullable: false),
                        lastUpdate = c.DateTime(nullable: false),
                        batal = c.Boolean(nullable: false),
                        noFaktur = c.String(maxLength: 12),
                    })
                .PrimaryKey(t => t.PenjualanHdrID)
                .ForeignKey("dbo.tbl_kasir", t => t.KasirID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_lokasi", t => t.LokasiID, cascadeDelete: true)
                .Index(t => t.KasirID)
                .Index(t => t.LokasiID);
            
            CreateTable(
                "dbo.tb_pesan_dtl",
                c => new
                    {
                        idPesanDtl = c.Int(nullable: false, identity: true),
                        BarangID = c.Int(nullable: false),
                        jumlah = c.Double(nullable: false),
                        isTerima = c.Boolean(nullable: false),
                        pesanHdr_idPesanHdr = c.Int(),
                        satuan_IdSatuan = c.Int(),
                    })
                .PrimaryKey(t => t.idPesanDtl)
                .ForeignKey("dbo.tb_barang", t => t.BarangID, cascadeDelete: true)
                .ForeignKey("dbo.tb_pesan_hd", t => t.pesanHdr_idPesanHdr)
                .ForeignKey("dbo.tb_satuan", t => t.satuan_IdSatuan)
                .Index(t => t.BarangID)
                .Index(t => t.pesanHdr_idPesanHdr)
                .Index(t => t.satuan_IdSatuan);
            
            CreateTable(
                "dbo.tb_pesan_hd",
                c => new
                    {
                        idPesanHdr = c.Int(nullable: false, identity: true),
                        tglPesan = c.DateTime(nullable: false),
                        tempo = c.Int(nullable: false),
                        catatan = c.String(),
                        approve = c.Boolean(nullable: false),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        supplier_idSupplier = c.Int(),
                    })
                .PrimaryKey(t => t.idPesanHdr)
                .ForeignKey("dbo.tb_supplier", t => t.supplier_idSupplier)
                .Index(t => t.supplier_idSupplier);
            
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
            
            CreateTable(
                "dbo.tb_terima_dtl",
                c => new
                    {
                        idTerimaDtl = c.Int(nullable: false, identity: true),
                        jumlah = c.Double(nullable: false),
                        disc1 = c.Double(nullable: false),
                        disc2 = c.Double(nullable: false),
                        pesanDtl_idPesanDtl = c.Int(),
                        terimaHdr_idTerimaHdr = c.Int(),
                    })
                .PrimaryKey(t => t.idTerimaDtl)
                .ForeignKey("dbo.tb_pesan_dtl", t => t.pesanDtl_idPesanDtl)
                .ForeignKey("dbo.tb_terima_hd", t => t.terimaHdr_idTerimaHdr)
                .Index(t => t.pesanDtl_idPesanDtl)
                .Index(t => t.terimaHdr_idTerimaHdr);
            
            CreateTable(
                "dbo.tb_terima_hd",
                c => new
                    {
                        idTerimaHdr = c.Int(nullable: false, identity: true),
                        noTerima = c.String(),
                        tglTerima = c.DateTime(nullable: false),
                        tempo = c.Int(nullable: false),
                        catatan = c.String(),
                        noFaktur = c.String(),
                        total = c.Double(nullable: false),
                        isPpn = c.Boolean(nullable: false),
                        discGlobal = c.Double(nullable: false),
                        approve = c.Boolean(nullable: false),
                        isTarikPembayaran = c.Boolean(nullable: false),
                        userUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        supplier_idSupplier = c.Int(),
                    })
                .PrimaryKey(t => t.idTerimaHdr)
                .ForeignKey("dbo.tb_supplier", t => t.supplier_idSupplier)
                .Index(t => t.supplier_idSupplier);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_terima_dtl", "terimaHdr_idTerimaHdr", "dbo.tb_terima_hd");
            DropForeignKey("dbo.tb_terima_hd", "supplier_idSupplier", "dbo.tb_supplier");
            DropForeignKey("dbo.tb_terima_dtl", "pesanDtl_idPesanDtl", "dbo.tb_pesan_dtl");
            DropForeignKey("dbo.tb_pesan_dtl", "satuan_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_pesan_dtl", "pesanHdr_idPesanHdr", "dbo.tb_pesan_hd");
            DropForeignKey("dbo.tb_pesan_hd", "supplier_idSupplier", "dbo.tb_supplier");
            DropForeignKey("dbo.tb_pesan_dtl", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_penjualanDtl", "PenjualanHdrID", "dbo.tb_penjualanHd");
            DropForeignKey("dbo.tb_penjualanHd", "LokasiID", "dbo.tbl_lokasi");
            DropForeignKey("dbo.tb_penjualanHd", "KasirID", "dbo.tbl_kasir");
            DropForeignKey("dbo.tb_penjualanDtl", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_mutasi_dtl", "mutasiHdr_idMutasiHdr", "dbo.tb_mutasi_hd");
            DropForeignKey("dbo.tb_mutasi_dtl", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_kartu_stock", "LokasiID", "dbo.tbl_lokasi");
            DropForeignKey("dbo.tb_kartu_stock", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_adjustment_dtl", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_barang", "SatuanKecil_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_barang", "SatuanBesar_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_barang", "Merk_IdMerk", "dbo.tb_Merk");
            DropForeignKey("dbo.tb_barang", "GroupBarang_idGroup", "dbo.tb_Group");
            DropForeignKey("dbo.tb_barcode", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_adjustment_dtl", "adjustmentHdr_idAdjusmentHdr", "dbo.tb_adjustment_hd");
            DropForeignKey("dbo.tb_adjustment_hd", "LokasiID", "dbo.tbl_lokasi");
            DropIndex("dbo.tb_terima_hd", new[] { "supplier_idSupplier" });
            DropIndex("dbo.tb_terima_dtl", new[] { "terimaHdr_idTerimaHdr" });
            DropIndex("dbo.tb_terima_dtl", new[] { "pesanDtl_idPesanDtl" });
            DropIndex("dbo.tb_pesan_hd", new[] { "supplier_idSupplier" });
            DropIndex("dbo.tb_pesan_dtl", new[] { "satuan_IdSatuan" });
            DropIndex("dbo.tb_pesan_dtl", new[] { "pesanHdr_idPesanHdr" });
            DropIndex("dbo.tb_pesan_dtl", new[] { "BarangID" });
            DropIndex("dbo.tb_penjualanHd", new[] { "LokasiID" });
            DropIndex("dbo.tb_penjualanHd", new[] { "KasirID" });
            DropIndex("dbo.tb_penjualanDtl", new[] { "BarangID" });
            DropIndex("dbo.tb_penjualanDtl", new[] { "PenjualanHdrID" });
            DropIndex("dbo.tb_mutasi_dtl", new[] { "mutasiHdr_idMutasiHdr" });
            DropIndex("dbo.tb_mutasi_dtl", new[] { "BarangID" });
            DropIndex("dbo.tb_kartu_stock", new[] { "LokasiID" });
            DropIndex("dbo.tb_kartu_stock", new[] { "BarangID" });
            DropIndex("dbo.tb_barcode", new[] { "BarangID" });
            DropIndex("dbo.tb_barang", new[] { "SatuanKecil_IdSatuan" });
            DropIndex("dbo.tb_barang", new[] { "SatuanBesar_IdSatuan" });
            DropIndex("dbo.tb_barang", new[] { "Merk_IdMerk" });
            DropIndex("dbo.tb_barang", new[] { "GroupBarang_idGroup" });
            DropIndex("dbo.tb_adjustment_hd", new[] { "LokasiID" });
            DropIndex("dbo.tb_adjustment_dtl", new[] { "adjustmentHdr_idAdjusmentHdr" });
            DropIndex("dbo.tb_adjustment_dtl", new[] { "BarangID" });
            DropTable("dbo.tb_terima_hd");
            DropTable("dbo.tb_terima_dtl");
            DropTable("dbo.tb_supplier");
            DropTable("dbo.tb_pesan_hd");
            DropTable("dbo.tb_pesan_dtl");
            DropTable("dbo.tb_penjualanHd");
            DropTable("dbo.tb_penjualanDtl");
            DropTable("dbo.tb_parameter");
            DropTable("dbo.tb_mutasi_hd");
            DropTable("dbo.tb_mutasi_dtl");
            DropTable("dbo.tbl_logger");
            DropTable("dbo.tbl_kasir");
            DropTable("dbo.tb_kartu_stock");
            DropTable("dbo.tb_satuan");
            DropTable("dbo.tb_Merk");
            DropTable("dbo.tb_Group");
            DropTable("dbo.tb_barcode");
            DropTable("dbo.tb_barang");
            DropTable("dbo.tbl_lokasi");
            DropTable("dbo.tb_adjustment_hd");
            DropTable("dbo.tb_adjustment_dtl");
        }
    }
}
