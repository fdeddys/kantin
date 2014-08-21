using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_bayar_hd")]
    public class BayarHdr
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BayarHdrID { get; set; }

        [MaxLength(20)]
        public string userUpdate { get; set; }

        public DateTime lastUpdate { get; set; }

        public bool approved { get; set; }

        public bool hapus { get; set; }

        public DateTime tanggal { get; set; }

        [Column("total_tagihan")]
        public double totalTagihan { get; set; }

        [Column("total_bayar")]
        public double totalBayar { get; set; }

        public double pembulatan { get; set; }

        public int idSupplier { get; set; }
        public virtual Supplier Supplier { get; set; } 

    }
}