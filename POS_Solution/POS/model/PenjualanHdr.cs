using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_penjualanHd")]
    public class PenjualanHdr
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idPenjualanHd { get; set; }
        public DateTime tanggalJual { get; set; }
        public virtual Kasir kasir { get; set; }
        public virtual Lokasi lokasi { get; set; }
        public double totalBelanja { get; set; }
        public bool isBayar { get; set; }
        public DateTime lastUpdate { get; set; }
        public bool batal { get; set; }

        // FYYmm99999
        [MaxLength(12)]
        public string noFaktur { get; set; }
    }
}

