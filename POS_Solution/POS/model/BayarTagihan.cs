using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_bayar_tagihan")]
    public class BayarTagihan
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BayarTagihanID { get; set; }

        public double grandTotal { get; set; }

        public int BayarHdrID { get; set; }
        [ForeignKey("BayarHdrID")]
        public virtual BayarHdr BayarHdr { get; set; }

        public int TerimaHdrID { get; set; }
        [ForeignKey("TerimaHdrID")]
        public virtual TerimaHdr TerimaHdr { get; set; }
        //
        //public virtual TerimaHdr TerimaHdr { get; set; }

    }
}
