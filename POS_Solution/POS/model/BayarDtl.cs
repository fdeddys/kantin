using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_bayar_dtl")]
    public class BayarDtl
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BayarDtlID { get; set; }

        [MaxLength(50)]
        public string noRek { get; set; }

        public double subTotal { get; set; }

        public int BayarHdrID { get; set; }
        public virtual BayarHdr BayarHdr { get; set; }

        public int JenisBayarID { get; set; }
        public virtual JenisBayar JenisBayar { get; set; }

    }
}
