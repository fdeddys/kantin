using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_DaftarMenu")]
    public class DaftarMenu
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int DaftarMenuID { get; set; }

        [Column("vc_kd_menu")]
        [MaxLength(10)]
        public string kdMenu { get; set; }

        [Column("vc_nm_menu")]
        [MaxLength(50)]
        public string namaMenu { get; set; }

        [Column("vc_nm_program")]
        [MaxLength(50)]
        public string namaProgram { get; set; }

    }
}
