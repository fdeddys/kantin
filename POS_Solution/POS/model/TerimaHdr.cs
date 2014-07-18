using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_terima_hd")]
    public class TerimaHdr
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idTerimaHdr { get; set; }
        public virtual Supplier supplier { get; set; }

        //TRyyMM9999
        public string noTerima { get; set; }

        public DateTime tglTerima{ get; set; }

        public int tempo { get; set; }

        public string catatan { get; set; }

        public string noFaktur{ get; set; }

        public double total{ get; set; }

        public bool isPpn { get; set; }

        public double discGlobal { get; set; }

        public bool approve { get; set; }

        public bool isTarikPembayaran { get; set; }

        public string userUpdate { get; set; }

        public DateTime lastUpdate { get; set; }

    }
}
