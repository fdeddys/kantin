using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_pesan_hd")]
    public class PesanHdr
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idPesanHdr { get; set; }

        public int idSupplier { get; set; }
        public virtual Supplier supplier { get; set; }

        public DateTime tglPesan { get; set; }

        public int tempo { get; set; }

        public string catatan { get; set; }

        public bool approve { get; set; }

        public string userUpdate { get; set; }

        public DateTime lastUpdate { get; set; }

        [MaxLength(11)]
        public string noPO { get; set; }

    }
}
