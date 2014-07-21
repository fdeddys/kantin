using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_barang")]
    public class Barang
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BarangID { get; set; }

        [MaxLength(50)]
        public string namaBarang { get; set; }
        
        public Boolean isStock { get; set; }

        public double hargaJual { get; set; }

        public double nilaiBarang { get; set; }

        public int minStock { get; set; }
        
        public virtual GroupBarang GroupBarang { get; set; }

        public virtual Satuan SatuanKecil { get; set; }

        public virtual Satuan SatuanBesar { get; set; }

        public int isi { get; set; }

        public virtual Merk Merk { get; set; }

        public virtual List<Barcode> BarangBarcodes { get; set; }

        public Barang()
        {
            this.BarangBarcodes = new List<Barcode>();
        }

        public string UserUpdate { get; set; }

        public DateTime lastUpdate { get; set; }

        public string kodeBarang { get; set; }

    }
}
