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
        [Column("idTerimaHdr")]
        public int TerimaHdrID { get; set; }

        public int idSupplier { get; set; }
        public virtual Supplier supplier { get; set; }

        //TRyyMM9999
        [MaxLength(11)]
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

        public DateTime tglTempo { get; set; }

        public DateTime tglFaktur { get; set; }

        public double discTotal { get; set; }

        public double ppnTotal { get; set; }

        public double biayaLain { get; set; }

        public double grandTotal { get; set; }

        public bool hapus { get; set; }

        public int JenisFakturID { get; set; }
        public virtual JenisFaktur JenisFaktur { get; set; }

        public int JenisPpnID { get; set; }
        public virtual JenisPpn JenisPpn { get; set; }


    }
}
