using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_user")]
    public class Kasir
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity) ]
        [Column("idUser")]
        public int KasirID { get; set; }
        
        [MaxLength(20)]
        [Column("vc_un")]
        public string KodeKasir { get; set; }

        [MaxLength(50)]
        [Column("vc_nama")]
        public string NamaKasir { get; set; }

        [Column("bt_aktif")]
        public bool Aktif { get; set; }

        [Column("vc_password")]
        public string Password { get; set; }

        [Column("vc_nik")]
        [MaxLength(4)]
        public string nik { get; set; }

        [Column("bt_kasir")]
        public bool isKasir { get; set; }
    }
}
