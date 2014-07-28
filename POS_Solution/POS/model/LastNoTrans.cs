using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_lastNo_trans")]
    public class LastNoTrans
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("idLastNoTrans")]
        public int LastNoTransID { get; set; }

        [Column("vc_kode")]
        [MaxLength(2)]
        public string kode { get; set; }

        [Column("si_tahun")]
        public int tahun { get; set; }

        [Column("si_bulan")]
        public int bulan { get; set; }

        [Column("in_lastNo")]
        public int lastNo { get; set; }
    }
}
