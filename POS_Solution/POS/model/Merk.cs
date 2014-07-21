using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_Merk")]
    public class Merk
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdMerk { get; set; }

        [MaxLength(50)]
        public string namaMerk { get; set; }

        //public int BarangID { get; set; }
        //public virtual ICollection<Barang> Barang { get; set; }


    }
}
