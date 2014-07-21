using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tbl_kasir")]
    public class Kasir
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity) ]
        public int KasirID { get; set; }
        
        [MaxLength(20)]
        public string KodeKasir { get; set; }

        [MaxLength(50)]
        public string NamaKasir { get; set; }

        public bool Aktif { get; set; }

        public string Password { get; set; }

    }
}
