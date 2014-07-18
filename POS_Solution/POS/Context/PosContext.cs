using POS.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Context
{
    public class PosContext : DbContext
    {
        public PosContext()  : base("ConnecKeSqlServer")
        {
            
        }

        static PosContext()
        {
            Database.SetInitializer<PosContext>(new CreateDatabaseIfNotExists<PosContext>());
        }

        public DbSet<Barang> BarangContext { get; set;}
        public DbSet<GroupBarang> GroupBarangContext { get; set; }
        public DbSet<Satuan> SatuanContext { get; set; }
        public DbSet<Barcode> BarcodeContext { get; set; }
        public DbSet<Logger> LoggerContext { get; set; }
        public DbSet<Lokasi> LokasiContext { get; set; }
        public DbSet<Parameter> ParameterContext { get; set; }
        public DbSet<Kasir> KasirContext { get; set; }
        public DbSet<Merk> MerkContext { get; set; }
        public DbSet<KartuStock> KartuStockContext { get; set; }
        public DbSet<MutasiHdr> MutasiHdrContext { get; set; }
        public DbSet<MutasiDtl> MutasiDtlContext { get; set; }
        public DbSet<PesanHdr> PesanHdrContext { get; set; }
        public DbSet<PesanDtl> PesanDtlContext { get; set; }
        public DbSet<Supplier> SupplierContext { get; set; }
        public DbSet<TerimaHdr> TerimaHdrContext { get; set; }
        public DbSet<TerimaDtl> TerimaDtlContext { get; set; }
        public DbSet<AdjustmentHdr> AdjustmentHdr { get; set; }
        public DbSet<AdjustmentDtl> AdjustmentDtl { get; set; }


    }
}
