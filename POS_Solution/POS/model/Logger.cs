using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tbl_logger")]
    public class Logger
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idLogger { get; set; }
        [MaxLength(50)]
        public string NamaUser { get; set; }
        [MaxLength(20)]
        public string Waktu { get; set; }
        [MaxLength(50)]
        public string NamaPos { get; set; }
        public bool Sukses { get; set; }

    }
}
