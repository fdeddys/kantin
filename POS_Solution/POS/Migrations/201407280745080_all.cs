namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all : DbMigration
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
                        noAdjusment = c.String(maxLength: 11),
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
                        GroupBarangID = c.Int(nullable: false),
                        konversiSatuan = c.Int(nullable: false),
                        MerkID = c.Int(nullable: false),
                        UserUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        kodeBarang = c.String(maxLength: 7),
                        hapus = c.Boolean(nullable: false),
                        hargaBeli = c.Double(nullable: false),
                        stockAkhir = c.Int(nullable: false),
                        SatuanBesar_IdSatuan = c.Int(),
                        SatuanKecil_IdSatuan = c.Int(),
                    })
                .PrimaryKey(t => t.BarangID)
                .ForeignKey("dbo.tb_Group", t => t.GroupBarangID, cascadeDelete: true)
                .ForeignKey("dbo.tb_Merk", t => t.MerkID, cascadeDelete: true)
                .ForeignKey("dbo.tb_satuan", t => t.SatuanBesar_IdSatuan)
                .ForeignKey("dbo.tb_satuan", t => t.SatuanKecil_IdSatuan)
                .Index(t => t.GroupBarangID)
                .Index(t => t.MerkID)
                .Index(t => t.SatuanBesar_IdSatuan)
                .Index(t => t.SatuanKecil_IdSatuan);
            
            CreateTable(
                "dbo.tb_barcode",
                c => new
                    {
                        BarcodeId = c.Int(nullable: false, identity: true),
                        BarangID = c.Int(nullable: false),
                        barcodeIsi = c.String(maxLength: 100),
                        BarangHistory_BarangHistoryID = c.Int(),
                    })
                .PrimaryKey(t => t.BarcodeId)
                .ForeignKey("dbo.tb_barang", t => t.BarangID, cascadeDelete: true)
                .ForeignKey("dbo.tb_barang_history", t => t.BarangHistory_BarangHistoryID)
                .Index(t => t.BarangID)
                .Index(t => t.BarangHistory_BarangHistoryID);
            
            CreateTable(
                "dbo.tb_Group",
                c => new
                    {
                        GroupBarangID = c.Int(nullable: false, identity: true),
                        namaGroup = c.String(maxLength: 50),
                        hapus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GroupBarangID);
            
            CreateTable(
                "dbo.tb_Merk",
                c => new
                    {
                        MerkID = c.Int(nullable: false, identity: true),
                        namaMerk = c.String(maxLength: 50),
                        hapus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MerkID);
            
            CreateTable(
                "dbo.tb_satuan",
                c => new
                    {
                        IdSatuan = c.Int(nullable: false, identity: true),
                        NamaSatuan = c.String(maxLength: 50),
                        hapus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdSatuan);
            
            CreateTable(
                "dbo.tb_barang_history",
                c => new
                    {
                        idBarangHistory = c.Int(nullable: false, identity: true),
                        BarangID = c.Int(nullable: false),
                        namaBarang = c.String(maxLength: 50),
                        isStock = c.Boolean(nullable: false),
                        hargaJual = c.Double(nullable: false),
                        nilaiBarang = c.Double(nullable: false),
                        minStock = c.Int(nullable: false),
                        GroupBarangID = c.Int(nullable: false),
                        konversiSatuan = c.Int(nullable: false),
                        MerkID = c.Int(nullable: false),
                        UserUpdate = c.String(),
                        lastUpdate = c.DateTime(nullable: false),
                        kodeBarang = c.String(maxLength: 7),
                        hapus = c.Boolean(nullable: false),
                        hargaBeli = c.Double(nullable: false),
                        stockAkhir = c.Int(nullable: false),
                        SatuanBesar_IdSatuan = c.Int(),
                        SatuanKecil_IdSatuan = c.Int(),
                    })
                .PrimaryKey(t => t.idBarangHistory)
                .ForeignKey("dbo.tb_Group", t => t.GroupBarangID, cascadeDelete: true)
                .ForeignKey("dbo.tb_Merk", t => t.MerkID, cascadeDelete: true)
                .ForeignKey("dbo.tb_satuan", t => t.SatuanBesar_IdSatuan)
                .ForeignKey("dbo.tb_satuan", t => t.SatuanKecil_IdSatuan)
                .Index(t => t.GroupBarangID)
                .Index(t => t.MerkID)
                .Index(t => t.SatuanBesar_IdSatuan)
                .Index(t => t.SatuanKecil_IdSatuan);
            
            CreateTable(
                "dbo.tb_DaftarMenu",
                c => new
                    {
                        DaftarMenuID = c.Int(nullable: false, identity: true),
                        vc_kd_menu = c.String(maxLength: 10),
                        vc_nm_menu = c.String(maxLength: 50),
                        vc_nm_program = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DaftarMenuID);
            
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
                "dbo.tb_user",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        vc_un = c.String(maxLength: 20),
                        vc_nama = c.String(maxLength: 50),
                        bt_aktif = c.Boolean(nullable: false),
                        vc_password = c.String(),
                        vc_nik = c.String(maxLength: 4),
                        bt_kasir = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idUser);
            
            CreateTable(
                "dbo.tb_kasirLogin",
                c => new
                    {
                        KasirLoginID = c.Int(nullable: false, identity: true),
                        TglTransaksi = c.String(),
                        OpenShift = c.Boolean(nullable: false),
                        WaktuOpenShift = c.DateTime(nullable: false),
                        SaldoAwal = c.Double(nullable: false),
                        KasirID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KasirLoginID)
                .ForeignKey("dbo.tb_user", t => t.KasirID, cascadeDelete: true)
                .Index(t => t.KasirID);
            
            CreateTable(
                "dbo.tb_lastno",
                c => new
                    {
                        idLastNo = c.Int(nullable: false, identity: true),
                        vc_kode = c.String(maxLength: 2),
                        vc_keterangan = c.String(maxLength: 50),
                        in_lastNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idLastNo);
            
            CreateTable(
                "dbo.tb_lastNo_trans",
                c => new
                    {
                        idLastNoTrans = c.Int(nullable: false, identity: true),
                        vc_kode = c.String(maxLength: 2),
                        si_tahun = c.Int(nullable: false),
                        si_bulan = c.Int(nullable: false),
                        in_lastNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idLastNoTrans);
            
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
                        noMutasi = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.idMutasiHdr);
            
            CreateTable(
                "dbo.tb_parameter",
                c => new
                    {
                        IdParameter = c.Int(nullable: false, identity: true),
                        idLokasi_GudangMasuk = c.Int(nullable: false),
                        autoQtySales = c.Boolean(nullable: false),
                        pesan = c.String(maxLength: 2),
                        terima = c.String(maxLength: 2),
                        returPenerimaan = c.String(maxLength: 2),
                        penyesuaian = c.String(maxLength: 2),
                        mutasi = c.String(maxLength: 2),
                        penjualan = c.String(maxLength: 2),
                        pembayaran = c.String(maxLength: 2),
                        stokAwal = c.String(),
                        saldoAwalKasir = c.Double(nullable: false),
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
                        batal = c.Boolean(nullable: false),
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
                        jumlahBayar = c.Double(nullable: false),
                        noFaktur = c.String(maxLength: 12),
                    })
                .PrimaryKey(t => t.PenjualanHdrID)
                .ForeignKey("dbo.tb_user", t => t.KasirID, cascadeDelete: true)
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
                        noPO = c.String(maxLength: 11),
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
                        hapus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idSupplier);
            
            CreateTable(
                "dbo.tb_stock",
                c => new
                    {
                        idStock = c.Int(nullable: false, identity: true),
                        lokasiID = c.Int(nullable: false),
                        BarangID = c.Int(nullable: false),
                        Jumlah = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idStock)
                .ForeignKey("dbo.tb_barang", t => t.BarangID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_lokasi", t => t.lokasiID, cascadeDelete: true)
                .Index(t => t.lokasiID)
                .Index(t => t.BarangID);
            
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
                        noTerima = c.String(maxLength: 11),
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
            
            CreateTable(
                "dbo.tb_UserAksesMenu",
                c => new
                    {
                        idUserAksesMenu = c.Int(nullable: false, identity: true),
                        vc_nik = c.String(maxLength: 4),
                        vc_kd_menu = c.String(maxLength: 10),
                        bt_visible = c.Boolean(nullable: false),
                        bt_enable = c.Boolean(nullable: false),
                        bt_add = c.Boolean(nullable: false),
                        bt_edit = c.Boolean(nullable: false),
                        bt_delete = c.Boolean(nullable: false),
                        bt_approve = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idUserAksesMenu);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_terima_dtl", "terimaHdr_idTerimaHdr", "dbo.tb_terima_hd");
            DropForeignKey("dbo.tb_terima_hd", "supplier_idSupplier", "dbo.tb_supplier");
            DropForeignKey("dbo.tb_terima_dtl", "pesanDtl_idPesanDtl", "dbo.tb_pesan_dtl");
            DropForeignKey("dbo.tb_stock", "lokasiID", "dbo.tbl_lokasi");
            DropForeignKey("dbo.tb_stock", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_pesan_dtl", "satuan_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_pesan_dtl", "pesanHdr_idPesanHdr", "dbo.tb_pesan_hd");
            DropForeignKey("dbo.tb_pesan_hd", "supplier_idSupplier", "dbo.tb_supplier");
            DropForeignKey("dbo.tb_pesan_dtl", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_penjualanDtl", "PenjualanHdrID", "dbo.tb_penjualanHd");
            DropForeignKey("dbo.tb_penjualanHd", "LokasiID", "dbo.tbl_lokasi");
            DropForeignKey("dbo.tb_penjualanHd", "KasirID", "dbo.tb_user");
            DropForeignKey("dbo.tb_penjualanDtl", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_mutasi_dtl", "mutasiHdr_idMutasiHdr", "dbo.tb_mutasi_hd");
            DropForeignKey("dbo.tb_mutasi_dtl", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_kasirLogin", "KasirID", "dbo.tb_user");
            DropForeignKey("dbo.tb_kartu_stock", "LokasiID", "dbo.tbl_lokasi");
            DropForeignKey("dbo.tb_kartu_stock", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_barang_history", "SatuanKecil_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_barang_history", "SatuanBesar_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_barang_history", "MerkID", "dbo.tb_Merk");
            DropForeignKey("dbo.tb_barang_history", "GroupBarangID", "dbo.tb_Group");
            DropForeignKey("dbo.tb_barcode", "BarangHistory_BarangHistoryID", "dbo.tb_barang_history");
            DropForeignKey("dbo.tb_adjustment_dtl", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_barang", "SatuanKecil_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_barang", "SatuanBesar_IdSatuan", "dbo.tb_satuan");
            DropForeignKey("dbo.tb_barang", "MerkID", "dbo.tb_Merk");
            DropForeignKey("dbo.tb_barang", "GroupBarangID", "dbo.tb_Group");
            DropForeignKey("dbo.tb_barcode", "BarangID", "dbo.tb_barang");
            DropForeignKey("dbo.tb_adjustment_dtl", "adjustmentHdr_idAdjusmentHdr", "dbo.tb_adjustment_hd");
            DropForeignKey("dbo.tb_adjustment_hd", "LokasiID", "dbo.tbl_lokasi");
            DropIndex("dbo.tb_terima_hd", new[] { "supplier_idSupplier" });
            DropIndex("dbo.tb_terima_dtl", new[] { "terimaHdr_idTerimaHdr" });
            DropIndex("dbo.tb_terima_dtl", new[] { "pesanDtl_idPesanDtl" });
            DropIndex("dbo.tb_stock", new[] { "BarangID" });
            DropIndex("dbo.tb_stock", new[] { "lokasiID" });
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
            DropIndex("dbo.tb_kasirLogin", new[] { "KasirID" });
            DropIndex("dbo.tb_kartu_stock", new[] { "LokasiID" });
            DropIndex("dbo.tb_kartu_stock", new[] { "BarangID" });
            DropIndex("dbo.tb_barang_history", new[] { "SatuanKecil_IdSatuan" });
            DropIndex("dbo.tb_barang_history", new[] { "SatuanBesar_IdSatuan" });
            DropIndex("dbo.tb_barang_history", new[] { "MerkID" });
            DropIndex("dbo.tb_barang_history", new[] { "GroupBarangID" });
            DropIndex("dbo.tb_barcode", new[] { "BarangHistory_BarangHistoryID" });
            DropIndex("dbo.tb_barcode", new[] { "BarangID" });
            DropIndex("dbo.tb_barang", new[] { "SatuanKecil_IdSatuan" });
            DropIndex("dbo.tb_barang", new[] { "SatuanBesar_IdSatuan" });
            DropIndex("dbo.tb_barang", new[] { "MerkID" });
            DropIndex("dbo.tb_barang", new[] { "GroupBarangID" });
            DropIndex("dbo.tb_adjustment_hd", new[] { "LokasiID" });
            DropIndex("dbo.tb_adjustment_dtl", new[] { "adjustmentHdr_idAdjusmentHdr" });
            DropIndex("dbo.tb_adjustment_dtl", new[] { "BarangID" });
            DropTable("dbo.tb_UserAksesMenu");
            DropTable("dbo.tb_terima_hd");
            DropTable("dbo.tb_terima_dtl");
            DropTable("dbo.tb_stock");
            DropTable("dbo.tb_supplier");
            DropTable("dbo.tb_pesan_hd");
            DropTable("dbo.tb_pesan_dtl");
            DropTable("dbo.tb_penjualanHd");
            DropTable("dbo.tb_penjualanDtl");
            DropTable("dbo.tb_parameter");
            DropTable("dbo.tb_mutasi_hd");
            DropTable("dbo.tb_mutasi_dtl");
            DropTable("dbo.tbl_logger");
            DropTable("dbo.tb_lastNo_trans");
            DropTable("dbo.tb_lastno");
            DropTable("dbo.tb_kasirLogin");
            DropTable("dbo.tb_user");
            DropTable("dbo.tb_kartu_stock");
            DropTable("dbo.tb_DaftarMenu");
            DropTable("dbo.tb_barang_history");
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
