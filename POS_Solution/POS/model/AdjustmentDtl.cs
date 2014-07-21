using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_adjustment_dtl")]
    public class AdjustmentDtl
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idAdjusmentDtl { get; set; }

        public virtual AdjustmentHdr adjustmentHdr { get; set; }

        public int BarangID { get; set; }
        public virtual Barang Barang { get; set; }

        public double qty { get; set; }

        public double nilaiBarang { get; set; }

    }
}
