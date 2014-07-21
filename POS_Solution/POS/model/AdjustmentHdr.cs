using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_adjustment_hd")]
    public class AdjustmentHdr
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idAdjusmentHdr { get; set; }

        //ADyyMM9999
        public string noAdjusment { get; set; }

        [MaxLength(100)]
        public string catatan { get; set; }

        public int LokasiID { get; set; }

        public virtual Lokasi Lokasi{ get; set; }

        public bool approve { get; set; }

        public string userUpdate { get; set; }

        public DateTime lastUpdate { get; set; }

    }
}
