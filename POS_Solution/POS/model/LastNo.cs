using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_lastno")]
    public class LastNo
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("idLastNo")]
        public int LastNoId { get; set; }

        [Column("vc_kode")]
        [MaxLength(2)]
        public string kode { get; set; }

        [Column("vc_keterangan")]
        [MaxLength(50)]
        public string keterangan { get; set; }

        [Column("in_lastNo")]
        public int lastNo { get; set; }

    }
}
