using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_kasirLogin")]
    public class KasirLogin
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int KasirLoginID { get; set; }
         
        public string TglTransaksi { get; set; }

        public bool OpenShift { get; set; }
        public DateTime WaktuOpenShift { get; set; }       

        public double SaldoAwal { get; set; }

        public int KasirID { get; set; }
        public virtual Kasir Kasir { get; set; }

    }
}
