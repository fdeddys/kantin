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
            //Database.SetInitializer<PosContext>(new DropCreateDatabaseIfModelChanges<PosContext>());
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
        public DbSet<AdjustmentHdr> AdjustmentHdrContext { get; set; }
        public DbSet<AdjustmentDtl> AdjustmentDtlContext { get; set; }
        public DbSet<PenjualanHdr> PenjualanHdrContext { get; set; }
        public DbSet<PenjualanDtl> PenjualanDtlContext { get; set; }
        public DbSet<KasirLogin> KasirLoginContext { get; set; }
        public DbSet<UserAksesMenu> UserAksesMenuContext { get; set; }
        public DbSet<LastNo> LastNoContext { get; set; }
        public DbSet<LastNoTrans> LastNoTransContext { get; set; }
        public DbSet<Stock> StockContext { get; set; }
        public DbSet<DaftarMenu> DaftarMenuContext { get; set; }
        public DbSet<BarangHistory> BarangHistoryContext { get; set; }
        public DbSet<JenisFaktur> JenisFakturContext { get; set; }
        public DbSet<JenisPpn> JenisPpnContext { get; set; }
        public DbSet<BayarHdr> BayarHdrContext { get; set; }
        public DbSet<BayarDtl> BayarDtlContext { get; set; }
        public DbSet<JenisBayar> JenisBayarContext { get; set; }
        public DbSet<BayarTagihan> BayarTagihanContext { get; set; }

       

    }
}
