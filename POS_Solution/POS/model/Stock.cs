using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_stock")]
    public class Stock
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("idStock")]
        public int StockId { get; set; }

        public int lokasiID { get; set; }
        public virtual Lokasi Lokasi { get; set; }

        public int BarangID { get; set; }
        public virtual Barang Barang { get; set; }

        public int Jumlah { get; set; }

    }
}

