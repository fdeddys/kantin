using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_satuan")]
    public class Satuan
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdSatuan { get; set; }

        [MaxLength(50)]
        public String NamaSatuan { get; set; }

        public virtual List<Barang> Barangs { get; set; }

        public Satuan()
        {
            this.Barangs = new List<Barang>();
        }

    }
}
