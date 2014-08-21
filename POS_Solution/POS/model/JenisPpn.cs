using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_jnsPpn")]
    public class JenisPpn
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("idJnsPpn")]
        public int JenisPpnID { get; set; }

        [MaxLength(50)]
        public string namaJenisPpn { get; set; }

    }
}
