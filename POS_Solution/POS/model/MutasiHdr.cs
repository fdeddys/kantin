using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_mutasi_hd")]
    public class MutasiHdr
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idMutasiHdr { get; set; }

        public DateTime tanggal { get; set; }

        public virtual Lokasi lokasiAsal { get; set; }
        
        public virtual Lokasi LokasiTujuan { get; set; }

        public bool approve { get; set; }

        public string userUpdate { get; set; }

        public DateTime lastUpdate { get; set; }

    }
}
