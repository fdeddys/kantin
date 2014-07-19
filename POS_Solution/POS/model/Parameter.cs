using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_parameter")]
    public class Parameter
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdParameter { get; set; }
        [MaxLength(3) ]
        public string KodeGudangMasuk { get; set; }

        // automatic isi qty = 1 saat penjualan kasir 
        public bool autoQtySales { get; set; } 
    }
}
