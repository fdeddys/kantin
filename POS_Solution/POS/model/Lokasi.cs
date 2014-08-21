using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tbl_lokasi")]
    public class Lokasi
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int LokasiID { get; set; }

        [MaxLength(50)]
        public string NamaLokasi { get; set; }

        public bool hapus { get; set; }

        [MaxLength(30)]
        public string namaStore { get; set; }

        [MaxLength(50)]
        public string alamat1 { get; set; }

        [MaxLength(50)]
        public string alamat2 { get; set; }


    }
}
