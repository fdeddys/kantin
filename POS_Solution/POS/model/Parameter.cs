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


        [Column("idLokasi_GudangMasuk")]
        public int idLokasiGudangMasuk { get; set; }
        
        // automatic isi qty = 1 saat penjualan kasir 
        public bool autoQtySales { get; set; }

        [MaxLength(2)]
        public string pesan { get; set; }

        [MaxLength(2)]
        public string terima { get; set; }

        [MaxLength(2)]
        public string returPenerimaan { get; set; }

        [MaxLength(2)]
        public string penyesuaian { get; set; }

        [MaxLength(2)]
        public string mutasi { get; set; }

        [MaxLength(2)]
        public string penjualan { get; set; }

        [MaxLength(2)]
        public string pembayaran { get; set; }

        public string stokAwal { get; set; }

        public double saldoAwalKasir { get; set; }

        //PO, TR, RR, AJ, MS, IV, FT, AW

        [MaxLength(45)]
        public string footer1 { get; set; }

        [MaxLength(45)]
        public string footer2 { get; set; }

        [MaxLength(45)]
        public string footer3 { get; set; }

    }
}
