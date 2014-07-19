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
        public int idPenjualanDtl { get; set; }
        public Barang barang { get; set; }
        public double jumlah { get; set; }
        public double harga { get; set; }

    }
}
