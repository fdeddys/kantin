using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_Group")]
    public class GroupBarang
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idGroup { get; set; }
        
        [MaxLength(50)]
        public string namaGroup { get; set; }

        public virtual List<Barang> Barangs { get; set; }

        public GroupBarang()
        {
            this.Barangs = new List<Barang>();
        }

    }
}
