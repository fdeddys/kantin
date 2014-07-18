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

        public virtual TerimaHdr terimaHdr { get; set; }

        public virtual PesanDtl pesanDtl { get; set; }

        public double jumlah { get; set; }

        public double disc1 { get; set; }
        
        public double disc2 { get; set; }

            
    }
}
