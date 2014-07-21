using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_pesan_dtl")]
    public class PesanDtl
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idPesanDtl { get; set; }

        public virtual PesanHdr pesanHdr { get; set; }

        public int BarangID { get; set; }
        public virtual Barang  Barang { get; set; }

        public double jumlah { get; set; }

        public bool isTerima { get; set; }

        public virtual Satuan satuan { get; set; }

    }
}
