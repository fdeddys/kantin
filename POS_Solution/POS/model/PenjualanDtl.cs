using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_penjualanDtl")]
    public class PenjualanDtl
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int penjualanDtlID { get; set; }

        public int PenjualanHdrID { get; set; }
        public virtual PenjualanHdr PenjualanHdr { get; set; }

        public int BarangID { get; set; }
        public virtual Barang Barang { get; set; }

        public double jumlah { get; set; }
        public double harga { get; set; }
        public bool batal { get; set; }

    }
}
