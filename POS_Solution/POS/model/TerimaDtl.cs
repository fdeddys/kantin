using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_terima_dtl")]
    public class TerimaDtl
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idTerimaDtl { get; set; }

        public int TerimaHdrID { get; set; }
        public virtual TerimaHdr terimaHdr { get; set; }

        public int pesanDtlID { get; set; }
        public virtual PesanDtl pesanDtl { get; set; }

        public double jumlah { get; set; }


        public double disc1 { get; set; }
        
        public double disc2 { get; set; }

        public int barangID { get; set; }
        public virtual Barang barang { get; set; }

        public double hargaDasar { get; set; }

        [Column("disc1_pr")]
        public double disc1Pr { get; set; }
        
        public double ppn { get; set; }

        [Column("disc2_pr")]
        public double disc2Pr { get; set; }

        public double hargaBeli { get; set; }

        [Column("sub_total")]
        public double subTotal{ get; set; }

        public int konversiSatuan { get; set; }

    }
}
