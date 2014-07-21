using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_mutasi_dtl")]
    public class MutasiDtl
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idMutasiDtl { get; set; }

        public virtual MutasiHdr mutasiHdr { get; set; }

        public int BarangID { get; set; }
        public virtual Barang Barang{ get; set; }

        public double qty { get; set; }

        public double nilaiBarang { get; set; }

    }
}
