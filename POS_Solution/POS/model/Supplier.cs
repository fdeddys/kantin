using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_supplier")]
    public class Supplier
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }        

        [MaxLength(100)]
        public string namaSupplier { get; set; }

        [MaxLength(300)]
        public string alamat { get; set; }

        [MaxLength(50)]
        public string kota { get; set; }

        [MaxLength(30)]
        public string telp { get; set; }

        [MaxLength(30)]
        public string fax { get; set; }

        [MaxLength(50)]
        public string cPerson { get; set; }

        public string userUpdate { get; set; }

        public DateTime lastUpdate { get; set; }

        public bool hapus { get; set; }

    }
}
