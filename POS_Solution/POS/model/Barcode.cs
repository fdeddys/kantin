using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_barcode")]
    public class Barcode
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BarcodeId { get; set; }

        public virtual Barang Barang { get; set; }

        [MaxLength(100)]
        public string barcodeIsi { get; set; }

    }
}
