using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_jnsFaktur")]
    public class JenisFaktur
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("idJnsFaktur")]
        public int JenisFakturID { get; set; }

        [MaxLength(50)]
        public string namaJenisFaktur { get; set; }

    }
}
